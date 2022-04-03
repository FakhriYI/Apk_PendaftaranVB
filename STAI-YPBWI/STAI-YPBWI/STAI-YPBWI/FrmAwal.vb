Public Class FrmAwal

    Private Sub LOGINToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGINToolStripMenuItem.Click
        Dim xFrmL As New FrmLogin
        xFrmL.MdiParent = Me
        xFrmL.Show()
    End Sub

    Private Sub MAHASISWAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MAHASISWAToolStripMenuItem.Click
        Dim xFrmM As New FrmMahasiswa
        xFrmM.MdiParent = Me
        xFrmM.Show()
    End Sub

    Private Sub PENDAFTARANToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PENDAFTARANToolStripMenuItem.Click
        Dim xFrmP As New FrmPendaftaran
        xFrmP.MdiParent = Me
        xFrmP.Show()
    End Sub
End Class