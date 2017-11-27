<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_planoContas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_planoContas))
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.tab_cadastro = New System.Windows.Forms.TabControl()
        Me.tab_ativo = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_vtotal_ativo = New System.Windows.Forms.Label()
        Me.lbl_vunit_ativo = New System.Windows.Forms.Label()
        Me.cmb_categoria_ativo = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_ativo = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_ativo = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cadastrar_ativo = New System.Windows.Forms.Button()
        Me.txt_vtotal_ativo = New System.Windows.Forms.TextBox()
        Me.txt_vunit_ativo = New System.Windows.Forms.TextBox()
        Me.txt_qtd_ativo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_desc_ativo = New System.Windows.Forms.TextBox()
        Me.txt_nome_ativo = New System.Windows.Forms.TextBox()
        Me.tab_passivo = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmb_categoria_passivo = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo_passivo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_cadastrar_passivo = New System.Windows.Forms.Button()
        Me.txt_vtotal_passivo = New System.Windows.Forms.TextBox()
        Me.txt_vunit_passivo = New System.Windows.Forms.TextBox()
        Me.txt_qtd_passivo = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_desc_passivo = New System.Windows.Forms.TextBox()
        Me.txt_nome_passivo = New System.Windows.Forms.TextBox()
        Me.lbl_vunit_passivo = New System.Windows.Forms.Label()
        Me.lbl_vtotal_passivo = New System.Windows.Forms.Label()
        Me.tab_cadastro.SuspendLayout()
        Me.tab_ativo.SuspendLayout()
        Me.tab_passivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.White
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TreeView1.Font = New System.Drawing.Font("Bernard MT Condensed", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreeView1.Location = New System.Drawing.Point(12, 34)
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
        Me.TreeView1.Size = New System.Drawing.Size(236, 431)
        Me.TreeView1.TabIndex = 0
        '
        'tab_cadastro
        '
        Me.tab_cadastro.Controls.Add(Me.tab_ativo)
        Me.tab_cadastro.Controls.Add(Me.tab_passivo)
        Me.tab_cadastro.Font = New System.Drawing.Font("Cooper Black", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tab_cadastro.Location = New System.Drawing.Point(265, 12)
        Me.tab_cadastro.Name = "tab_cadastro"
        Me.tab_cadastro.SelectedIndex = 0
        Me.tab_cadastro.Size = New System.Drawing.Size(632, 457)
        Me.tab_cadastro.TabIndex = 1
        '
        'tab_ativo
        '
        Me.tab_ativo.BackColor = System.Drawing.Color.White
        Me.tab_ativo.Controls.Add(Me.Label6)
        Me.tab_ativo.Controls.Add(Me.lbl_vtotal_ativo)
        Me.tab_ativo.Controls.Add(Me.lbl_vunit_ativo)
        Me.tab_ativo.Controls.Add(Me.cmb_categoria_ativo)
        Me.tab_ativo.Controls.Add(Me.cmb_tipo_ativo)
        Me.tab_ativo.Controls.Add(Me.lbl_tipo_ativo)
        Me.tab_ativo.Controls.Add(Me.Label4)
        Me.tab_ativo.Controls.Add(Me.Label1)
        Me.tab_ativo.Controls.Add(Me.btn_cadastrar_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_vtotal_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_vunit_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_qtd_ativo)
        Me.tab_ativo.Controls.Add(Me.Label3)
        Me.tab_ativo.Controls.Add(Me.txt_desc_ativo)
        Me.tab_ativo.Controls.Add(Me.txt_nome_ativo)
        Me.tab_ativo.Location = New System.Drawing.Point(4, 26)
        Me.tab_ativo.Name = "tab_ativo"
        Me.tab_ativo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ativo.Size = New System.Drawing.Size(624, 427)
        Me.tab_ativo.TabIndex = 0
        Me.tab_ativo.Text = "ATIVO"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(44, 357)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 46)
        Me.Label6.TabIndex = 56
        Me.Label6.Text = "Quan - tidade"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_vtotal_ativo
        '
        Me.lbl_vtotal_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vtotal_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vtotal_ativo.Location = New System.Drawing.Point(260, 357)
        Me.lbl_vtotal_ativo.Name = "lbl_vtotal_ativo"
        Me.lbl_vtotal_ativo.Size = New System.Drawing.Size(77, 46)
        Me.lbl_vtotal_ativo.TabIndex = 58
        Me.lbl_vtotal_ativo.Text = "Valor Total"
        Me.lbl_vtotal_ativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_vunit_ativo
        '
        Me.lbl_vunit_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vunit_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vunit_ativo.Location = New System.Drawing.Point(141, 357)
        Me.lbl_vunit_ativo.Name = "lbl_vunit_ativo"
        Me.lbl_vunit_ativo.Size = New System.Drawing.Size(101, 46)
        Me.lbl_vunit_ativo.TabIndex = 57
        Me.lbl_vunit_ativo.Text = "Valor Unitário"
        Me.lbl_vunit_ativo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_categoria_ativo
        '
        Me.cmb_categoria_ativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria_ativo.FormattingEnabled = True
        Me.cmb_categoria_ativo.Items.AddRange(New Object() {"Bebidas", "Comidas", "Eletrônicos", "Eletrodomésticos"})
        Me.cmb_categoria_ativo.Location = New System.Drawing.Point(358, 318)
        Me.cmb_categoria_ativo.Name = "cmb_categoria_ativo"
        Me.cmb_categoria_ativo.Size = New System.Drawing.Size(212, 25)
        Me.cmb_categoria_ativo.TabIndex = 46
        '
        'cmb_tipo_ativo
        '
        Me.cmb_tipo_ativo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_ativo.FormattingEnabled = True
        Me.cmb_tipo_ativo.Items.AddRange(New Object() {"Compra", "Venda"})
        Me.cmb_tipo_ativo.Location = New System.Drawing.Point(451, 102)
        Me.cmb_tipo_ativo.Name = "cmb_tipo_ativo"
        Me.cmb_tipo_ativo.Size = New System.Drawing.Size(138, 25)
        Me.cmb_tipo_ativo.TabIndex = 45
        '
        'lbl_tipo_ativo
        '
        Me.lbl_tipo_ativo.AutoSize = True
        Me.lbl_tipo_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_tipo_ativo.Location = New System.Drawing.Point(405, 294)
        Me.lbl_tipo_ativo.Name = "lbl_tipo_ativo"
        Me.lbl_tipo_ativo.Size = New System.Drawing.Size(110, 21)
        Me.lbl_tipo_ativo.TabIndex = 44
        Me.lbl_tipo_ativo.Text = "Categoria:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(35, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(251, 21)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Descrição da Mercadoria:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label1.Location = New System.Drawing.Point(19, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 36)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "ATIVO"
        '
        'btn_cadastrar_ativo
        '
        Me.btn_cadastrar_ativo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_ativo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_cadastrar_ativo.Image = CType(resources.GetObject("btn_cadastrar_ativo.Image"), System.Drawing.Image)
        Me.btn_cadastrar_ativo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar_ativo.Location = New System.Drawing.Point(393, 360)
        Me.btn_cadastrar_ativo.Name = "btn_cadastrar_ativo"
        Me.btn_cadastrar_ativo.Size = New System.Drawing.Size(144, 36)
        Me.btn_cadastrar_ativo.TabIndex = 39
        Me.btn_cadastrar_ativo.Text = "Cadastrar"
        Me.btn_cadastrar_ativo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar_ativo.UseVisualStyleBackColor = True
        '
        'txt_vtotal_ativo
        '
        Me.txt_vtotal_ativo.Enabled = False
        Me.txt_vtotal_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vtotal_ativo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_vtotal_ativo.Location = New System.Drawing.Point(260, 295)
        Me.txt_vtotal_ativo.Multiline = True
        Me.txt_vtotal_ativo.Name = "txt_vtotal_ativo"
        Me.txt_vtotal_ativo.Size = New System.Drawing.Size(77, 59)
        Me.txt_vtotal_ativo.TabIndex = 35
        '
        'txt_vunit_ativo
        '
        Me.txt_vunit_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vunit_ativo.Location = New System.Drawing.Point(154, 295)
        Me.txt_vunit_ativo.Multiline = True
        Me.txt_vunit_ativo.Name = "txt_vunit_ativo"
        Me.txt_vunit_ativo.Size = New System.Drawing.Size(77, 59)
        Me.txt_vunit_ativo.TabIndex = 34
        '
        'txt_qtd_ativo
        '
        Me.txt_qtd_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_ativo.Location = New System.Drawing.Point(48, 295)
        Me.txt_qtd_ativo.Multiline = True
        Me.txt_qtd_ativo.Name = "txt_qtd_ativo"
        Me.txt_qtd_ativo.Size = New System.Drawing.Size(77, 59)
        Me.txt_qtd_ativo.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(35, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 21)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Nome"
        '
        'txt_desc_ativo
        '
        Me.txt_desc_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_ativo.Location = New System.Drawing.Point(39, 169)
        Me.txt_desc_ativo.Multiline = True
        Me.txt_desc_ativo.Name = "txt_desc_ativo"
        Me.txt_desc_ativo.Size = New System.Drawing.Size(550, 109)
        Me.txt_desc_ativo.TabIndex = 30
        '
        'txt_nome_ativo
        '
        Me.txt_nome_ativo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nome_ativo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nome_ativo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_ativo.Location = New System.Drawing.Point(39, 102)
        Me.txt_nome_ativo.Name = "txt_nome_ativo"
        Me.txt_nome_ativo.Size = New System.Drawing.Size(406, 26)
        Me.txt_nome_ativo.TabIndex = 29
        '
        'tab_passivo
        '
        Me.tab_passivo.Controls.Add(Me.lbl_vtotal_passivo)
        Me.tab_passivo.Controls.Add(Me.lbl_vunit_passivo)
        Me.tab_passivo.Controls.Add(Me.Label12)
        Me.tab_passivo.Controls.Add(Me.cmb_categoria_passivo)
        Me.tab_passivo.Controls.Add(Me.cmb_tipo_passivo)
        Me.tab_passivo.Controls.Add(Me.Label2)
        Me.tab_passivo.Controls.Add(Me.Label8)
        Me.tab_passivo.Controls.Add(Me.Label9)
        Me.tab_passivo.Controls.Add(Me.btn_cadastrar_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_vtotal_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_vunit_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_qtd_passivo)
        Me.tab_passivo.Controls.Add(Me.Label13)
        Me.tab_passivo.Controls.Add(Me.txt_desc_passivo)
        Me.tab_passivo.Controls.Add(Me.txt_nome_passivo)
        Me.tab_passivo.Location = New System.Drawing.Point(4, 26)
        Me.tab_passivo.Name = "tab_passivo"
        Me.tab_passivo.Size = New System.Drawing.Size(624, 427)
        Me.tab_passivo.TabIndex = 1
        Me.tab_passivo.Text = "PASSIVO"
        Me.tab_passivo.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label12.Location = New System.Drawing.Point(47, 357)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 46)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Quan - tidade"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmb_categoria_passivo
        '
        Me.cmb_categoria_passivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria_passivo.FormattingEnabled = True
        Me.cmb_categoria_passivo.Items.AddRange(New Object() {"Bebidas", "Comidas", "Eletrônicos", "Eletrodomésticos"})
        Me.cmb_categoria_passivo.Location = New System.Drawing.Point(359, 316)
        Me.cmb_categoria_passivo.Name = "cmb_categoria_passivo"
        Me.cmb_categoria_passivo.Size = New System.Drawing.Size(214, 25)
        Me.cmb_categoria_passivo.TabIndex = 61
        '
        'cmb_tipo_passivo
        '
        Me.cmb_tipo_passivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_passivo.FormattingEnabled = True
        Me.cmb_tipo_passivo.Items.AddRange(New Object() {"Compra", "Venda"})
        Me.cmb_tipo_passivo.Location = New System.Drawing.Point(451, 102)
        Me.cmb_tipo_passivo.Name = "cmb_tipo_passivo"
        Me.cmb_tipo_passivo.Size = New System.Drawing.Size(138, 25)
        Me.cmb_tipo_passivo.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label2.Location = New System.Drawing.Point(409, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 21)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Categoria:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(35, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(251, 21)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "Descrição da Mercadoria:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Cooper Black", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label9.Location = New System.Drawing.Point(19, 20)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(169, 36)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "PASSIVO"
        '
        'btn_cadastrar_passivo
        '
        Me.btn_cadastrar_passivo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cadastrar_passivo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_cadastrar_passivo.Image = CType(resources.GetObject("btn_cadastrar_passivo.Image"), System.Drawing.Image)
        Me.btn_cadastrar_passivo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cadastrar_passivo.Location = New System.Drawing.Point(393, 360)
        Me.btn_cadastrar_passivo.Name = "btn_cadastrar_passivo"
        Me.btn_cadastrar_passivo.Size = New System.Drawing.Size(144, 36)
        Me.btn_cadastrar_passivo.TabIndex = 56
        Me.btn_cadastrar_passivo.Text = "Cadastrar"
        Me.btn_cadastrar_passivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cadastrar_passivo.UseVisualStyleBackColor = True
        '
        'txt_vtotal_passivo
        '
        Me.txt_vtotal_passivo.Enabled = False
        Me.txt_vtotal_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vtotal_passivo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_vtotal_passivo.Location = New System.Drawing.Point(263, 295)
        Me.txt_vtotal_passivo.Multiline = True
        Me.txt_vtotal_passivo.Name = "txt_vtotal_passivo"
        Me.txt_vtotal_passivo.Size = New System.Drawing.Size(77, 59)
        Me.txt_vtotal_passivo.TabIndex = 52
        '
        'txt_vunit_passivo
        '
        Me.txt_vunit_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_vunit_passivo.Location = New System.Drawing.Point(157, 295)
        Me.txt_vunit_passivo.Multiline = True
        Me.txt_vunit_passivo.Name = "txt_vunit_passivo"
        Me.txt_vunit_passivo.Size = New System.Drawing.Size(77, 59)
        Me.txt_vunit_passivo.TabIndex = 51
        '
        'txt_qtd_passivo
        '
        Me.txt_qtd_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_qtd_passivo.Location = New System.Drawing.Point(51, 295)
        Me.txt_qtd_passivo.Multiline = True
        Me.txt_qtd_passivo.Name = "txt_qtd_passivo"
        Me.txt_qtd_passivo.Size = New System.Drawing.Size(77, 59)
        Me.txt_qtd_passivo.TabIndex = 50
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label13.Location = New System.Drawing.Point(35, 77)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 21)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Nome"
        '
        'txt_desc_passivo
        '
        Me.txt_desc_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_desc_passivo.Location = New System.Drawing.Point(39, 169)
        Me.txt_desc_passivo.Multiline = True
        Me.txt_desc_passivo.Name = "txt_desc_passivo"
        Me.txt_desc_passivo.Size = New System.Drawing.Size(550, 109)
        Me.txt_desc_passivo.TabIndex = 48
        '
        'txt_nome_passivo
        '
        Me.txt_nome_passivo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.txt_nome_passivo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_nome_passivo.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_nome_passivo.Location = New System.Drawing.Point(39, 102)
        Me.txt_nome_passivo.Name = "txt_nome_passivo"
        Me.txt_nome_passivo.Size = New System.Drawing.Size(406, 26)
        Me.txt_nome_passivo.TabIndex = 47
        '
        'lbl_vunit_passivo
        '
        Me.lbl_vunit_passivo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vunit_passivo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vunit_passivo.Location = New System.Drawing.Point(143, 357)
        Me.lbl_vunit_passivo.Name = "lbl_vunit_passivo"
        Me.lbl_vunit_passivo.Size = New System.Drawing.Size(100, 46)
        Me.lbl_vunit_passivo.TabIndex = 62
        Me.lbl_vunit_passivo.Text = "Valor Unitário"
        Me.lbl_vunit_passivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_vtotal_passivo
        '
        Me.lbl_vtotal_passivo.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_vtotal_passivo.ForeColor = System.Drawing.SystemColors.Highlight
        Me.lbl_vtotal_passivo.Location = New System.Drawing.Point(259, 355)
        Me.lbl_vtotal_passivo.Name = "lbl_vtotal_passivo"
        Me.lbl_vtotal_passivo.Size = New System.Drawing.Size(81, 46)
        Me.lbl_vtotal_passivo.TabIndex = 63
        Me.lbl_vtotal_passivo.Text = "Valor Total"
        Me.lbl_vtotal_passivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_planoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(909, 491)
        Me.Controls.Add(Me.tab_cadastro)
        Me.Controls.Add(Me.TreeView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_planoContas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cadastrar_ativo As Button
    Friend WithEvents txt_vtotal_ativo As TextBox
    Friend WithEvents txt_vunit_ativo As TextBox
    Friend WithEvents txt_qtd_ativo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_desc_ativo As TextBox
    Friend WithEvents txt_nome_ativo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_tipo_ativo As Label
    Friend WithEvents cmb_tipo_ativo As ComboBox
    Friend WithEvents cmb_categoria_ativo As ComboBox
    Friend WithEvents tab_passivo As TabPage
    Friend WithEvents cmb_categoria_passivo As ComboBox
    Friend WithEvents cmb_tipo_passivo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btn_cadastrar_passivo As Button
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_vtotal_passivo As TextBox
    Friend WithEvents txt_vunit_passivo As TextBox
    Friend WithEvents txt_qtd_passivo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txt_desc_passivo As TextBox
    Friend WithEvents txt_nome_passivo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_vtotal_ativo As Label
    Friend WithEvents lbl_vunit_ativo As Label
    Friend WithEvents lbl_vtotal_passivo As Label
    Friend WithEvents lbl_vunit_passivo As Label
End Class
