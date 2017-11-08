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
        Me.dtp_inicio = New System.Windows.Forms.DateTimePicker()
        Me.dtp_final = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_gerar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_metodo = New System.Windows.Forms.ComboBox()
        Me.lst_produtos = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cb_inicio = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtp_inicio
        '
        Me.dtp_inicio.Location = New System.Drawing.Point(11, 44)
        Me.dtp_inicio.Name = "dtp_inicio"
        Me.dtp_inicio.Size = New System.Drawing.Size(227, 20)
        Me.dtp_inicio.TabIndex = 0
        '
        'dtp_final
        '
        Me.dtp_final.Location = New System.Drawing.Point(11, 93)
        Me.dtp_final.Name = "dtp_final"
        Me.dtp_final.Size = New System.Drawing.Size(227, 20)
        Me.dtp_final.TabIndex = 2
        Me.dtp_final.Value = New Date(2017, 12, 6, 15, 26, 0, 0)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Do dia:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Até:"
        '
        'btn_gerar
        '
        Me.btn_gerar.Location = New System.Drawing.Point(206, 251)
        Me.btn_gerar.Name = "btn_gerar"
        Me.btn_gerar.Size = New System.Drawing.Size(248, 46)
        Me.btn_gerar.TabIndex = 5
        Me.btn_gerar.Text = "Gerar relatório"
        Me.btn_gerar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_inicio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.dtp_inicio)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dtp_final)
        Me.GroupBox1.Location = New System.Drawing.Point(206, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 160)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Período"
        '
        'cmb_metodo
        '
        Me.cmb_metodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_metodo.FormattingEnabled = True
        Me.cmb_metodo.Items.AddRange(New Object() {"PEPS", "UPES", "Média Ponderada"})
        Me.cmb_metodo.Location = New System.Drawing.Point(11, 26)
        Me.cmb_metodo.Name = "cmb_metodo"
        Me.cmb_metodo.Size = New System.Drawing.Size(227, 21)
        Me.cmb_metodo.TabIndex = 5
        '
        'lst_produtos
        '
        Me.lst_produtos.FormattingEnabled = True
        Me.lst_produtos.Location = New System.Drawing.Point(6, 19)
        Me.lst_produtos.Name = "lst_produtos"
        Me.lst_produtos.Size = New System.Drawing.Size(171, 199)
        Me.lst_produtos.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lst_produtos)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 233)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selecione um produto da lista"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmb_metodo)
        Me.GroupBox3.Location = New System.Drawing.Point(206, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(248, 67)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Método"
        '
        'cb_inicio
        '
        Me.cb_inicio.AutoSize = True
        Me.cb_inicio.Location = New System.Drawing.Point(11, 132)
        Me.cb_inicio.Name = "cb_inicio"
        Me.cb_inicio.Size = New System.Drawing.Size(93, 17)
        Me.cb_inicio.TabIndex = 5
        Me.cb_inicio.Text = "Desde o inicio"
        Me.cb_inicio.UseVisualStyleBackColor = True
        '
        'frm_relatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 317)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_gerar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_relatorio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório de Estoque"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtp_inicio As DateTimePicker
    Friend WithEvents dtp_final As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_gerar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_metodo As ComboBox
    Friend WithEvents lst_produtos As ListBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cb_inicio As CheckBox
End Class
