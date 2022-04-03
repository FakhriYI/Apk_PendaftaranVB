<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPendaftaran
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblnama = New System.Windows.Forms.TextBox()
        Me.lbltgl = New System.Windows.Forms.Label()
        Me.TxtIDKol = New System.Windows.Forms.TextBox()
        Me.txtidpermbayaran = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtprodi = New System.Windows.Forms.TextBox()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btncetak = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnReset = New System.Windows.Forms.Button()
        Me.BtnProses = New System.Windows.Forms.Button()
        Me.txtidmahasiswa = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtidmahasiswa)
        Me.Panel1.Controls.Add(Me.lblnama)
        Me.Panel1.Controls.Add(Me.lbltgl)
        Me.Panel1.Controls.Add(Me.TxtIDKol)
        Me.Panel1.Controls.Add(Me.txtidpermbayaran)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(527, 113)
        Me.Panel1.TabIndex = 13
        '
        'lblnama
        '
        Me.lblnama.Location = New System.Drawing.Point(260, 46)
        Me.lblnama.Name = "lblnama"
        Me.lblnama.ReadOnly = True
        Me.lblnama.Size = New System.Drawing.Size(178, 20)
        Me.lblnama.TabIndex = 9
        Me.lblnama.Text = "Nama Mahasiswa"
        '
        'lbltgl
        '
        Me.lbltgl.AutoSize = True
        Me.lbltgl.Location = New System.Drawing.Point(453, 6)
        Me.lbltgl.Name = "lbltgl"
        Me.lbltgl.Size = New System.Drawing.Size(64, 13)
        Me.lbltgl.TabIndex = 8
        Me.lbltgl.Text = "-TANGGAL-"
        '
        'TxtIDKol
        '
        Me.TxtIDKol.Location = New System.Drawing.Point(102, 79)
        Me.TxtIDKol.Name = "TxtIDKol"
        Me.TxtIDKol.Size = New System.Drawing.Size(152, 20)
        Me.TxtIDKol.TabIndex = 3
        '
        'txtidpermbayaran
        '
        Me.txtidpermbayaran.Enabled = False
        Me.txtidpermbayaran.Location = New System.Drawing.Point(102, 15)
        Me.txtidpermbayaran.Name = "txtidpermbayaran"
        Me.txtidpermbayaran.Size = New System.Drawing.Size(152, 20)
        Me.txtidpermbayaran.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Program Studi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Mahasiswa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Pembayaran"
        '
        'txtprodi
        '
        Me.txtprodi.Location = New System.Drawing.Point(113, -290)
        Me.txtprodi.Name = "txtprodi"
        Me.txtprodi.Size = New System.Drawing.Size(152, 20)
        Me.txtprodi.TabIndex = 5
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(328, 21)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(178, 20)
        Me.txttotal.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(139, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Biaya Pendaftaran"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btncetak)
        Me.Panel3.Controls.Add(Me.txttotal)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtprodi)
        Me.Panel3.Location = New System.Drawing.Point(12, 206)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(527, 73)
        Me.Panel3.TabIndex = 16
        '
        'btncetak
        '
        Me.btncetak.Location = New System.Drawing.Point(15, 18)
        Me.btncetak.Name = "btncetak"
        Me.btncetak.Size = New System.Drawing.Size(122, 24)
        Me.btncetak.TabIndex = 6
        Me.btncetak.Text = "Cetak Kwitansi"
        Me.btncetak.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnReset)
        Me.Panel2.Controls.Add(Me.BtnProses)
        Me.Panel2.Location = New System.Drawing.Point(12, 122)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(527, 78)
        Me.Panel2.TabIndex = 14
        '
        'BtnReset
        '
        Me.BtnReset.Location = New System.Drawing.Point(260, 18)
        Me.BtnReset.Name = "BtnReset"
        Me.BtnReset.Size = New System.Drawing.Size(178, 40)
        Me.BtnReset.TabIndex = 5
        Me.BtnReset.Text = "Reset"
        Me.BtnReset.UseVisualStyleBackColor = True
        '
        'BtnProses
        '
        Me.BtnProses.Location = New System.Drawing.Point(76, 18)
        Me.BtnProses.Name = "BtnProses"
        Me.BtnProses.Size = New System.Drawing.Size(178, 40)
        Me.BtnProses.TabIndex = 4
        Me.BtnProses.Text = "Proses"
        Me.BtnProses.UseVisualStyleBackColor = True
        '
        'txtidmahasiswa
        '
        Me.txtidmahasiswa.Location = New System.Drawing.Point(102, 46)
        Me.txtidmahasiswa.Name = "txtidmahasiswa"
        Me.txtidmahasiswa.Size = New System.Drawing.Size(152, 20)
        Me.txtidmahasiswa.TabIndex = 2
        '
        'FrmPendaftaran
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 294)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmPendaftaran"
        Me.Text = "FrmPembayaran"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblnama As System.Windows.Forms.TextBox
    Friend WithEvents lbltgl As System.Windows.Forms.Label
    Friend WithEvents TxtIDKol As System.Windows.Forms.TextBox
    Friend WithEvents txtprodi As System.Windows.Forms.TextBox
    Friend WithEvents txtidpermbayaran As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btncetak As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents BtnReset As System.Windows.Forms.Button
    Friend WithEvents BtnProses As System.Windows.Forms.Button
    Friend WithEvents txtidmahasiswa As System.Windows.Forms.TextBox
End Class
