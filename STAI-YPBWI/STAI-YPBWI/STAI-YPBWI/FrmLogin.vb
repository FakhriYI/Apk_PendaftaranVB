Imports System.Data.SqlClient
Public Class FrmLogin

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click
        Dim perintah As New SqlCommand
        Dim id, pass As String

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()
        perintah = KoneksiSQL.CreateCommand

        id = txtnamauser.Text
        pass = txtpassword.Text


    End Sub
End Class