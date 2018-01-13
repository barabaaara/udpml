'MIT License

'Copyright(c) 2018 barabaaara

'Permission Is hereby granted, free Of charge, to any person obtaining a copy
'of this software And associated documentation files (the "Software"), to deal
'in the Software without restriction, including without limitation the rights
'to use, copy, modify, merge, publish, distribute, sublicense, And/Or sell
'copies of the Software, And to permit persons to whom the Software Is
'furnished to do so, subject to the following conditions:

'The above copyright notice And this permission notice shall be included In all
'copies Or substantial portions of the Software.

'THE SOFTWARE Is PROVIDED "AS IS", WITHOUT WARRANTY Of ANY KIND, EXPRESS Or
'IMPLIED, INCLUDING BUT Not LIMITED To THE WARRANTIES Of MERCHANTABILITY,
'FITNESS FOR A PARTICULAR PURPOSE And NONINFRINGEMENT. IN NO EVENT SHALL THE
'AUTHORS Or COPYRIGHT HOLDERS BE LIABLE For ANY CLAIM, DAMAGES Or OTHER
'LIABILITY, WHETHER In AN ACTION Of CONTRACT, TORT Or OTHERWISE, ARISING FROM,
'OUT OF Or IN CONNECTION WITH THE SOFTWARE Or THE USE Or OTHER DEALINGS IN THE
'SOFTWARE.

Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Form1

#Region "共通変数"
    ' マルチキャストグループ用のエンドポイント
    Dim multicast_point As IPEndPoint = Nothing

    ' マルチキャスト用クライアント
    Dim multicast_client As UdpClient = Nothing
#End Region

#Region "共通イベント"
    ''' <summary>
    ''' クローズイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        If multicast_client IsNot Nothing Then
            ' クライアントを閉じる
            multicast_client.Close()
        End If
    End Sub
#End Region

#Region "受信関連"
    ' リモートエンドポイント
    Dim remote_point As IPEndPoint = Nothing

    ' 受信バイナリ
    Dim receive_bytes As Byte()

    ' 受信文字列
    Dim received_text As String = String.Empty

    Dim receiving As IAsyncResult = Nothing

    ''' <summary>
    ''' recvボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnRecv_Click(sender As Object, e As EventArgs) Handles btnRecv.Click
        Dim use_address_family As AddressFamily = AddressFamily.InterNetwork

        ' マルチキャストIP、ポート番号
        Dim local_port As Integer = Integer.Parse(Me.tbxRecvLocalPort.Text)
        Dim remote_port As Integer = Integer.Parse(Me.tbxRecvRemotePort.Text)
        Dim multicast_ip As String = Me.tbxRecvMuticastIP.Text

        ' マルチキャストグループ用のエンドポイント
        multicast_point = New IPEndPoint(IPAddress.Parse(multicast_ip), remote_port)

        multicast_client = New UdpClient(local_port, use_address_family)
        Try
            ' マルチキャストグループに加入（join）
            multicast_client.JoinMulticastGroup(multicast_point.Address)

            WriteLog(String.Format("local end point: {0}", multicast_client.Client.LocalEndPoint))

            ' 受信開始
            receiving = multicast_client.BeginReceive(AddressOf OnReceiveCompleted, multicast_client)

        Catch ex As SocketException
            WriteLog("SocketException：" & ex.Message)
        Catch ex2 As Exception
            WriteLog("Exception：" & ex2.Message)
        End Try

    End Sub

    ''' <summary>
    ''' 受信イベント
    ''' </summary>
    Private Sub OnReceiveCompleted()
        Try
            Dim transfer_encoding As Encoding = Encoding.UTF8
            ' 受信したバイト数です。
            Dim amount_of_bytes_received As Integer = 0

            receive_bytes = multicast_client.EndReceive(receiving, remote_point)

            Invoke(WriteLogDelegate, String.Format("remote point: {0}", remote_point))

            amount_of_bytes_received = receive_bytes.Length
            Invoke(WriteLogDelegate, String.Format("{0} バイト受信しました。", amount_of_bytes_received))

            received_text = transfer_encoding.GetString(receive_bytes)

            Invoke(WriteLogDelegate, received_text)

            ' マルチキャストグループから脱退
            multicast_client.DropMulticastGroup(multicast_point.Address)

            ' クライアントを閉じる
            multicast_client.Close()

        Catch ex As SocketException
            Invoke(WriteLogDelegate, "SocketException：" & ex.Message)
        Catch ex2 As Exception
            Invoke(WriteLogDelegate, "Exception：" & ex2.Message)
        End Try
    End Sub
#End Region

#Region "送信関連"
    ' 送信したバイト数
    Dim amount_of_bytes_sent As Integer = 0

    Dim sending As IAsyncResult = Nothing

    ''' <summary>
    ''' sendボタンクリック
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim use_address_family As AddressFamily = AddressFamily.InterNetwork

        ' マルチキャストIP、ポート番号
        Dim local_port As Integer = Integer.Parse(Me.tbxSendLocalPort.Text)
        Dim remote_port As Integer = Integer.Parse(Me.tbxSendRemotePort.Text)
        Dim multicast_ip As String = Me.tbxSendMuticastIP.Text

        ' マルチキャストグループのエンドポイント
        multicast_point = New IPEndPoint(IPAddress.Parse(multicast_ip), remote_port)

        ' マルチキャスト用のクライアントを作成
        multicast_client = New UdpClient(local_port, use_address_family)
        Try
            ' ルチキャストグループに加入（join）
            multicast_client.JoinMulticastGroup(multicast_point.Address)

            Dim transfer_encoding As Encoding = Encoding.UTF8
            Dim sent_text As String = "exit"
            Dim sent_bytes As Byte() = transfer_encoding.GetBytes(sent_text)

            WriteLog(String.Format("local end point: {0}", multicast_client.Client.LocalEndPoint))

            ' 送信開始
            sending = multicast_client.BeginSend(sent_bytes, sent_bytes.Length, multicast_point, AddressOf OnSendCompleted, multicast_client)

        Catch ex As SocketException
            WriteLog("SocketException：" & ex.Message)
        Catch ex2 As Exception
            WriteLog("Exception：" & ex2.Message)
        End Try
    End Sub

    ''' <summary>
    ''' 送信イベント
    ''' </summary>
    Private Sub OnSendCompleted()
        Try
            amount_of_bytes_sent = multicast_client.EndSend(sending)

            Invoke(WriteLogDelegate, String.Format("{0} バイト送信しました。", amount_of_bytes_sent))

            ' マルチキャストグループから脱退
            multicast_client.DropMulticastGroup(multicast_point.Address)

            ' クライアントを閉じる
            multicast_client.Close()
        Catch ex As SocketException
            Invoke(WriteLogDelegate, "SocketException：" & ex.Message)
        Catch ex2 As Exception
            Invoke(WriteLogDelegate, "Exception：" & ex2.Message)
        End Try
    End Sub
#End Region

#Region "共通関数"
    Delegate Sub DgWriteLogDelegate(ByVal msg As String)
    Private WriteLogDelegate As New DgWriteLogDelegate(AddressOf WriteLog)

    ''' <summary>
    ''' ログ出力
    ''' </summary>
    ''' <param name="msg">メッセージ</param>
    Private Sub WriteLog(ByVal msg As String)
        Me.tbxLog.AppendText(msg & vbCrLf)
    End Sub
#End Region

End Class
