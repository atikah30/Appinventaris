Imports System.Data.SqlClient
Public Class FormLogin

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Koneksi()
        Cmd = New SqlCommand("Select * from TBL_OPERATOR where KodeOperator='" & TextBox1.Text & "' and PasswordOperator='" & TextBox2.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call BukaKunci()
            FormMenuUtama.STLabel2.Text = Rd!KodeOperator
            FormMenuUtama.STLabel4.Text = Rd!NamaOperator
            FormMenuUtama.STLabel6.Text = Rd!LevelOperator
        Else
            MsgBox("Kode Operator atau Password Salah!")
        End If

    End Sub
    Sub BukaKunci()
        FormMenuUtama.LoginToolStripMenuItem.Enabled = False
        FormMenuUtama.LogoutToolStripMenuItem.Enabled = True
        FormMenuUtama.MasterToolStripMenuItem.Enabled = True
        FormMenuUtama.TransaksiToolStripMenuItem.Enabled = True
        FormMenuUtama.UtilityToolStripMenuItem1.Enabled = True
        FormMenuUtama.LaporanToolStripMenuItem.Enabled = True
        FormMenuUtama.DataToolStripMenuItem.Enabled = True
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
        TextBox1.Text = ""
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class