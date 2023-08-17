Public Class ExportDatabase
    Private Sub ExportDatabase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB_INVENTARISDataSet.TBL_BARANG' table. You can move, or remove it, as needed.
        Me.TBL_BARANGTableAdapter.Fill(Me.DB_INVENTARISDataSet.TBL_BARANG)

    End Sub

    Private Sub EXPORT_Click(sender As Object, e As EventArgs) Handles EXPORT.Click

    End Sub
End Class