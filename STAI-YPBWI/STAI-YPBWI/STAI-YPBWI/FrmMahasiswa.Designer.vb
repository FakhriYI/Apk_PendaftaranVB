<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMahasiswa
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMahasiswa))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnama = New System.Windows.Forms.TextBox()
        Me.rblaki = New System.Windows.Forms.RadioButton()
        Me.rbperempuan = New System.Windows.Forms.RadioButton()
        Me.txtkota = New System.Windows.Forms.TextBox()
        Me.txtalamat = New System.Windows.Forms.TextBox()
        Me.txtkodepos = New System.Windows.Forms.TextBox()
        Me.txtnotelp = New System.Windows.Forms.TextBox()
        Me.dtdiri = New System.Windows.Forms.DateTimePicker()
        Me.txtnik = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GBDiri = New System.Windows.Forms.GroupBox()
        Me.rbbelummenikah = New System.Windows.Forms.RadioButton()
        Me.rbmenikah = New System.Windows.Forms.RadioButton()
        Me.cbwarga = New System.Windows.Forms.ComboBox()
        Me.rbbelumbekerja = New System.Windows.Forms.RadioButton()
        Me.rbbekerja = New System.Windows.Forms.RadioButton()
        Me.cbagama = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtidmahasiswa = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtayah = New System.Windows.Forms.TextBox()
        Me.GBWali = New System.Windows.Forms.GroupBox()
        Me.txtpekerjaanwali = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.rblainnya = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtalamatwali = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.rbtamatslta = New System.Windows.Forms.RadioButton()
        Me.rbtamatsltp = New System.Windows.Forms.RadioButton()
        Me.rbtamatsd = New System.Windows.Forms.RadioButton()
        Me.rbtidaktamat = New System.Windows.Forms.RadioButton()
        Me.btnsimpan = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txttahunijasah = New System.Windows.Forms.TextBox()
        Me.txtnamaslta = New System.Windows.Forms.TextBox()
        Me.txtjurusanslta = New System.Windows.Forms.TextBox()
        Me.cbjenisslta = New System.Windows.Forms.ComboBox()
        Me.txtalamatslta = New System.Windows.Forms.TextBox()
        Me.GBAsal = New System.Windows.Forms.GroupBox()
        Me.VisualStyler1 = New SkinSoft.VisualStyler.VisualStyler(Me.components)
        Me.GBDiri.SuspendLayout()
        Me.GBWali.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GBAsal.SuspendLayout()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Lengkap"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Kab/Kota Lahir"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 247)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "KodePos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 273)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "No Telepon"
        '
        'txtnama
        '
        Me.txtnama.Location = New System.Drawing.Point(98, 74)
        Me.txtnama.Name = "txtnama"
        Me.txtnama.Size = New System.Drawing.Size(164, 20)
        Me.txtnama.TabIndex = 7
        '
        'rblaki
        '
        Me.rblaki.AutoSize = True
        Me.rblaki.Location = New System.Drawing.Point(98, 100)
        Me.rblaki.Name = "rblaki"
        Me.rblaki.Size = New System.Drawing.Size(74, 17)
        Me.rblaki.TabIndex = 8
        Me.rblaki.TabStop = True
        Me.rblaki.Text = "Laki - Laki"
        Me.rblaki.UseVisualStyleBackColor = True
        '
        'rbperempuan
        '
        Me.rbperempuan.AutoSize = True
        Me.rbperempuan.Location = New System.Drawing.Point(98, 123)
        Me.rbperempuan.Name = "rbperempuan"
        Me.rbperempuan.Size = New System.Drawing.Size(79, 17)
        Me.rbperempuan.TabIndex = 9
        Me.rbperempuan.TabStop = True
        Me.rbperempuan.Text = "Perempuan"
        Me.rbperempuan.UseVisualStyleBackColor = True
        '
        'txtkota
        '
        Me.txtkota.Location = New System.Drawing.Point(98, 144)
        Me.txtkota.Name = "txtkota"
        Me.txtkota.Size = New System.Drawing.Size(124, 20)
        Me.txtkota.TabIndex = 10
        '
        'txtalamat
        '
        Me.txtalamat.Location = New System.Drawing.Point(98, 196)
        Me.txtalamat.Multiline = True
        Me.txtalamat.Name = "txtalamat"
        Me.txtalamat.Size = New System.Drawing.Size(164, 42)
        Me.txtalamat.TabIndex = 12
        '
        'txtkodepos
        '
        Me.txtkodepos.Location = New System.Drawing.Point(98, 244)
        Me.txtkodepos.Name = "txtkodepos"
        Me.txtkodepos.Size = New System.Drawing.Size(74, 20)
        Me.txtkodepos.TabIndex = 13
        '
        'txtnotelp
        '
        Me.txtnotelp.Location = New System.Drawing.Point(98, 270)
        Me.txtnotelp.Name = "txtnotelp"
        Me.txtnotelp.Size = New System.Drawing.Size(124, 20)
        Me.txtnotelp.TabIndex = 14
        '
        'dtdiri
        '
        Me.dtdiri.Location = New System.Drawing.Point(98, 170)
        Me.dtdiri.Name = "dtdiri"
        Me.dtdiri.Size = New System.Drawing.Size(138, 20)
        Me.dtdiri.TabIndex = 15
        '
        'txtnik
        '
        Me.txtnik.Location = New System.Drawing.Point(98, 48)
        Me.txtnik.Name = "txtnik"
        Me.txtnik.Size = New System.Drawing.Size(124, 20)
        Me.txtnik.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 13)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "NIK"
        '
        'GBDiri
        '
        Me.GBDiri.Controls.Add(Me.rbbelummenikah)
        Me.GBDiri.Controls.Add(Me.rbmenikah)
        Me.GBDiri.Controls.Add(Me.cbwarga)
        Me.GBDiri.Controls.Add(Me.rbbelumbekerja)
        Me.GBDiri.Controls.Add(Me.rbbekerja)
        Me.GBDiri.Controls.Add(Me.cbagama)
        Me.GBDiri.Controls.Add(Me.Label21)
        Me.GBDiri.Controls.Add(Me.Label20)
        Me.GBDiri.Controls.Add(Me.Label19)
        Me.GBDiri.Controls.Add(Me.Label17)
        Me.GBDiri.Controls.Add(Me.txtidmahasiswa)
        Me.GBDiri.Controls.Add(Me.Label18)
        Me.GBDiri.Controls.Add(Me.txtnik)
        Me.GBDiri.Controls.Add(Me.Label8)
        Me.GBDiri.Controls.Add(Me.txtnotelp)
        Me.GBDiri.Controls.Add(Me.txtkodepos)
        Me.GBDiri.Controls.Add(Me.rbperempuan)
        Me.GBDiri.Controls.Add(Me.rblaki)
        Me.GBDiri.Controls.Add(Me.txtnama)
        Me.GBDiri.Controls.Add(Me.Label7)
        Me.GBDiri.Controls.Add(Me.Label6)
        Me.GBDiri.Controls.Add(Me.dtdiri)
        Me.GBDiri.Controls.Add(Me.Label4)
        Me.GBDiri.Controls.Add(Me.txtkota)
        Me.GBDiri.Controls.Add(Me.Label1)
        Me.GBDiri.Controls.Add(Me.txtalamat)
        Me.GBDiri.Controls.Add(Me.Label5)
        Me.GBDiri.Controls.Add(Me.Label3)
        Me.GBDiri.Controls.Add(Me.Label2)
        Me.GBDiri.Location = New System.Drawing.Point(12, 8)
        Me.GBDiri.Name = "GBDiri"
        Me.GBDiri.Size = New System.Drawing.Size(275, 442)
        Me.GBDiri.TabIndex = 18
        Me.GBDiri.TabStop = False
        Me.GBDiri.Text = "Data Diri"
        '
        'rbbelummenikah
        '
        Me.rbbelummenikah.AutoSize = True
        Me.rbbelummenikah.Location = New System.Drawing.Point(98, 392)
        Me.rbbelummenikah.Name = "rbbelummenikah"
        Me.rbbelummenikah.Size = New System.Drawing.Size(98, 17)
        Me.rbbelummenikah.TabIndex = 40
        Me.rbbelummenikah.TabStop = True
        Me.rbbelummenikah.Text = "Belum Menikah"
        Me.rbbelummenikah.UseVisualStyleBackColor = True
        '
        'rbmenikah
        '
        Me.rbmenikah.AutoSize = True
        Me.rbmenikah.Location = New System.Drawing.Point(100, 369)
        Me.rbmenikah.Name = "rbmenikah"
        Me.rbmenikah.Size = New System.Drawing.Size(66, 17)
        Me.rbmenikah.TabIndex = 39
        Me.rbmenikah.TabStop = True
        Me.rbmenikah.Text = "Menikah"
        Me.rbmenikah.UseVisualStyleBackColor = True
        '
        'cbwarga
        '
        Me.cbwarga.FormattingEnabled = True
        Me.cbwarga.Location = New System.Drawing.Point(98, 342)
        Me.cbwarga.Name = "cbwarga"
        Me.cbwarga.Size = New System.Drawing.Size(121, 21)
        Me.cbwarga.TabIndex = 38
        '
        'rbbelumbekerja
        '
        Me.rbbelumbekerja.AutoSize = True
        Me.rbbelumbekerja.Location = New System.Drawing.Point(100, 319)
        Me.rbbelumbekerja.Name = "rbbelumbekerja"
        Me.rbbelumbekerja.Size = New System.Drawing.Size(93, 17)
        Me.rbbelumbekerja.TabIndex = 37
        Me.rbbelumbekerja.TabStop = True
        Me.rbbelumbekerja.Text = "Belum Bekerja"
        Me.rbbelumbekerja.UseVisualStyleBackColor = True
        '
        'rbbekerja
        '
        Me.rbbekerja.AutoSize = True
        Me.rbbekerja.Location = New System.Drawing.Point(100, 296)
        Me.rbbekerja.Name = "rbbekerja"
        Me.rbbekerja.Size = New System.Drawing.Size(61, 17)
        Me.rbbekerja.TabIndex = 36
        Me.rbbekerja.TabStop = True
        Me.rbbekerja.Text = "Bekerja"
        Me.rbbekerja.UseVisualStyleBackColor = True
        '
        'cbagama
        '
        Me.cbagama.FormattingEnabled = True
        Me.cbagama.Location = New System.Drawing.Point(98, 415)
        Me.cbagama.Name = "cbagama"
        Me.cbagama.Size = New System.Drawing.Size(121, 21)
        Me.cbagama.TabIndex = 34
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 418)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 35
        Me.Label21.Text = "Agama"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 371)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 13)
        Me.Label20.TabIndex = 34
        Me.Label20.Text = "Status Sipil"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 345)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 13)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "Kewarganegaraan"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 298)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(88, 13)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "Status Pekerjaan"
        '
        'txtidmahasiswa
        '
        Me.txtidmahasiswa.Location = New System.Drawing.Point(98, 22)
        Me.txtidmahasiswa.Name = "txtidmahasiswa"
        Me.txtidmahasiswa.Size = New System.Drawing.Size(124, 20)
        Me.txtidmahasiswa.TabIndex = 31
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 13)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "ID Calon Mhs"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Nama Wali"
        '
        'txtayah
        '
        Me.txtayah.Location = New System.Drawing.Point(100, 22)
        Me.txtayah.Name = "txtayah"
        Me.txtayah.Size = New System.Drawing.Size(164, 20)
        Me.txtayah.TabIndex = 25
        '
        'GBWali
        '
        Me.GBWali.Controls.Add(Me.txtpekerjaanwali)
        Me.GBWali.Controls.Add(Me.Label14)
        Me.GBWali.Controls.Add(Me.rblainnya)
        Me.GBWali.Controls.Add(Me.Label13)
        Me.GBWali.Controls.Add(Me.txtalamatwali)
        Me.GBWali.Controls.Add(Me.Label11)
        Me.GBWali.Controls.Add(Me.rbtamatslta)
        Me.GBWali.Controls.Add(Me.rbtamatsltp)
        Me.GBWali.Controls.Add(Me.rbtamatsd)
        Me.GBWali.Controls.Add(Me.rbtidaktamat)
        Me.GBWali.Controls.Add(Me.txtayah)
        Me.GBWali.Controls.Add(Me.Label10)
        Me.GBWali.Location = New System.Drawing.Point(296, 187)
        Me.GBWali.Name = "GBWali"
        Me.GBWali.Size = New System.Drawing.Size(299, 192)
        Me.GBWali.TabIndex = 27
        Me.GBWali.TabStop = False
        Me.GBWali.Text = "Data Wali"
        '
        'txtpekerjaanwali
        '
        Me.txtpekerjaanwali.Location = New System.Drawing.Point(99, 119)
        Me.txtpekerjaanwali.Name = "txtpekerjaanwali"
        Me.txtpekerjaanwali.Size = New System.Drawing.Size(164, 20)
        Me.txtpekerjaanwali.TabIndex = 56
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 122)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(55, 13)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "Pekerjaan"
        '
        'rblainnya
        '
        Me.rblainnya.AutoSize = True
        Me.rblainnya.Location = New System.Drawing.Point(209, 71)
        Me.rblainnya.Name = "rblainnya"
        Me.rblainnya.Size = New System.Drawing.Size(65, 17)
        Me.rblainnya.TabIndex = 55
        Me.rblainnya.TabStop = True
        Me.rblainnya.Text = "Lainnya."
        Me.rblainnya.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(10, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(60, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Pendidikan"
        '
        'txtalamatwali
        '
        Me.txtalamatwali.Location = New System.Drawing.Point(100, 145)
        Me.txtalamatwali.Multiline = True
        Me.txtalamatwali.Name = "txtalamatwali"
        Me.txtalamatwali.Size = New System.Drawing.Size(174, 40)
        Me.txtalamatwali.TabIndex = 22
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(39, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Alamat"
        '
        'rbtamatslta
        '
        Me.rbtamatslta.AutoSize = True
        Me.rbtamatslta.Location = New System.Drawing.Point(209, 51)
        Me.rbtamatslta.Name = "rbtamatslta"
        Me.rbtamatslta.Size = New System.Drawing.Size(85, 17)
        Me.rbtamatslta.TabIndex = 54
        Me.rbtamatslta.TabStop = True
        Me.rbtamatslta.Text = "Tamat SLTA"
        Me.rbtamatslta.UseVisualStyleBackColor = True
        '
        'rbtamatsltp
        '
        Me.rbtamatsltp.AutoSize = True
        Me.rbtamatsltp.Location = New System.Drawing.Point(100, 96)
        Me.rbtamatsltp.Name = "rbtamatsltp"
        Me.rbtamatsltp.Size = New System.Drawing.Size(85, 17)
        Me.rbtamatsltp.TabIndex = 53
        Me.rbtamatsltp.TabStop = True
        Me.rbtamatsltp.Text = "Tamat SLTP"
        Me.rbtamatsltp.UseVisualStyleBackColor = True
        '
        'rbtamatsd
        '
        Me.rbtamatsd.AutoSize = True
        Me.rbtamatsd.Location = New System.Drawing.Point(100, 73)
        Me.rbtamatsd.Name = "rbtamatsd"
        Me.rbtamatsd.Size = New System.Drawing.Size(73, 17)
        Me.rbtamatsd.TabIndex = 52
        Me.rbtamatsd.TabStop = True
        Me.rbtamatsd.Text = "Tamat SD"
        Me.rbtamatsd.UseVisualStyleBackColor = True
        '
        'rbtidaktamat
        '
        Me.rbtidaktamat.AutoSize = True
        Me.rbtidaktamat.Location = New System.Drawing.Point(100, 50)
        Me.rbtidaktamat.Name = "rbtidaktamat"
        Me.rbtidaktamat.Size = New System.Drawing.Size(103, 17)
        Me.rbtidaktamat.TabIndex = 34
        Me.rbtidaktamat.TabStop = True
        Me.rbtidaktamat.Text = "Tidak Tamat SD"
        Me.rbtidaktamat.UseVisualStyleBackColor = True
        '
        'btnsimpan
        '
        Me.btnsimpan.Location = New System.Drawing.Point(49, 7)
        Me.btnsimpan.Name = "btnsimpan"
        Me.btnsimpan.Size = New System.Drawing.Size(242, 34)
        Me.btnsimpan.TabIndex = 28
        Me.btnsimpan.Text = "Simpan"
        Me.btnsimpan.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(297, 7)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(242, 34)
        Me.btnreset.TabIndex = 29
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnreset)
        Me.Panel1.Controls.Add(Me.btnsimpan)
        Me.Panel1.Location = New System.Drawing.Point(12, 456)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(583, 46)
        Me.Panel1.TabIndex = 32
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 21)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(69, 13)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Tahun Ijasah"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(6, 48)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(61, 13)
        Me.Label23.TabIndex = 42
        Me.Label23.Text = "Jenis SLTA"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(6, 125)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(69, 13)
        Me.Label24.TabIndex = 43
        Me.Label24.Text = "Alamat SLTA"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(6, 76)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(65, 13)
        Me.Label25.TabIndex = 44
        Me.Label25.Text = "Nama SLTA"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 98)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(74, 13)
        Me.Label26.TabIndex = 45
        Me.Label26.Text = "Jurusan SLTA"
        '
        'txttahunijasah
        '
        Me.txttahunijasah.Location = New System.Drawing.Point(101, 18)
        Me.txttahunijasah.Name = "txttahunijasah"
        Me.txttahunijasah.Size = New System.Drawing.Size(70, 20)
        Me.txttahunijasah.TabIndex = 41
        '
        'txtnamaslta
        '
        Me.txtnamaslta.Location = New System.Drawing.Point(101, 70)
        Me.txtnamaslta.Name = "txtnamaslta"
        Me.txtnamaslta.Size = New System.Drawing.Size(162, 20)
        Me.txtnamaslta.TabIndex = 47
        '
        'txtjurusanslta
        '
        Me.txtjurusanslta.Location = New System.Drawing.Point(101, 96)
        Me.txtjurusanslta.Name = "txtjurusanslta"
        Me.txtjurusanslta.Size = New System.Drawing.Size(162, 20)
        Me.txtjurusanslta.TabIndex = 48
        '
        'cbjenisslta
        '
        Me.cbjenisslta.FormattingEnabled = True
        Me.cbjenisslta.Location = New System.Drawing.Point(101, 43)
        Me.cbjenisslta.Name = "cbjenisslta"
        Me.cbjenisslta.Size = New System.Drawing.Size(97, 21)
        Me.cbjenisslta.TabIndex = 41
        '
        'txtalamatslta
        '
        Me.txtalamatslta.Location = New System.Drawing.Point(101, 122)
        Me.txtalamatslta.Multiline = True
        Me.txtalamatslta.Name = "txtalamatslta"
        Me.txtalamatslta.Size = New System.Drawing.Size(173, 42)
        Me.txtalamatslta.TabIndex = 41
        '
        'GBAsal
        '
        Me.GBAsal.Controls.Add(Me.txtalamatslta)
        Me.GBAsal.Controls.Add(Me.cbjenisslta)
        Me.GBAsal.Controls.Add(Me.Label23)
        Me.GBAsal.Controls.Add(Me.txtjurusanslta)
        Me.GBAsal.Controls.Add(Me.Label22)
        Me.GBAsal.Controls.Add(Me.txtnamaslta)
        Me.GBAsal.Controls.Add(Me.Label24)
        Me.GBAsal.Controls.Add(Me.txttahunijasah)
        Me.GBAsal.Controls.Add(Me.Label25)
        Me.GBAsal.Controls.Add(Me.Label26)
        Me.GBAsal.Location = New System.Drawing.Point(296, 8)
        Me.GBAsal.Name = "GBAsal"
        Me.GBAsal.Size = New System.Drawing.Size(299, 173)
        Me.GBAsal.TabIndex = 49
        Me.GBAsal.TabStop = False
        Me.GBAsal.Text = "Data Asal Sekolah"
        '
        'VisualStyler1
        '
        Me.VisualStyler1.HostForm = Me
        Me.VisualStyler1.License = CType(resources.GetObject("VisualStyler1.License"), SkinSoft.VisualStyler.Licensing.VisualStylerLicense)
        Me.VisualStyler1.LoadVisualStyle(Nothing, "XP Royale (Indigo).vssf")
        '
        'FrmMahasiswa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 510)
        Me.Controls.Add(Me.GBWali)
        Me.Controls.Add(Me.GBDiri)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GBAsal)
        Me.Name = "FrmMahasiswa"
        Me.Text = "Formulir Calon Mahasiswa"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GBDiri.ResumeLayout(False)
        Me.GBDiri.PerformLayout()
        Me.GBWali.ResumeLayout(False)
        Me.GBWali.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.GBAsal.ResumeLayout(False)
        Me.GBAsal.PerformLayout()
        CType(Me.VisualStyler1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnama As System.Windows.Forms.TextBox
    Friend WithEvents rblaki As System.Windows.Forms.RadioButton
    Friend WithEvents rbperempuan As System.Windows.Forms.RadioButton
    Friend WithEvents txtkota As System.Windows.Forms.TextBox
    Friend WithEvents txtalamat As System.Windows.Forms.TextBox
    Friend WithEvents txtkodepos As System.Windows.Forms.TextBox
    Friend WithEvents txtnotelp As System.Windows.Forms.TextBox
    Friend WithEvents dtdiri As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtnik As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GBDiri As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtayah As System.Windows.Forms.TextBox
    Friend WithEvents GBWali As System.Windows.Forms.GroupBox
    Friend WithEvents txtalamatwali As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnsimpan As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtidmahasiswa As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rbbelummenikah As System.Windows.Forms.RadioButton
    Friend WithEvents rbmenikah As System.Windows.Forms.RadioButton
    Friend WithEvents cbwarga As System.Windows.Forms.ComboBox
    Friend WithEvents rbbelumbekerja As System.Windows.Forms.RadioButton
    Friend WithEvents rbbekerja As System.Windows.Forms.RadioButton
    Friend WithEvents cbagama As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txttahunijasah As System.Windows.Forms.TextBox
    Friend WithEvents txtnamaslta As System.Windows.Forms.TextBox
    Friend WithEvents txtjurusanslta As System.Windows.Forms.TextBox
    Friend WithEvents cbjenisslta As System.Windows.Forms.ComboBox
    Friend WithEvents txtalamatslta As System.Windows.Forms.TextBox
    Friend WithEvents GBAsal As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents rbtidaktamat As System.Windows.Forms.RadioButton
    Friend WithEvents rbtamatsd As System.Windows.Forms.RadioButton
    Friend WithEvents rbtamatsltp As System.Windows.Forms.RadioButton
    Friend WithEvents txtpekerjaanwali As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents rblainnya As System.Windows.Forms.RadioButton
    Friend WithEvents rbtamatslta As System.Windows.Forms.RadioButton
    Friend WithEvents VisualStyler1 As SkinSoft.VisualStyler.VisualStyler
End Class
