<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_planoContas
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
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1.1.1 Banco Itaú")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1.1.2 Banco Bradesco")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1.1 Bancos c/ movimento", New System.Windows.Forms.TreeNode() {TreeNode13, TreeNode14})
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1.2.1 Sapatos de salto alto")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1.2 Estoque de mercadorias", New System.Windows.Forms.TreeNode() {TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("1. Ativo", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode17})
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.1 Banco Itaú")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1.2 Banco Bradesco")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.1 Bancos c/ movimento", New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode20})
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2.1 Sapatos de salto alto")
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2.2 Estoque de mercadorias", New System.Windows.Forms.TreeNode() {TreeNode22})
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("2. Passivo", New System.Windows.Forms.TreeNode() {TreeNode21, TreeNode23})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.tab_cadastro = New System.Windows.Forms.TabControl()
        Me.tab_ativo = New System.Windows.Forms.TabPage()
        Me.cmb_tipo_passivo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cadastrar_ativo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_vtotal_ativo = New System.Windows.Forms.TextBox()
        Me.txt_vunit_ativo = New System.Windows.Forms.TextBox()
        Me.txt_qtd_ativo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_desc_ativo = New System.Windows.Forms.TextBox()
        Me.txt_nome_ativo = New System.Windows.Forms.TextBox()
        Me.tab_passivo = New System.Windows.Forms.TabPage()
        Me.cmb_tipo_ativo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_desc_passivo = New System.Windows.Forms.TextBox()
        Me.txt_nome_passivo = New System.Windows.Forms.TextBox()
        Me.tab_cadastro.SuspendLayout()
        Me.tab_ativo.SuspendLayout()
        Me.tab_passivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode13.Name = "Nó3"
        TreeNode13.Text = "1.1.1 Banco Itaú"
        TreeNode14.Name = "Nó5"
        TreeNode14.Text = "1.1.2 Banco Bradesco"
        TreeNode15.Name = "Nó1"
        TreeNode15.Text = "1.1 Bancos c/ movimento"
        TreeNode16.Name = "Nó7"
        TreeNode16.Text = "1.2.1 Sapatos de salto alto"
        TreeNode17.Name = "Nó6"
        TreeNode17.Text = "1.2 Estoque de mercadorias"
        TreeNode18.Name = "ativo"
        TreeNode18.Text = "1. Ativo"
        TreeNode19.Name = "Nó8"
        TreeNode19.Text = "2.1.1 Banco Itaú"
        TreeNode20.Name = "Nó9"
        TreeNode20.Text = "2.1.2 Banco Bradesco"
        TreeNode21.Name = "Nó2"
        TreeNode21.Text = "2.1 Bancos c/ movimento"
        TreeNode22.Name = "Nó11"
        TreeNode22.Text = "2.2.1 Sapatos de salto alto"
        TreeNode23.Name = "Nó10"
        TreeNode23.Text = "2.2 Estoque de mercadorias"
        TreeNode24.Name = "passivo"
        TreeNode24.Text = "2. Passivo"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode24})
        Me.TreeView1.Size = New System.Drawing.Size(247, 457)
        Me.TreeView1.TabIndex = 0
        '
        'tab_cadastro
        '
        Me.tab_cadastro.Controls.Add(Me.tab_ativo)
        Me.tab_cadastro.Controls.Add(Me.tab_passivo)
        Me.tab_cadastro.Location = New System.Drawing.Point(265, 12)
        Me.tab_cadastro.Name = "tab_cadastro"
        Me.tab_cadastro.SelectedIndex = 0
        Me.tab_cadastro.Size = New System.Drawing.Size(632, 457)
        Me.tab_cadastro.TabIndex = 1
        '
        'tab_ativo
        '
        Me.tab_ativo.Controls.Add(Me.cmb_tipo_passivo)
        Me.tab_ativo.Controls.Add(Me.Label1)
        Me.tab_ativo.Controls.Add(Me.btn_cadastrar_ativo)
        Me.tab_ativo.Controls.Add(Me.Label7)
        Me.tab_ativo.Controls.Add(Me.Label6)
        Me.tab_ativo.Controls.Add(Me.Label5)
        Me.tab_ativo.Controls.Add(Me.txt_vtotal_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_vunit_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_qtd_ativo)
        Me.tab_ativo.Controls.Add(Me.Label4)
        Me.tab_ativo.Controls.Add(Me.Label3)
        Me.tab_ativo.Controls.Add(Me.txt_desc_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_nome_ativo)
        Me.tab_ativo.Location = New System.Drawing.Point(4, 22)
        Me.tab_ativo.Name = "tab_ativo"
        Me.tab_ativo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ativo.Size = New System.Drawing.Size(624, 431)
        Me.tab_ativo.TabIndex = 0
        Me.tab_ativo.Text = "ATIVO"
        Me.tab_ativo.UseVisualStyleBackColor = True
        '
        'cmb_tipo_passivo
        '
        Me.cmb_tipo_passivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_passivo.FormattingEnabled = True
        Me.cmb_tipo_passivo.Items.AddRange(New Object() {"Compra", "Venda"})
        Me.cmb_tipo_passivo.Location = New System.Drawing.Point(449, 95)
        Me.cmb_tipo_passivo.Name = "cmb_tipo_passivo"
        Me.cmb_tipo_passivo.Size = New System.Drawing.Size(138, 21)
        Me.cmb_tipo_passivo.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ATIVO"
        '
        'btn_cadastrar_ativo
        '
        Me.btn_cadastrar_ativo.Location = New System.Drawing.Point(461, 284)
        Me.btn_cadastrar_ativo.Name = "btn_cadastrar_ativo"
        Me.btn_cadastrar_ativo.Size = New System.Drawing.Size(98, 56)
        Me.btn_cadastrar_ativo.TabIndex = 39
        Me.btn_cadastrar_ativo.Text = "Cadastrar mercadoria"
        Me.btn_cadastrar_ativo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(345, 352)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "V. Total"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "V. Unitário"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Quantidade"
        '
        'txt_vtotal_ativo
        '
        Me.txt_vtotal_ativo.Enabled = False
        Me.txt_vtotal_ativo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_vtotal_ativo.Location = New System.Drawing.Point(335, 281)
        Me.txt_vtotal_ativo.Multiline = True
        Me.txt_vtotal_ativo.Name = "txt_vtotal_ativo"
        Me.txt_vtotal_ativo.Size = New System.Drawing.Size(77, 59)
        Me.txt_vtotal_ativo.TabIndex = 35
        '
        'txt_vunit_ativo
        '
        Me.txt_vunit_ativo.Location = New System.Drawing.Point(234, 281)
        Me.txt_vunit_ativo.Multiline = True
        Me.txt_vunit_ativo.Name = "txt_vunit_ativo"
        Me.txt_vunit_ativo.Size = New System.Drawing.Size(77, 59)
        Me.txt_vunit_ativo.TabIndex = 34
        '
        'txt_qtd_ativo
        '
        Me.txt_qtd_ativo.Location = New System.Drawing.Point(133, 281)
        Me.txt_qtd_ativo.Multiline = True
        Me.txt_qtd_ativo.Name = "txt_qtd_ativo"
        Me.txt_qtd_ativo.Size = New System.Drawing.Size(77, 59)
        Me.txt_qtd_ativo.TabIndex = 33
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 26)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Descrição " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "da mercadoria"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(70, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nome"
        '
        'txt_desc_ativo
        '
        Me.txt_desc_ativo.Location = New System.Drawing.Point(117, 122)
        Me.txt_desc_ativo.Multiline = True
        Me.txt_desc_ativo.Name = "txt_desc_ativo"
        Me.txt_desc_ativo.Size = New System.Drawing.Size(326, 136)
        Me.txt_desc_ativo.TabIndex = 30
        '
        'txt_nome_ativo
        '
        Me.txt_nome_ativo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nome_ativo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nome_ativo.Location = New System.Drawing.Point(117, 96)
        Me.txt_nome_ativo.Name = "txt_nome_ativo"
        Me.txt_nome_ativo.Size = New System.Drawing.Size(326, 20)
        Me.txt_nome_ativo.TabIndex = 29
        '
        'tab_passivo
        '
        Me.tab_passivo.Controls.Add(Me.cmb_tipo_ativo)
        Me.tab_passivo.Controls.Add(Me.Label2)
        Me.tab_passivo.Controls.Add(Me.Button2)
        Me.tab_passivo.Controls.Add(Me.Label8)
        Me.tab_passivo.Controls.Add(Me.Label9)
        Me.tab_passivo.Controls.Add(Me.Label10)
        Me.tab_passivo.Controls.Add(Me.TextBox1)
        Me.tab_passivo.Controls.Add(Me.TextBox2)
        Me.tab_passivo.Controls.Add(Me.TextBox8)
        Me.tab_passivo.Controls.Add(Me.Label11)
        Me.tab_passivo.Controls.Add(Me.Label12)
        Me.tab_passivo.Controls.Add(Me.txt_desc_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_nome_passivo)
        Me.tab_passivo.Location = New System.Drawing.Point(4, 22)
        Me.tab_passivo.Name = "tab_passivo"
        Me.tab_passivo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_passivo.Size = New System.Drawing.Size(624, 431)
        Me.tab_passivo.TabIndex = 1
        Me.tab_passivo.Text = "PASSIVO"
        Me.tab_passivo.UseVisualStyleBackColor = True
        '
        'cmb_tipo_ativo
        '
        Me.cmb_tipo_ativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_ativo.FormattingEnabled = True
        Me.cmb_tipo_ativo.Items.AddRange(New Object() {"Compra", "Venda"})
        Me.cmb_tipo_ativo.Location = New System.Drawing.Point(449, 95)
        Me.cmb_tipo_ativo.Name = "cmb_tipo_ativo"
        Me.cmb_tipo_ativo.Size = New System.Drawing.Size(138, 21)
        Me.cmb_tipo_ativo.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "PASSIVO"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(461, 284)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 56)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Cadastrar mercadoria"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(345, 352)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "V. Total"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(246, 352)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "V. Unitário"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(139, 352)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 13)
        Me.Label10.TabIndex = 36
        Me.Label10.Text = "Quantidade"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TextBox1.Location = New System.Drawing.Point(335, 281)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(77, 59)
        Me.TextBox1.TabIndex = 35
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(234, 281)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(77, 59)
        Me.TextBox2.TabIndex = 34
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(133, 281)
        Me.TextBox8.Multiline = True
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(77, 59)
        Me.TextBox8.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(37, 125)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(74, 26)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Descrição " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "da mercadoria"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(70, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Nome"
        '
        'txt_desc_passivo
        '
        Me.txt_desc_passivo.Location = New System.Drawing.Point(117, 122)
        Me.txt_desc_passivo.Multiline = True
        Me.txt_desc_passivo.Name = "txt_desc_passivo"
        Me.txt_desc_passivo.Size = New System.Drawing.Size(326, 136)
        Me.txt_desc_passivo.TabIndex = 30
        '
        'txt_nome_passivo
        '
        Me.txt_nome_passivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nome_passivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nome_passivo.Location = New System.Drawing.Point(117, 96)
        Me.txt_nome_passivo.Name = "txt_nome_passivo"
        Me.txt_nome_passivo.Size = New System.Drawing.Size(326, 20)
        Me.txt_nome_passivo.TabIndex = 29
        '
        'frm_planoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 481)
        Me.Controls.Add(Me.tab_cadastro)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frm_planoContas"
        Me.Text = "frm_planoContas"
        Me.tab_cadastro.ResumeLayout(False)
        Me.tab_ativo.ResumeLayout(False)
        Me.tab_ativo.PerformLayout()
        Me.tab_passivo.ResumeLayout(False)
        Me.tab_passivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents tab_cadastro As TabControl
    Friend WithEvents tab_ativo As TabPage
    Friend WithEvents tab_passivo As TabPage
    Friend WithEvents cmb_tipo_passivo As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cadastrar_ativo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_vtotal_ativo As TextBox
    Friend WithEvents txt_vunit_ativo As TextBox
    Friend WithEvents txt_qtd_ativo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_desc_ativo As TextBox
    Friend WithEvents txt_nome_ativo As TextBox
    Friend WithEvents cmb_tipo_ativo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_desc_passivo As TextBox
    Friend WithEvents txt_nome_passivo As TextBox
End Class
