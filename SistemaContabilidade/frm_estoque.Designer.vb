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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estoque))
        Me.dgv_Produtos = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.lbl_cnpj = New System.Windows.Forms.Label()
        Me.btn_Adicionar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgv_Produtos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_Produtos
        '
        Me.dgv_Produtos.AllowUserToDeleteRows = False
        Me.dgv_Produtos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_Produtos.BackgroundColor = System.Drawing.Color.White
        Me.dgv_Produtos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Produtos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dgv_Produtos.Location = New System.Drawing.Point(58, 50)
        Me.dgv_Produtos.Name = "dgv_Produtos"
        Me.dgv_Produtos.ReadOnly = True
        Me.dgv_Produtos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgv_Produtos.Size = New System.Drawing.Size(816, 377)
        Me.dgv_Produtos.TabIndex = 0
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
        Me.btn_Adicionar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_Adicionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_Adicionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Adicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Adicionar.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Adicionar.Location = New System.Drawing.Point(746, 360)
        Me.btn_Adicionar.Name = "btn_Adicionar"
        Me.btn_Adicionar.Size = New System.Drawing.Size(117, 57)
        Me.btn_Adicionar.TabIndex = 3
        Me.btn_Adicionar.Text = "Adicionar Produto"
        Me.btn_Adicionar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CNPJ"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(651, 461)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(260, 28)
        Me.Panel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(58, 433)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 43)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Voltar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_estoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(923, 501)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_Adicionar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_cnpj)
        Me.Controls.Add(Me.dgv_Produtos)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_estoque"
        Me.Text = "Checagem De Estoque"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_Produtos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_Produtos As DataGridView
    Friend WithEvents lbl_cnpj As Label
    Friend WithEvents btn_Adicionar As Button
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewImageColumn
    Friend WithEvents Column7 As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
End Class
