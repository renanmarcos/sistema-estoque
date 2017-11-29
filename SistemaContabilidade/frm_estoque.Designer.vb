<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estoque
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgv_Produtos = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_cnpj = New System.Windows.Forms.Label()
        Me.btn_Adicionar = New System.Windows.Forms.Button()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgv_Produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_Produtos
        '
        Me.dgv_Produtos.AllowUserToDeleteRows = False
        Me.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_Produtos.Location = New System.Drawing.Point(23, 52)
        Me.dgv_Produtos.Name = "dgv_Produtos"
        Me.dgv_Produtos.ReadOnly = True
        Me.dgv_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Produtos.Size = New System.Drawing.Size(749, 312)
        Me.dgv_Produtos.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CNPJ:"
        '
        'lbl_cnpj
        '
        Me.lbl_cnpj.AutoSize = True
        Me.lbl_cnpj.Location = New System.Drawing.Point(115, 19)
        Me.lbl_cnpj.Name = "lbl_cnpj"
        Me.lbl_cnpj.Size = New System.Drawing.Size(0, 13)
        Me.lbl_cnpj.TabIndex = 2
        '
        'btn_Adicionar
        '
        Me.btn_Adicionar.Location = New System.Drawing.Point(323, 14)
        Me.btn_Adicionar.Name = "btn_Adicionar"
        Me.btn_Adicionar.Size = New System.Drawing.Size(136, 23)
        Me.btn_Adicionar.TabIndex = 3
        Me.btn_Adicionar.Text = "Adicionar Produto"
        Me.btn_Adicionar.UseVisualStyleBackColor = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nome"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Descricao"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Categoria"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Editar"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Excluir"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'frm_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 394)
        Me.Controls.Add(Me.btn_Adicionar)
        Me.Controls.Add(Me.lbl_cnpj)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgv_Produtos)
        Me.Name = "frm_estoque"
        Me.Text = "."
        CType(Me.dgv_Produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Produtos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_cnpj As Label
    Friend WithEvents btn_Adicionar As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
End Class
