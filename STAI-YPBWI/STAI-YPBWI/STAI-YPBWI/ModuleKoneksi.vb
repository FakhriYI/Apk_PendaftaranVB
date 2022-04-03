Imports System.Data.SqlClient

Module ModulKoneksi
    Public KoneksiSQL As SqlConnection
    Public iduser As String
    Public cek As String = ""

    Public Function AmbilKoneksi()
        KoneksiSQL = New SqlConnection("server = SONY-PC\SQLEXPRESS; database = DBSTAI; user id = 'sa'; password = 'sa123'")
        'KoneksiSQL = New SqlConnection("server = PAPSI-PC\SQLEXPRESS; database = DBRentalB; trusted_connection=true")
        Return KoneksiSQL
    End Function
End Module
