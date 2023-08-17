Imports System.Data.SqlClient
Public Class FormMasterAnggota
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        Call Koneksi()
        Da = New SqlDataAdapter("select * from tbl_anggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_anggota")
        DataGridView1.DataSource = (Ds.Tables("tbl_anggota"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("LAKI-LAKI")
        ComboBox1.Items.Add("PEREMPUAN")
    End Sub

    Private Sub FormMasterAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim SimpanData As String = "insert into tbl_anggota values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "','" & TextBox4.Text & "','" & TextBox5.Text & "')"
            Cmd = New SqlCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim EditData As String = "update tbl_anggota set namaanggota ='" & TextBox2.Text & "', nimanggota='" & TextBox3.Text & "', jeniskelamin='" & ComboBox1.Text & "', alamatanggota='" & TextBox4.Text & "', telpanggota='" & TextBox5.Text & "' where kodeanggota='" & TextBox1.Text & "'"
            Cmd = New SqlCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil diedit")
            Call KondisiAwal()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Or TextBox4.Text = "" Or TextBox5.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim HapusData As String = "delete tbl_anggota where kodeanggota='" & TextBox1.Text & "'"
            Cmd = New SqlCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil dihapus")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New SqlCommand("Select * From tbl_anggota where kodeanggota ='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("Namaanggota")
                TextBox3.Text = Rd.Item("Nimanggota")
                ComboBox1.Text = Rd.Item("Jeniskelamin")
                TextBox4.Text = Rd.Item("Alamatanggota")
                TextBox5.Text = Rd.Item("Telpanggota")
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub


End Class