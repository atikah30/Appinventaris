<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormTransPengembalian
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LBLOperator = New System.Windows.Forms.Label()
        Me.LBLJam = New System.Windows.Forms.Label()
        Me.LBLTanggalKbl = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.NamaBarang = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.KodeBarang = New System.Windows.Forms.Label()
        Me.LBLNamaAgt = New System.Windows.Forms.Label()
        Me.LBLNoKbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLTelahPinjam = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TXTKODEAGT = New System.Windows.Forms.TextBox()
        Me.LBLNamaBarang = New System.Windows.Forms.Label()
        Me.LBLNoPjm = New System.Windows.Forms.Label()
        Me.NoPinjam = New System.Windows.Forms.Label()
        Me.LBLTglPjm = New System.Windows.Forms.Label()
        Me.TanggalPjm = New System.Windows.Forms.Label()
        Me.LBLLamaPjm = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(37, 524)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(1234, 207)
        Me.DataGridView2.TabIndex = 97
        '
        'LBLTotal
        '
        Me.LBLTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTotal.Location = New System.Drawing.Point(1040, 439)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(231, 34)
        Me.LBLTotal.TabIndex = 95
        Me.LBLTotal.Text = "LBLTotal"
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(892, 439)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 34)
        Me.Label7.TabIndex = 94
        Me.Label7.Text = "Total Kembali"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Button4
        '
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(347, 439)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(149, 45)
        Me.Button4.TabIndex = 93
        Me.Button4.Text = "TUTUP"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(192, 439)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 45)
        Me.Button3.TabIndex = 92
        Me.Button3.Text = "BATAL"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(37, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 45)
        Me.Button2.TabIndex = 91
        Me.Button2.Text = "SIMPAN"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(37, 247)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1234, 177)
        Me.DataGridView1.TabIndex = 90
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1159, 171)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 37)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Input"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(1041, 177)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(112, 26)
        Me.TextBox2.TabIndex = 88
        Me.TextBox2.Text = "TextBox2"
        '
        'Label19
        '
        Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(953, 174)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(82, 33)
        Me.Label19.TabIndex = 87
        Me.Label19.Text = "Jumlah"
        '
        'LBLOperator
        '
        Me.LBLOperator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLOperator.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLOperator.Location = New System.Drawing.Point(1029, 99)
        Me.LBLOperator.Name = "LBLOperator"
        Me.LBLOperator.Size = New System.Drawing.Size(242, 34)
        Me.LBLOperator.TabIndex = 86
        Me.LBLOperator.Text = "LBLOperator"
        '
        'LBLJam
        '
        Me.LBLJam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLJam.Location = New System.Drawing.Point(1029, 69)
        Me.LBLJam.Name = "LBLJam"
        Me.LBLJam.Size = New System.Drawing.Size(242, 30)
        Me.LBLJam.TabIndex = 85
        Me.LBLJam.Text = "LBLJam"
        '
        'LBLTanggalKbl
        '
        Me.LBLTanggalKbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggalKbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTanggalKbl.Location = New System.Drawing.Point(1029, 33)
        Me.LBLTanggalKbl.Name = "LBLTanggalKbl"
        Me.LBLTanggalKbl.Size = New System.Drawing.Size(242, 35)
        Me.LBLTanggalKbl.TabIndex = 84
        Me.LBLTanggalKbl.Text = "LBLTanggalKbl"
        '
        'Label13
        '
        Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(849, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(174, 34)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "Operator"
        '
        'Label14
        '
        Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(849, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(174, 30)
        Me.Label14.TabIndex = 82
        Me.Label14.Text = "Jam"
        '
        'Label15
        '
        Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(849, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(174, 32)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Tanggal Kembali"
        '
        'NamaBarang
        '
        Me.NamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NamaBarang.Location = New System.Drawing.Point(39, 175)
        Me.NamaBarang.Name = "NamaBarang"
        Me.NamaBarang.Size = New System.Drawing.Size(174, 32)
        Me.NamaBarang.TabIndex = 80
        Me.NamaBarang.Text = "Nama Barang"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(219, 143)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(198, 26)
        Me.TextBox1.TabIndex = 78
        Me.TextBox1.Text = "TEXTBOX1"
        '
        'KodeBarang
        '
        Me.KodeBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.KodeBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KodeBarang.Location = New System.Drawing.Point(39, 143)
        Me.KodeBarang.Name = "KodeBarang"
        Me.KodeBarang.Size = New System.Drawing.Size(174, 32)
        Me.KodeBarang.TabIndex = 77
        Me.KodeBarang.Text = "Kode Barang"
        '
        'LBLNamaAgt
        '
        Me.LBLNamaAgt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaAgt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNamaAgt.Location = New System.Drawing.Point(423, 69)
        Me.LBLNamaAgt.Name = "LBLNamaAgt"
        Me.LBLNamaAgt.Size = New System.Drawing.Size(378, 30)
        Me.LBLNamaAgt.TabIndex = 74
        Me.LBLNamaAgt.Text = "LBLNamaAgt"
        '
        'LBLNoKbl
        '
        Me.LBLNoKbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoKbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNoKbl.Location = New System.Drawing.Point(219, 35)
        Me.LBLNoKbl.Name = "LBLNoKbl"
        Me.LBLNoKbl.Size = New System.Drawing.Size(198, 32)
        Me.LBLNoKbl.TabIndex = 73
        Me.LBLNoKbl.Text = "LBLNoKbl"
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 32)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Kode Anggota"
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 32)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "No Kembali"
        '
        'LBLTelahPinjam
        '
        Me.LBLTelahPinjam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTelahPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTelahPinjam.Location = New System.Drawing.Point(603, 34)
        Me.LBLTelahPinjam.Name = "LBLTelahPinjam"
        Me.LBLTelahPinjam.Size = New System.Drawing.Size(198, 32)
        Me.LBLTelahPinjam.TabIndex = 101
        Me.LBLTelahPinjam.Text = "LBLTelahPinjam"
        '
        'Label9
        '
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(423, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(174, 32)
        Me.Label9.TabIndex = 100
        Me.Label9.Text = "Telah Pinjam"
        '
        'TXTKODEAGT
        '
        Me.TXTKODEAGT.Location = New System.Drawing.Point(220, 67)
        Me.TXTKODEAGT.Name = "TXTKODEAGT"
        Me.TXTKODEAGT.Size = New System.Drawing.Size(197, 26)
        Me.TXTKODEAGT.TabIndex = 102
        Me.TXTKODEAGT.Text = "TXTKODEAGT"
        '
        'LBLNamaBarang
        '
        Me.LBLNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaBarang.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNamaBarang.Location = New System.Drawing.Point(220, 175)
        Me.LBLNamaBarang.Name = "LBLNamaBarang"
        Me.LBLNamaBarang.Size = New System.Drawing.Size(727, 32)
        Me.LBLNamaBarang.TabIndex = 103
        Me.LBLNamaBarang.Text = "LBLNamaBarang"
        '
        'LBLNoPjm
        '
        Me.LBLNoPjm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoPjm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLNoPjm.Location = New System.Drawing.Point(220, 207)
        Me.LBLNoPjm.Name = "LBLNoPjm"
        Me.LBLNoPjm.Size = New System.Drawing.Size(140, 32)
        Me.LBLNoPjm.TabIndex = 105
        Me.LBLNoPjm.Text = "LBLNoPjm"
        '
        'NoPinjam
        '
        Me.NoPinjam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NoPinjam.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NoPinjam.Location = New System.Drawing.Point(39, 207)
        Me.NoPinjam.Name = "NoPinjam"
        Me.NoPinjam.Size = New System.Drawing.Size(174, 32)
        Me.NoPinjam.TabIndex = 104
        Me.NoPinjam.Text = "No Pinjam"
        '
        'LBLTglPjm
        '
        Me.LBLTglPjm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTglPjm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTglPjm.Location = New System.Drawing.Point(518, 207)
        Me.LBLTglPjm.Name = "LBLTglPjm"
        Me.LBLTglPjm.Size = New System.Drawing.Size(140, 32)
        Me.LBLTglPjm.TabIndex = 107
        Me.LBLTglPjm.Text = "LBLTglPjm"
        '
        'TanggalPjm
        '
        Me.TanggalPjm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.TanggalPjm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TanggalPjm.Location = New System.Drawing.Point(384, 207)
        Me.TanggalPjm.Name = "TanggalPjm"
        Me.TanggalPjm.Size = New System.Drawing.Size(128, 32)
        Me.TanggalPjm.TabIndex = 106
        Me.TanggalPjm.Text = "Tanggal Pjm"
        '
        'LBLLamaPjm
        '
        Me.LBLLamaPjm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLLamaPjm.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLLamaPjm.Location = New System.Drawing.Point(807, 207)
        Me.LBLLamaPjm.Name = "LBLLamaPjm"
        Me.LBLLamaPjm.Size = New System.Drawing.Size(140, 32)
        Me.LBLLamaPjm.TabIndex = 109
        Me.LBLLamaPjm.Text = "LBLLamaPjm"
        '
        'Label22
        '
        Me.Label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(673, 207)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(128, 32)
        Me.Label22.TabIndex = 108
        Me.Label22.Text = "LamaPjm"
        '
        'FormTransPengembalian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1317, 785)
        Me.Controls.Add(Me.LBLLamaPjm)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.LBLTglPjm)
        Me.Controls.Add(Me.TanggalPjm)
        Me.Controls.Add(Me.LBLNoPjm)
        Me.Controls.Add(Me.NoPinjam)
        Me.Controls.Add(Me.LBLNamaBarang)
        Me.Controls.Add(Me.TXTKODEAGT)
        Me.Controls.Add(Me.LBLTelahPinjam)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.LBLOperator)
        Me.Controls.Add(Me.LBLJam)
        Me.Controls.Add(Me.LBLTanggalKbl)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.NamaBarang)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.KodeBarang)
        Me.Controls.Add(Me.LBLNamaAgt)
        Me.Controls.Add(Me.LBLNoKbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormTransPengembalian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Pengembalian Barang"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents LBLTotal As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents LBLOperator As Label
    Friend WithEvents LBLJam As Label
    Friend WithEvents LBLTanggalKbl As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents NamaBarang As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents KodeBarang As Label
    Friend WithEvents LBLNamaAgt As Label
    Friend WithEvents LBLNoKbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LBLTelahPinjam As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TXTKODEAGT As TextBox
    Friend WithEvents LBLNamaBarang As Label
    Friend WithEvents LBLNoPjm As Label
    Friend WithEvents NoPinjam As Label
    Friend WithEvents LBLTglPjm As Label
    Friend WithEvents TanggalPjm As Label
    Friend WithEvents LBLLamaPjm As Label
    Friend WithEvents Label22 As Label
End Class
