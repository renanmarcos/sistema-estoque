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
        Me.dgv_dados = New System.Windows.Forms.DataGridView()
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.usuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ativar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.bloquear = New System.Windows.Forms.DataGridViewImageColumn()
        Me.excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.txt_parametros = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rd_todas = New System.Windows.Forms.RadioButton()
        Me.cmb_selecione = New System.Windows.Forms.ComboBox()
        Me.rd_bloqueadas = New System.Windows.Forms.RadioButton()
        Me.rd_ativas = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_dados
        '
        Me.dgv_dados.AllowUserToAddRows = False
        Me.dgv_dados.AllowUserToDeleteRows = False
        Me.dgv_dados.AllowUserToResizeColumns = False
        Me.dgv_dados.AllowUserToResizeRows = False
        Me.dgv_dados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_dados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_dados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero, Me.usuario, Me.status, Me.ativar, Me.bloquear, Me.excluir})
        Me.dgv_dados.Location = New System.Drawing.Point(25, 128)
        Me.dgv_dados.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv_dados.Name = "dgv_dados"
        Me.dgv_dados.ReadOnly = True
        Me.dgv_dados.RowTemplate.Height = 28
        Me.dgv_dados.Size = New System.Drawing.Size(649, 337)
        Me.dgv_dados.TabIndex = 0
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        '
        'usuario
        '
        Me.usuario.HeaderText = "Usuário"
        Me.usuario.Name = "usuario"
        '
        'status
        '
        Me.status.HeaderText = "Status conta"
        Me.status.Name = "status"
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
        '
        'excluir
        '
        Me.excluir.HeaderText = "Excluir"
        Me.excluir.Image = CType(resources.GetObject("excluir.Image"), System.Drawing.Image)
        Me.excluir.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom
        Me.excluir.Name = "excluir"
        '
        'txt_parametros
        '
        Me.txt_parametros.Location = New System.Drawing.Point(25, 77)
        Me.txt_parametros.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_parametros.Name = "txt_parametros"
        Me.txt_parametros.Size = New System.Drawing.Size(259, 20)
        Me.txt_parametros.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.08392!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 49)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Digite o parâmetro de busca"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rd_todas)
        Me.GroupBox1.Controls.Add(Me.cmb_selecione)
        Me.GroupBox1.Controls.Add(Me.rd_bloqueadas)
        Me.GroupBox1.Controls.Add(Me.rd_ativas)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.06993!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(321, 31)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(354, 85)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Selecione"
        '
        'rd_todas
        '
        Me.rd_todas.AutoSize = True
        Me.rd_todas.Location = New System.Drawing.Point(249, 58)
        Me.rd_todas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_todas.Name = "rd_todas"
        Me.rd_todas.Size = New System.Drawing.Size(66, 21)
        Me.rd_todas.TabIndex = 23
        Me.rd_todas.Text = "Todas"
        Me.rd_todas.UseVisualStyleBackColor = True
        '
        'cmb_selecione
        '
        Me.cmb_selecione.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_selecione.FormattingEnabled = True
        Me.cmb_selecione.Location = New System.Drawing.Point(12, 27)
        Me.cmb_selecione.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_selecione.Name = "cmb_selecione"
        Me.cmb_selecione.Size = New System.Drawing.Size(211, 24)
        Me.cmb_selecione.TabIndex = 0
        '
        'rd_bloqueadas
        '
        Me.rd_bloqueadas.AutoSize = True
        Me.rd_bloqueadas.Location = New System.Drawing.Point(249, 38)
        Me.rd_bloqueadas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_bloqueadas.Name = "rd_bloqueadas"
        Me.rd_bloqueadas.Size = New System.Drawing.Size(101, 21)
        Me.rd_bloqueadas.TabIndex = 22
        Me.rd_bloqueadas.Text = "Bloqueadas"
        Me.rd_bloqueadas.UseVisualStyleBackColor = True
        '
        'rd_ativas
        '
        Me.rd_ativas.AutoSize = True
        Me.rd_ativas.Checked = True
        Me.rd_ativas.Location = New System.Drawing.Point(249, 19)
        Me.rd_ativas.Margin = New System.Windows.Forms.Padding(2)
        Me.rd_ativas.Name = "rd_ativas"
        Me.rd_ativas.Size = New System.Drawing.Size(64, 21)
        Me.rd_ativas.TabIndex = 21
        Me.rd_ativas.TabStop = True
        Me.rd_ativas.Text = "Ativas"
        Me.rd_ativas.UseVisualStyleBackColor = True
        '
        'frm_manutencao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txt_parametros)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgv_dados)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(717, 515)
        Me.Name = "frm_manutencao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_manutencao"
        CType(Me.dgv_dados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_dados As DataGridView
    Friend WithEvents txt_parametros As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmb_selecione As ComboBox
    Friend WithEvents rd_todas As RadioButton
    Friend WithEvents rd_bloqueadas As RadioButton
    Friend WithEvents rd_ativas As RadioButton
    Friend WithEvents numero As DataGridViewTextBoxColumn
    Friend WithEvents usuario As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents ativar As DataGridViewImageColumn
    Friend WithEvents bloquear As DataGridViewImageColumn
    Friend WithEvents excluir As DataGridViewImageColumn
End Class
