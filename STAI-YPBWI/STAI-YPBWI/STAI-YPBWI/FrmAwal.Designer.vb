<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LOGINToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UBAHPASSWORDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAHASISWAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PENDAFTARANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BANTUANToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TENTANGKAMIToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MAHASISWAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILEToolStripMenuItem, Me.MASTERToolStripMenuItem, Me.DATAToolStripMenuItem, Me.BANTUANToolStripMenuItem, Me.TENTANGKAMIToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(547, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILEToolStripMenuItem
        '
        Me.FILEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LOGINToolStripMenuItem, Me.UBAHPASSWORDToolStripMenuItem})
        Me.FILEToolStripMenuItem.Name = "FILEToolStripMenuItem"
        Me.FILEToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FILEToolStripMenuItem.Text = "FILE"
        '
        'LOGINToolStripMenuItem
        '
        Me.LOGINToolStripMenuItem.Name = "LOGINToolStripMenuItem"
        Me.LOGINToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.LOGINToolStripMenuItem.Text = "LOGIN"
        '
        'UBAHPASSWORDToolStripMenuItem
        '
        Me.UBAHPASSWORDToolStripMenuItem.Name = "UBAHPASSWORDToolStripMenuItem"
        Me.UBAHPASSWORDToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.UBAHPASSWORDToolStripMenuItem.Text = "UBAH PASSWORD"
        '
        'MASTERToolStripMenuItem
        '
        Me.MASTERToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAHASISWAToolStripMenuItem, Me.PENDAFTARANToolStripMenuItem})
        Me.MASTERToolStripMenuItem.Name = "MASTERToolStripMenuItem"
        Me.MASTERToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.MASTERToolStripMenuItem.Text = "MASTER"
        '
        'MAHASISWAToolStripMenuItem
        '
        Me.MAHASISWAToolStripMenuItem.Name = "MAHASISWAToolStripMenuItem"
        Me.MAHASISWAToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.MAHASISWAToolStripMenuItem.Text = "MAHASISWA"
        '
        'PENDAFTARANToolStripMenuItem
        '
        Me.PENDAFTARANToolStripMenuItem.Name = "PENDAFTARANToolStripMenuItem"
        Me.PENDAFTARANToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.PENDAFTARANToolStripMenuItem.Text = "PENDAFTARAN"
        '
        'BANTUANToolStripMenuItem
        '
        Me.BANTUANToolStripMenuItem.Name = "BANTUANToolStripMenuItem"
        Me.BANTUANToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BANTUANToolStripMenuItem.Text = "BANTUAN"
        '
        'TENTANGKAMIToolStripMenuItem
        '
        Me.TENTANGKAMIToolStripMenuItem.Name = "TENTANGKAMIToolStripMenuItem"
        Me.TENTANGKAMIToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.TENTANGKAMIToolStripMenuItem.Text = "TENTANG KAMI"
        '
        'DATAToolStripMenuItem
        '
        Me.DATAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MAHASISWAToolStripMenuItem1})
        Me.DATAToolStripMenuItem.Name = "DATAToolStripMenuItem"
        Me.DATAToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.DATAToolStripMenuItem.Text = "DATA"
        '
        'MAHASISWAToolStripMenuItem1
        '
        Me.MAHASISWAToolStripMenuItem1.Name = "MAHASISWAToolStripMenuItem1"
        Me.MAHASISWAToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.MAHASISWAToolStripMenuItem1.Text = "MAHASISWA"
        '
        'FrmAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(547, 505)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmAwal"
        Me.Text = "FrmAwal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LOGINToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UBAHPASSWORDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MASTERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAHASISWAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PENDAFTARANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BANTUANToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TENTANGKAMIToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MAHASISWAToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
