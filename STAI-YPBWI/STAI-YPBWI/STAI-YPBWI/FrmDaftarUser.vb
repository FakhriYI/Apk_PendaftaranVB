Imports System.Data.SqlClient
Public Class FrmTambahUser
    Private Sub btninsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninsert.Click
        Dim id, nama, pass As String
        Dim perintah As New SqlCommand

        id = txtid.Text
        nama = txtnama.Text
        pass = txtpass.Text

        KoneksiSQL = AmbilKoneksi()
        KoneksiSQL.Open()
        perintah = KoneksiSQL.CreateCommand

        perintah.CommandText = "insert into TUser values ('" & id & "','" & nama & "'," _
            & "'" & pass & "')"
        perintah.ExecuteNonQuery()

        MsgBox("Data berhasil disimpan", MsgBoxStyle.Information, "Informasi")

        txtid.Text = ""
        txtnama.Text = ""
        txtpass.Text = ""
        txtrepass.Text = ""

        txtid.Focus()

        KoneksiSQL.Close()
    End Sub

    Private Sub txtrepas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtrepass.Leave
        Dim pass, repass As String

        pass = txtpass.Text
        repass = txtrepass.Text

        If pass <> repass Then
            MsgBox("Password Tidak Cocok", MsgBoxStyle.Critical, "Warning")
            txtpass.Text = ""
            txtrepass.Text = ""
            txtpass.Focus()
        End If

    End Sub
End Class
