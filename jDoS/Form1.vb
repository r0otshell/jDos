Imports System.Net

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        Shell("Ping " + (TextBox1.Text + "-1" + "65000"))
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            If TextBox2.Text.Contains("http://") Then
                Dim iphe As IPHostEntry = Dns.GetHostEntry(TextBox2.Text.Replace("http://", String.Empty))
                TextBox2.Text = iphe.AddressList(0).ToString()
            Else
                Dim iphe As IPHostEntry = Dns.GetHostEntry(TextBox2.Text)
                TextBox2.Text = iphe.AddressList(0).ToString()
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class


