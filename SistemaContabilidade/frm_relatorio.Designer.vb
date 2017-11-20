<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_relatorio
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
        Me.btn_gerar = New System.Windows.Forms.Button()
        Me.cmb_metodo = New System.Windows.Forms.ComboBox()
        Me.lst_produtos = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_gerar
        '
        Me.btn_gerar.Location = New System.Drawing.Point(12, 324)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(251, 51)
        Me.btn_gerar.TabIndex = 5
        Me.btn_gerar.Text = "Gerar relatório"
        Me.btn_gerar.UseVisualStyleBackColor = True
        '
        'cmb_metodo
        '
        Me.cmb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_metodo.FormattingEnabled = True
        Me.cmb_metodo.Items.AddRange(New Object() {"PEPS", "UPES", "Média Ponderada"})
        Me.cmb_metodo.Location = New System.Drawing.Point(11, 26)
        Me.cmb_metodo.Name = "cmb_metodo"
        Me.cmb_metodo.Size = New System.Drawing.Size(226, 21)
        Me.cmb_metodo.TabIndex = 5
        '
        'lst_produtos
        '
        Me.lst_produtos.FormattingEnabled = True
        Me.lst_produtos.Location = New System.Drawing.Point(6, 19)
        Me.lst_produtos.Name = "lst_produtos"
        Me.lst_produtos.Size = New System.Drawing.Size(239, 199)
        Me.lst_produtos.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lst_produtos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(251, 233)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selecione um produto da lista"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_metodo)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 251)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(251, 67)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Método"
        '
        'frm_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 387)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_gerar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Estoque"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_gerar As Button
    Friend WithEvents cmb_metodo As ComboBox
    Friend WithEvents lst_produtos As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class
