Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class FormTransPeminjaman
    Sub KondisiAwal()
        Call NoOtomatis()
        Call MunculKodeAnggota()
        LBLOperator.Text = FormMenuUtama.STLabel4.Text
        LBLNama.Text = ""
        LBLAlamat.Text = ""
        LBLTelepon.Text = ""
        LBLOperator.Text = ""
        cbxNama.Text = ""
        Call BuatKolom()
    End Sub
    Private Sub FormTransPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        LBLTanggal.Text = Today

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LBLJam.Text = TimeOfDay
    End Sub

    Sub NoOtomatis()
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_PEMINJAMAN where NoPinjam in (select max(NoPinjam) from TBL_PEMINJAMAN)", Conn)
        Dim UrutanKode As String
        Dim Hitung As Long
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows Then
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + "001"
        Else
            Hitung = Microsoft.VisualBasic.Right(Rd.GetString(0), 9) + 1
            UrutanKode = "PJM" + Format(Now, "yyMMdd") + Microsoft.VisualBasic.Right("000" & Hitung, 3)
        End If
        LBLNoPinjam.Text = UrutanKode

    End Sub
    Sub MunculKodeAnggota()
        Call Koneksi()
        ComboBox1.Items.Clear()
        Cmd = New SqlCommand("select * from tbl_anggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            ComboBox1.Items.Add(Rd.Item(0))
        Loop
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Call Koneksi()
        Cmd = New SqlCommand("select * from tbl_anggota where kodeAnggota ='" & ComboBox1.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LBLNama.Text = Rd!NamaAnggota
            LBLAlamat.Text = Rd!AlamatAnggota
            LBLTelepon.Text = Rd!TelpAnggota
            Call CekPinjaman()
        End If
    End Sub

    Sub BuatKolom()
        DataGridView1.Columns.Clear()
        DataGridView1.Columns.Add("Kode", "Kode Barang")
        DataGridView1.Columns.Add("Barang", "Nama Barang")
        DataGridView1.Columns.Add("Jumlah", "Jumlah")
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * from tbl_barang where kodeinventaris='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Barang tidak ada")
            Else
                TextBox1.Text = Rd.Item("KodeInventaris")
                cbxNama.Text = Rd.Item("NamaInventaris")
                TextBox2.Enabled = True
                TextBox2.Text = "1"
            End If
        End If
    End Sub
    Sub RumusTotalBarang()
        Dim HitungItem As Integer = 0
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            HitungItem = HitungItem + DataGridView1.Rows(i).Cells(2).Value
            LBLTotalBarang.Text = HitungItem
        Next
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Val(LBLTelahPinjam.Text) + Val(LBLTotalBarang.Text) >= 5 Or Val(LBLTotalBarang.Text) + Val(TextBox2.Text) > 5 Then
            MsgBox("Barang yang dipinjam  melebihi jumlah maksimal")
        Else
            If cbxNama.Text = "" Or TextBox2.Text = "" Then
                MsgBox("Silahkan masukan Kode Barang dan Tekan ENTER!")
            Else
                DataGridView1.Rows.Add(New String() {TextBox1.Text, cbxNama.Text, TextBox2.Text})
                TextBox1.Text = ""
                cbxNama.Text = ""
                TextBox2.Text = ""
                Call RumusTotalBarang()
            End If
        End If

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If LBLNama.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan lakukan transaksi terlebih dahulu")
        Else
            Call Koneksi()
            Dim tglsql As String
            tglsql = Format(Today, "yyyy-MM-dd")
            Dim PinjamBarang As String = "insert into tbl_peminjaman values('" & LBLNoPinjam.Text & "', '" & tglsql & "', '" & LBLJam.Text & "','" & ComboBox1.Text & "', '" & LBLTotalBarang.Text & "','" & LBLTotalBarang.Text & "', '" & FormMenuUtama.STLabel4.Text & "')"
            Cmd = New SqlCommand(PinjamBarang, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To DataGridView1.Rows.Count - 2
                Call Koneksi()
                Dim SimpanDetail As String = "Insert into tbl_detailpinjam([NoPinjam],[KodeInventaris],[JumlahInventaris]) values('" & LBLNoPinjam.Text & "','" & DataGridView1.Rows(Baris).Cells(0).Value & "','" & DataGridView1.Rows(Baris).Cells(2).Value & "')"
                Cmd = New SqlCommand(SimpanDetail, Conn)
                Cmd.ExecuteNonQuery()
                Call Koneksi()
                Cmd = New SqlCommand("select * from tbl_barang where kodeinventaris ='" & DataGridView1.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call Koneksi()
                Dim KurangiStok As String = "Update tbl_barang set jumlah='" & Rd.Item("jumlah") - DataGridView1.Rows(Baris).Cells(2).Value & "' where kodeinventaris='" & DataGridView1.Rows(Baris).Cells(0).Value & "'"
                Cmd = New SqlCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()
            Next
            Call KondisiAwal()
            MsgBox("Transaksi Telah Berhasil Disimpan")

        End If
    End Sub

    Private Sub cbxNama_TextChanged(sender As Object, e As EventArgs) Handles cbxNama.TextUpdate
        Call Koneksi()
        Dim x As String = cbxNama.Text
        Dim totalrow As Integer = cbxNama.Items.Count
        For i As Integer = 1 To totalrow
            If x <> cbxNama.Items(totalrow - i) Then
                cbxNama.Items.RemoveAt(totalrow - i)
            End If
        Next


        Cmd = New SqlCommand("Select * from tbl_barang where NamaInventaris like '%" & x & "%'", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            If x <> Rd.Item("NamaInventaris") Then
                cbxNama.Items.Add(Rd.Item("NamaInventaris"))
            End If
        Loop
    End Sub

    Private Sub cbxNama_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxNama.SelectedValueChanged
        Rd.Close()
        Cmd = New SqlCommand("Select kodeinventaris from tbl_barang where NamaInventaris = '" & cbxNama.Text & "'", Conn)
        Rd = Cmd.ExecuteReader

        Do While Rd.Read
            TextBox1.Text = Rd("kodeinventaris")
            TextBox2.Text = "1"
        Loop
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Sub CekPinjaman()
        Call Koneksi()
        Da = New SqlDataAdapter("Select tbl_Barang.KodeInventaris,NamaInventaris,JumlahInventaris from TBL_Anggota, TBL_Peminjaman, TBL_Barang, TBL_Detailpinjam where TBL_Barang.KodeInventaris=TBL_DetailPinjam.KodeInventaris And TBL_Peminjaman.NoPinjam=TBL_DetailPinjam.NoPinjam And TBL_Anggota.KodeAnggota=TBL_Peminjaman.KodeAnggota And TBL_Anggota.KodeAnggota='" & ComboBox1.Text & "' AND TBL_DetailPinjam.jumlahInventaris>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        DataGridView2.DataSource = Ds.Tables("Detail")
        LBLTelahPinjam.Text = DataGridView2.Rows.Count - 1
        DataGridView2.ReadOnly = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Call KondisiAwal()
    End Sub
End Class