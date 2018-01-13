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
Imports System.Threading

Public Class Form1

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
        Dim multicast_point As IPEndPoint = New IPEndPoint(IPAddress.Parse(multicast_ip), remote_port)
        ' リモートエンドポイント
        Dim remote_point As IPEndPoint = Nothing

        ' 受信文字列
        Dim received_text As String = String.Empty

        ' マルチキャスト用クライアントを作成
        Dim multicast_client As UdpClient = New UdpClient(local_port, use_address_family)
        Try
            ' マルチキャストグループに加入（join）
            multicast_client.JoinMulticastGroup(multicast_point.Address)

            Dim transfer_encoding As Encoding = Encoding.UTF8
            Dim receive_bytes As Byte()

            WriteLog(String.Format("local end point: {0}", multicast_client.Client.LocalEndPoint))

            ' データ受信
            receive_bytes = multicast_client.Receive(remote_point)

            WriteLog(String.Format("remote point: {0}", remote_point))
            WriteLog(String.Format("{0} バイト受信しました。", receive_bytes.Length))

            ' 受信データを文字列に変換
            received_text = transfer_encoding.GetString(receive_bytes)

            WriteLog(received_text)

            ' マルチキャストグループから脱退
            multicast_client.DropMulticastGroup(multicast_point.Address)

            ' クライアントを閉じる
            multicast_client.Close()

        Catch ex1 As SocketException
            WriteLog("SocketException:" & ex1.Message)
        Catch ex2 As Exception
            WriteLog("Exception:" & ex2.Message)
        End Try

    End Sub

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
        Dim multicast_point As IPEndPoint = New IPEndPoint(IPAddress.Parse(multicast_ip), remote_port)

        ' マルチキャスト用のクライアントを作成
        Dim multicast_client As UdpClient = New UdpClient(local_port, use_address_family)
        Try
            ' マルチキャストグループに加入（join）
            multicast_client.JoinMulticastGroup(multicast_point.Address)

            Dim transfer_encoding As Encoding = Encoding.UTF8
            Dim sent_text As String = "exit"
            Dim sent_bytes As Byte() = transfer_encoding.GetBytes(sent_text)

            WriteLog(String.Format("local end point: {0}", multicast_client.Client.LocalEndPoint))

            'リモートホストを指定してデータを送信
            multicast_client.Send(sent_bytes, sent_bytes.Length, multicast_point)

            WriteLog(String.Format("{0} バイト送信しました。", sent_bytes.Length))

            ' マルチキャストグループから脱退
            multicast_client.DropMulticastGroup(multicast_point.Address)

            ' クライアントを閉じる
            multicast_client.Close()

        Catch ex1 As SocketException
            WriteLog("SocketException:" & ex1.Message)
        Catch ex2 As Exception
            WriteLog("Exception:" & ex2.Message)
        End Try
    End Sub

    ''' <summary>
    ''' ログ出力
    ''' </summary>
    ''' <param name="msg">メッセージ</param>
    Private Sub WriteLog(ByVal msg As String)
        Me.tbxLog.AppendText(msg & vbCrLf)
    End Sub

End Class
