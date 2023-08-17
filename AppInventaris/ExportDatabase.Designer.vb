<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExportDatabase
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EXPORT = New System.Windows.Forms.Button()
        Me.DB_INVENTARISDataSet = New AppInventaris.DB_INVENTARISDataSet()
        Me.TBLBARANGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TBL_BARANGTableAdapter = New AppInventaris.DB_INVENTARISDataSetTableAdapters.TBL_BARANGTableAdapter()
        Me.KodeInventarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NamaInventarisDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpesifikasiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JumlahDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UrlGambarDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB_INVENTARISDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TBLBARANGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KodeInventarisDataGridViewTextBoxColumn, Me.NamaInventarisDataGridViewTextBoxColumn, Me.SpesifikasiDataGridViewTextBoxColumn, Me.JumlahDataGridViewTextBoxColumn, Me.UrlGambarDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TBLBARANGBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(25, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(968, 525)
        Me.DataGridView1.TabIndex = 0
        '
        'EXPORT
        '
        Me.EXPORT.Location = New System.Drawing.Point(31, 602)
        Me.EXPORT.Name = "EXPORT"
        Me.EXPORT.Size = New System.Drawing.Size(147, 53)
        Me.EXPORT.TabIndex = 1
        Me.EXPORT.Text = "EXPORT"
        Me.EXPORT.UseVisualStyleBackColor = True
        '
        'DB_INVENTARISDataSet
        '
        Me.DB_INVENTARISDataSet.DataSetName = "DB_INVENTARISDataSet"
        Me.DB_INVENTARISDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TBLBARANGBindingSource
        '
        Me.TBLBARANGBindingSource.DataMember = "TBL_BARANG"
        Me.TBLBARANGBindingSource.DataSource = Me.DB_INVENTARISDataSet
        '
        'TBL_BARANGTableAdapter
        '
        Me.TBL_BARANGTableAdapter.ClearBeforeFill = True
        '
        'KodeInventarisDataGridViewTextBoxColumn
        '
        Me.KodeInventarisDataGridViewTextBoxColumn.DataPropertyName = "KodeInventaris"
        Me.KodeInventarisDataGridViewTextBoxColumn.HeaderText = "KodeInventaris"
        Me.KodeInventarisDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.KodeInventarisDataGridViewTextBoxColumn.Name = "KodeInventarisDataGridViewTextBoxColumn"
        Me.KodeInventarisDataGridViewTextBoxColumn.Width = 150
        '
        'NamaInventarisDataGridViewTextBoxColumn
        '
        Me.NamaInventarisDataGridViewTextBoxColumn.DataPropertyName = "NamaInventaris"
        Me.NamaInventarisDataGridViewTextBoxColumn.HeaderText = "NamaInventaris"
        Me.NamaInventarisDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NamaInventarisDataGridViewTextBoxColumn.Name = "NamaInventarisDataGridViewTextBoxColumn"
        Me.NamaInventarisDataGridViewTextBoxColumn.Width = 150
        '
        'SpesifikasiDataGridViewTextBoxColumn
        '
        Me.SpesifikasiDataGridViewTextBoxColumn.DataPropertyName = "Spesifikasi"
        Me.SpesifikasiDataGridViewTextBoxColumn.HeaderText = "Spesifikasi"
        Me.SpesifikasiDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SpesifikasiDataGridViewTextBoxColumn.Name = "SpesifikasiDataGridViewTextBoxColumn"
        Me.SpesifikasiDataGridViewTextBoxColumn.Width = 150
        '
        'JumlahDataGridViewTextBoxColumn
        '
        Me.JumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah"
        Me.JumlahDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.JumlahDataGridViewTextBoxColumn.Name = "JumlahDataGridViewTextBoxColumn"
        Me.JumlahDataGridViewTextBoxColumn.Width = 150
        '
        'UrlGambarDataGridViewTextBoxColumn
        '
        Me.UrlGambarDataGridViewTextBoxColumn.DataPropertyName = "UrlGambar"
        Me.UrlGambarDataGridViewTextBoxColumn.HeaderText = "UrlGambar"
        Me.UrlGambarDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.UrlGambarDataGridViewTextBoxColumn.Name = "UrlGambarDataGridViewTextBoxColumn"
        Me.UrlGambarDataGridViewTextBoxColumn.Width = 150
        '
        'ExportDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1030, 665)
        Me.Controls.Add(Me.EXPORT)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ExportDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ExportDatabase"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB_INVENTARISDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TBLBARANGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents EXPORT As Button
    Friend WithEvents DB_INVENTARISDataSet As DB_INVENTARISDataSet
    Friend WithEvents TBLBARANGBindingSource As BindingSource
    Friend WithEvents TBL_BARANGTableAdapter As DB_INVENTARISDataSetTableAdapters.TBL_BARANGTableAdapter
    Friend WithEvents KodeInventarisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NamaInventarisDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SpesifikasiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JumlahDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UrlGambarDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
