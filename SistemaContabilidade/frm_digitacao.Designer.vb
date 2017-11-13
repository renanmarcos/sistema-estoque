<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_digitacao
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
        Me.txt_debito = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_credito = New System.Windows.Forms.TextBox()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_quant = New System.Windows.Forms.TextBox()
        Me.txt_valor_unitario = New System.Windows.Forms.TextBox()
        Me.txt_valor_total = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_debito
        '
        Me.txt_debito.Location = New System.Drawing.Point(211, 58)
        Me.txt_debito.Name = "txt_debito"
        Me.txt_debito.Size = New System.Drawing.Size(326, 20)
        Me.txt_debito.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(164, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Débito:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Crédito:"
        '
        'txt_credito
        '
        Me.txt_credito.Location = New System.Drawing.Point(211, 84)
        Me.txt_credito.Name = "txt_credito"
        Me.txt_credito.Size = New System.Drawing.Size(326, 20)
        Me.txt_credito.TabIndex = 2
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(211, 146)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(326, 20)
        Me.txt_nome.TabIndex = 4
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(211, 172)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(326, 136)
        Me.txt_desc.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(164, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Nome"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(74, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Descrição da mercadoria"
        '
        'txt_quant
        '
        Me.txt_quant.Location = New System.Drawing.Point(227, 331)
        Me.txt_quant.Multiline = True
        Me.txt_quant.Name = "txt_quant"
        Me.txt_quant.Size = New System.Drawing.Size(77, 59)
        Me.txt_quant.TabIndex = 8
        '
        'txt_valor_unitario
        '
        Me.txt_valor_unitario.Location = New System.Drawing.Point(328, 331)
        Me.txt_valor_unitario.Multiline = True
        Me.txt_valor_unitario.Name = "txt_valor_unitario"
        Me.txt_valor_unitario.Size = New System.Drawing.Size(77, 59)
        Me.txt_valor_unitario.TabIndex = 9
        '
        'txt_valor_total
        '
        Me.txt_valor_total.Enabled = False
        Me.txt_valor_total.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_valor_total.Location = New System.Drawing.Point(429, 331)
        Me.txt_valor_total.Multiline = True
        Me.txt_valor_total.Name = "txt_valor_total"
        Me.txt_valor_total.Size = New System.Drawing.Size(77, 59)
        Me.txt_valor_total.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(233, 402)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Quantidade"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(340, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "V. Unitário"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(439, 402)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "V. Total"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(555, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 56)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "Cadastrar mercadoria"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_digitacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(744, 483)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_valor_total)
        Me.Controls.Add(Me.txt_valor_unitario)
        Me.Controls.Add(Me.txt_quant)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_credito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_debito)
        Me.Name = "frm_digitacao"
        Me.Text = "Tela de lançamento"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_debito As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_credito As TextBox
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_desc As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_quant As TextBox
    Friend WithEvents txt_valor_unitario As TextBox
    Friend WithEvents txt_valor_total As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
End Class
