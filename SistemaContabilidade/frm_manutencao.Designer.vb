<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manutencao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_manutencao))
        Me.rd_ativas = New System.Windows.Forms.RadioButton()
        Me.rd_bloqueadas = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_selecione = New System.Windows.Forms.ComboBox()
        Me.txt_parametros = New System.Windows.Forms.TextBox()
        Me.rd_todas = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ativar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.bloquear = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'rd_ativas
        '
        Me.rd_ativas.AutoSize = True
        Me.rd_ativas.Checked = True
        Me.rd_ativas.Location = New System.Drawing.Point(13, 161)
        Me.rd_ativas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_ativas.Name = "rd_ativas"
        Me.rd_ativas.Size = New System.Drawing.Size(107, 23)
        Me.rd_ativas.TabIndex = 21
        Me.rd_ativas.TabStop = True
        Me.rd_ativas.Text = "Contas Ativas"
        Me.rd_ativas.UseVisualStyleBackColor = True
        '
        'rd_bloqueadas
        '
        Me.rd_bloqueadas.AutoSize = True
        Me.rd_bloqueadas.Location = New System.Drawing.Point(13, 188)
        Me.rd_bloqueadas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_bloqueadas.Name = "rd_bloqueadas"
        Me.rd_bloqueadas.Size = New System.Drawing.Size(144, 23)
        Me.rd_bloqueadas.TabIndex = 22
        Me.rd_bloqueadas.Text = "Contas Bloqueadas"
        Me.rd_bloqueadas.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(9, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 24)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Buscar por:"
        '
        'cmb_selecione
        '
        Me.cmb_selecione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_selecione.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.cmb_selecione.FormattingEnabled = True
        Me.cmb_selecione.Location = New System.Drawing.Point(13, 118)
        Me.cmb_selecione.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_selecione.Name = "cmb_selecione"
        Me.cmb_selecione.Size = New System.Drawing.Size(148, 33)
        Me.cmb_selecione.TabIndex = 0
        '
        'txt_parametros
        '
        Me.txt_parametros.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_parametros.Location = New System.Drawing.Point(13, 56)
        Me.txt_parametros.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_parametros.Name = "txt_parametros"
        Me.txt_parametros.Size = New System.Drawing.Size(148, 32)
        Me.txt_parametros.TabIndex = 19
        '
        'rd_todas
        '
        Me.rd_todas.AutoSize = True
        Me.rd_todas.Location = New System.Drawing.Point(13, 215)
        Me.rd_todas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_todas.Name = "rd_todas"
        Me.rd_todas.Size = New System.Drawing.Size(125, 23)
        Me.rd_todas.TabIndex = 23
        Me.rd_todas.Text = "Todas as Contas"
        Me.rd_todas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(9, 95)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 21)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tipos de Conta:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.rd_todas)
        Me.GroupBox1.Controls.Add(Me.txt_parametros)
        Me.GroupBox1.Controls.Add(Me.cmb_selecione)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rd_bloqueadas)
        Me.GroupBox1.Controls.Add(Me.rd_ativas)
        Me.GroupBox1.Font = New System.Drawing.Font("Bernard MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(5, 89)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(184, 254)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parâmetros"
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AllowUserToResizeColumns = False
        Me.dgv_dados.AllowUserToResizeRows = False
        Me.dgv_dados.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.BackgroundColor = System.Drawing.Color.White
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.usuario, Me.status, Me.ativar, Me.bloquear, Me.excluir})
        Me.dgv_dados.GridColor = System.Drawing.Color.White
        Me.dgv_dados.Location = New System.Drawing.Point(221, 22)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(616, 398)
        Me.dgv_dados.TabIndex = 0
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuário"
        Me.usuario.Name = "usuario"
        Me.usuario.ReadOnly = True
        '
        'status
        '
        Me.status.HeaderText = "Status conta"
        Me.status.Name = "status"
        Me.status.ReadOnly = True
        '
        'ativar
        '
        Me.ativar.HeaderText = "Ativar"
        Me.ativar.Image = CType(resources.GetObject("ativar.Image"), System.Drawing.Image)
        Me.ativar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.ativar.Name = "ativar"
        Me.ativar.ReadOnly = True
        Me.ativar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ativar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'bloquear
        '
        Me.bloquear.HeaderText = "Bloquear"
        Me.bloquear.Image = CType(resources.GetObject("bloquear.Image"), System.Drawing.Image)
        Me.bloquear.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.bloquear.Name = "bloquear"
        Me.bloquear.ReadOnly = True
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.excluir.Name = "excluir"
        Me.excluir.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.btn_voltar)
        Me.GroupBox2.Controls.Add(Me.dgv_dados)
        Me.GroupBox2.Controls.Add(Me.GroupBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(854, 473)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Font = New System.Drawing.Font("Cooper Black", 14.25!)
        Me.btn_voltar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_voltar.Location = New System.Drawing.Point(5, 348)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(110, 39)
        Me.btn_voltar.TabIndex = 33
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_manutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(895, 470)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_manutencao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuários"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rd_ativas As RadioButton
    Friend WithEvents rd_bloqueadas As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_selecione As ComboBox
    Friend WithEvents txt_parametros As TextBox
    Friend WithEvents rd_todas As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents ativar As DataGridViewImageColumn
    Friend WithEvents bloquear As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_voltar As Button
End Class
