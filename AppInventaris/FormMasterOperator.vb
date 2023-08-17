Imports System.Data.SqlClient
Public Class FormMasterOperator
    Sub KondisiAwal()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        Call Koneksi()
        Da = New SqlDataAdapter("select kodeoperator, namaoperator, leveloperator from tbl_operator", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_operator")
        DataGridView1.DataSource = (Ds.Tables("tbl_operator"))
        ComboBox1.Items.Clear()
        ComboBox1.Items.Add("ADMIN")
        ComboBox1.Items.Add("USER")
        TextBox2.PasswordChar = "*"

    End Sub
    Private Sub FormMasterOperator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim SimpanData As String = "insert into tbl_operator values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.Text & "')"
            Cmd = New SqlCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil disimpan")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim EditData As String = "update tbl_operator set namaoperator ='" & TextBox2.Text & "', passwordoperator='" & TextBox3.Text & "', leveloperator='" & ComboBox1.Text & "' where kodeoperator='" & TextBox1.Text & "'"
            Cmd = New SqlCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Data Berhasil diedit")
            Call KondisiAwal()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("Pastikan semua data terisi!")
        Else
            Call Koneksi()
            Dim HapusData As String = "delete tbl_operator where kodeoperator='" & TextBox1.Text & "'"
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
            Cmd = New SqlCommand("Select * From tbl_operator where kodeoperator ='" & TextBox1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox2.Text = Rd.Item("NamaOperator")
                TextBox3.Text = Rd.Item("PasswordOperator")
                ComboBox1.Text = Rd.Item("LevelOperator")
            Else
                MsgBox("Data Tidak Ada")
            End If

        End If
    End Sub

End Class