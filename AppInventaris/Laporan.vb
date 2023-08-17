Imports System.Data.SqlClient

Public Class Laporan
    Private Sub KondisiAwal()
        TXTKODEAGT.Text = ""
        LBLNamaAgt.Text = ""

    End Sub
    Private Sub KondisiAwal2()

    End Sub
    Sub TampilGrid1()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Barang")
        DataGridView1.Columns.Add("Nomor", "Nomor " + ComboBox1.SelectedItem)
        DataGridView1.Columns.Add("Nama", "Nama Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah " + ComboBox1.SelectedItem)
        DataGridView1.Columns.Add("Tanggal", "Tanggal " + ComboBox1.SelectedItem)
        DataGridView1.Columns.Add("lama", "lama Pinjam")
        DataGridView1.Columns(0).Width = 70
        DataGridView1.Columns(1).Width = 75
        DataGridView1.Columns(2).Width = 150
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(4).Width = 75
        DataGridView1.Columns(5).Width = 50
    End Sub
    Sub TampilGrid2()

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

    End Sub
    Private Sub FormTransPengembalian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Koneksi()
        Call Otomatis()

    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("Peminjaman")
        ComboBox1.Items.Add("Pengembalian")
        ComboBox1.SelectedItem = "Peminjaman"
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    End Sub
    Sub Pinjaman()
        Call Koneksi()
        Da = New SqlDataAdapter("Select TBL_Barang.KodeInventaris, NamaInventaris, JumlahInventaris From TBL_Anggota, TBL_Peminjaman, TBL_Barang, TBL_DetailPinjam where TBL_Barang.KodeInventaris=tbl_detailpinjam.kodeinventaris and tbl_peminjaman.NoPinjam=TBL_DetailPinjam.NoPinjam and TBL_Anggota.kodeanggota = TBL_Peminjaman.kodeanggota and TBL_Anggota.kodeanggota = '" & TXTKODEAGT.Text & "' and TBL_DetailPinjam.JumlahInventaris>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView1.DataSource = Ds.Tables("Detail")
        DataGridView1.ReadOnly = True
        DataGridView1.Columns(0).Width = 80
        DataGridView1.Columns(1).Width = 300
        DataGridView1.Columns(2).Width = 100
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
                Call Pinjaman()
            End If
        End If
    End Sub

    Private Sub TXTKODEAGT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTKODEAGT.KeyPress
        If e.KeyChar = Chr(13) Then
            Call CariData()
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Barang Bukan yang Dipinjam")
            Else

            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Call HapusMaster()
        Call TotalKembali()
    End Sub
    Sub HapusMaster()
    End Sub
    Sub TotalKembali()
        Dim subtot As Integer = 0
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            subtot += Val(DataGridView1.Rows(I).Cells(3).Value)
        Next
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If TXTKODEAGT.Text = "" Then
            MsgBox("Transaksi tidak ada, silahkan lakukan transaksi terlebih dahulu")
        Else
            Call Koneksi()

            Call TampilGrid1()
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label4.Text = "Tanggal " + ComboBox1.SelectedItem
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Da = New SqlDataAdapter("test1", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView1.DataSource = Ds.Tables("Detail")

        TampilGrid1()

    End Sub
End Class