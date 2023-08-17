Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FormTransPengembalian
    Private Sub KondisiAwal()
        TXTKODEAGT.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        LBLNamaBarang.Text = ""
        TextBox2.Text = ""
        LBLTglPjm.Text = ""
        LBLLamaPjm.Text = ""
        LBLNoPjm.Text = ""
        LBLNamaAgt.Text = ""
        LBLTelahPinjam.Text = ""
    End Sub
    Private Sub KondisiAwal2()
        TextBox1.Text = ""
        TextBox2.Text = ""
        LBLNamaBarang.Text = ""
        TextBox2.Text = ""
        LBLTglPjm.Text = ""
        LBLLamaPjm.Text = ""
        LBLNoPjm.Text = ""
    End Sub
    Sub TampilGrid1()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Barang")
        DataGridView1.Columns.Add("Nomor", "Nomor Pinjam")
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah Pinjam")
        DataGridView1.Columns.Add("Tanggal", "Tanggal Pinjam")
        DataGridView1.Columns.Add("lama", "lama Pinjam")
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 75
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 75
        DataGridView1.Columns(5).Width = 50
    End Sub
    Sub TampilGrid2()
        DataGridView2.Columns.Clear()
        DataGridView2.Columns.Add("Kode", "Kode")
        DataGridView2.Columns.Add("Nama", "Nama Barang")
        DataGridView2.Columns.Add("Kode", "Kode")
        DataGridView2.Columns(0).Width = 75
        DataGridView2.Columns(1).Width = 300
        DataGridView2.Columns(2).Width = 100
        DataGridView2.ReadOnly = True
    End Sub
    Sub Otomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_KEMBALI where NoKembali in (select max(NoKembali) from TBL_KEMBALI)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "KBL" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoKbl.Text = UrutanKode
    End Sub
    Private Sub FormTransPengembalian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Koneksi()
        Call Otomatis()
        LBLTanggalKbl.Text = Today
    End Sub

    Private Sub FormTransPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call Koneksi()
        Call TampilGrid1()
        Call Otomatis()
        LBLOperator.Text = FormMenuUtama.STLabel4.Text
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub
    Sub Pinjaman()
        Call Koneksi()
        Da = New SqlDataAdapter("Select TBL_Barang.KodeInventaris, NamaInventaris, JumlahInventaris From TBL_Anggota, TBL_Peminjaman, TBL_Barang, TBL_DetailPinjam where TBL_Barang.KodeInventaris=tbl_detailpinjam.kodeinventaris and tbl_peminjaman.NoPinjam=TBL_DetailPinjam.NoPinjam and TBL_Anggota.kodeanggota = TBL_Peminjaman.kodeanggota and TBL_Anggota.kodeanggota = '" & TXTKODEAGT.Text & "' and TBL_DetailPinjam.JumlahInventaris>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        DataGridView2.ReadOnly = True
        DataGridView2.Columns(0).Width = 80
        DataGridView2.Columns(1).Width = 300
        DataGridView2.Columns(2).Width = 100
    End Sub
    Sub CariData()
        Call Koneksi()
        Cmd = New SqlCommand("Select * From TBL_Anggota where KodeAnggota='" & TXTKODEAGT.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNamaAgt.Text = Rd.Item("NamaAnggota")
            Call Koneksi()
            Cmd = New SqlCommand("Select KodeAnggota From TBL_Peminjaman where KodeAnggota = '" & TXTKODEAGT.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call Koneksi()
                Cmd = New SqlCommand("Select SUM(TotalPinjam) as Ketemu from TBL_Peminjaman where KodeAnggota= '" & TXTKODEAGT.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                LBLTelahPinjam.Text = Rd.Item(0)
                Call Pinjaman()
            End If
        End If
    End Sub

    Private Sub TXTKODEAGT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTKODEAGT.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariData()
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select distinct TBL_Barang.KodeInventaris, TBL_DetailPinjam.NoPinjam, NamaInventaris, JumlahInventaris, TglPinjam From TBL_Anggota, TBL_Peminjaman, TBL_Barang, TBL_DetailPinjam where TBL_Barang.KodeInventaris=TBL_DetailPinjam.KodeInventaris and TBL_Peminjaman.NoPinjam=TBL_DetailPinjam.NoPinjam and TBL_Anggota.KodeAnggota=TBL_Peminjaman.KodeAnggota and TBL_Anggota.KodeAnggota='" & TXTKODEAGT.Text & "' and TBL_DetailPinjam.KodeInventaris = '" & TextBox1.Text & "' and TBL_DetailPinjam.JumlahInventaris>0", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Barang Bukan yang Dipinjam")
            Else
                LBLNoPjm.Text = Rd.Item(1)
                LBLNamaBarang.Text = Rd.Item(2)
                LBLTglPjm.Text = Rd.Item(4)
                TextBox2.Text = Rd.Item(3)
                LBLLamaPjm.Text = DateDiff(DateInterval.Day, Rd.Item(4), Today())

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Rows.Add(New String() {TextBox1.Text, LBLNoPjm.Text, LBLNamaBarang.Text, TextBox2.Text, LBLTglPjm.Text, LBLLamaPjm.Text})
        Call HapusMaster()
        Call TotalKembali()
    End Sub
    Sub HapusMaster()
        TextBox1.Text = ""
        LBLNoPjm.Text = ""
        LBLNamaBarang.Text = ""
        LBLTglPjm.Text = ""
        TextBox2.Text = ""
        LBLLamaPjm.Text = ""
    End Sub
    Sub TotalKembali()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            subtot += Val(DataGridView1.Rows(I).Cells(3).Value)
            LBLTotal.Text = subtot
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TXTKODEAGT.Text = "" Then
            MsgBox("Transaksi tidak ada, silahkan lakukan transaksi terlebih dahulu")
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim BarangKembali As String = "insert into tbl_kembali values('" & LBLNoKbl.Text & "', '" & tglsql & "', '" & LBLTotal.Text & "', '" & TXTKODEAGT.Text & "','" & FormMenuUtama.STLabel4.Text & "')"
            Cmd = New SqlCommand(BarangKembali, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "Insert into tbl_detailkembali values('" & LBLNoKbl.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(3).Value & "')"
                Cmd = New SqlCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()

                'update barang
                Call Koneksi()
                Cmd = New SqlCommand("select * from tbl_barang where kodeinventaris ='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call Koneksi()
                Dim KurangiStok As String = "Update tbl_barang set jumlah='" & Rd.Item("jumlah") + DataGridView1.Rows(Baris).Cells(3).Value & "' where kodeinventaris='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New SqlCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()

                'update detail pinjam
                Call Koneksi()
                Cmd = New SqlCommand("select JumlahInventaris from TBL_DetailPinjam where KodeInventaris ='" & DataGridView1.Rows(Baris).Cells(0).Value & "' and NoPinjam='" & DataGridView1.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call Koneksi()
                    Dim updatedetailpinjam As String = "update TBL_DetailPinjam set JumlahInventaris ='" & Rd.Item(0) - DataGridView1.Rows(Baris).Cells(3).Value & "' where KodeInventaris = '" & DataGridView1.Rows(Baris).Cells(0).Value & "' and NoPinjam='" & DataGridView1.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New SqlCommand(updatedetailpinjam, Conn)
                    Cmd.ExecuteNonQuery()
                End If
                'update total pinjam
                Call Koneksi()
                Cmd = New SqlCommand("select TotalPinjam from TBL_Peminjaman where NoPinjam ='" & DataGridView1.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call Koneksi()
                    Dim sqleditpjm As String = "update TBL_Peminjaman set TotalPinjam ='" & Rd.Item(0) - DataGridView1.Rows(Baris).Cells(3).Value & "' where NoPinjam = '" & DataGridView1.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New SqlCommand(sqleditpjm, Conn)
                    Cmd.ExecuteNonQuery()
                End If

            Next
            Call KondisiAwal()
            Call Otomatis()
            DataGridView1.Columns.Clear()
            DataGridView2.Columns.Clear()
            MsgBox("Transaksi Telah Berhasil Disimpan")
            Call TampilGrid1()
        End If
    End Sub
End Class