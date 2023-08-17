Imports System.Data.SqlClient

Public Class FormMasterBarang
    Sub KondisiAwal()
        ComboBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        Label10.Text = ""
        Button1.Text = "INPUT"
        Button2.Text = "EDIT"
        Button3.Text = "HAPUS"
        Button4.Text = "TUTUP"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        TextBox1.Enabled = False
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tbl_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_barang")
        DataGridView1.DataSource = (Ds.Tables("tbl_barang"))

        'ComboBox1.Items.Clear()
        'Cmd = New SqlCommand("select * from TBL_Kode where Type='Barang'", Conn)
        'Rd = Cmd.ExecuteReader
        'Do While Rd.Read
        '    ComboBox1.Items.Add(Rd.Item(0))
        'Loop
    End Sub
    'Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
    '    Call Koneksi()
    '    Dim LastId As String
    '    Format(LastId, "00000")
    '    Dim UpdateData As String = "Update TBL_Kode set LastId=LastId+1  where Type='Barang' and Kode='" & ComboBox1.Text & "'"
    '    Cmd = New SqlCommand(UpdateData, Conn)
    '    Cmd.ExecuteNonQuery()
    '    Cmd = New SqlCommand("select * from TBL_Kode where Type='Barang' and Kode='" & ComboBox1.Text & "'", Conn)
    '    Rd = Cmd.ExecuteReader
    '    Rd.Read()
    'End Sub
    Private Sub FormMasterBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        BukaFile.Filter = "*.jpg|"
        BukaFile.ShowDialog()
        Label10.Text = BukaFile.FileName
        PictureBox1.ImageLocation = Label10.Text
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or Label10.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim SimpanData As String = "insert into tbl_barang values('" & ComboBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "','" & Label10.Text & "')"
            Cmd = New SqlCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan")
            Call KondisiAwal()
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or Label10.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim EditData As String = "update tbl_barang set namainventaris='" & TextBox2.Text & "', spesifikasi='" & TextBox3.Text & "', jumlah ='" & TextBox4.Text & "', urlgambar ='" & Label10.Text & "' where kodeinventaris='" & ComboBox1.Text & "'"
            Cmd = New SqlCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil diedit")
            Call KondisiAwal()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComboBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or TextBox4.Text = "" Or Label10.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim HapusData As String = "delete tbl_barang where kodeinventaris='" & ComboBox1.Text & "'"
            Cmd = New SqlCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil dihapus")
            Call KondisiAwal()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub ComboBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ComboBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * From tbl_barang where kodeinventaris ='" & ComboBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("Namainventaris")
                TextBox3.Text = Rd.Item("Spesifikasi")
                TextBox4.Text = Rd.Item("Jumlah")
                Label10.Text = Rd.Item("UrlGambar")
                PictureBox1.ImageLocation = Label10.Text
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub
End Class