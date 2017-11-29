<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_estoque2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_estoque2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_descricao = New System.Windows.Forms.RichTextBox()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_nome.Location = New System.Drawing.Point(12, 36)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(445, 32)
        Me.txt_nome.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Descricão"
        '
        'txt_descricao
        '
        Me.txt_descricao.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_descricao.Location = New System.Drawing.Point(12, 95)
        Me.txt_descricao.Name = "txt_descricao"
        Me.txt_descricao.Size = New System.Drawing.Size(445, 111)
        Me.txt_descricao.TabIndex = 4
        Me.txt_descricao.Text = ""
        '
        'cmb_categoria
        '
        Me.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Items.AddRange(New Object() {"Bebidas", "Comidas", "Eletrônicos", "Eletrodomésticos"})
        Me.cmb_categoria.Location = New System.Drawing.Point(40, 241)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(228, 33)
        Me.cmb_categoria.TabIndex = 47
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(36, 214)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(113, 24)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Categoria"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Button1.Location = New System.Drawing.Point(297, 228)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 57)
        Me.Button1.TabIndex = 49
        Me.Button1.Text = "Gravar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'frm_estoque2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(469, 298)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_categoria)
        Me.Controls.Add(Me.txt_descricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_estoque2"
        Me.Text = "Cadastrar Produtos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_descricao As RichTextBox
    Friend WithEvents cmb_categoria As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
