<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_cadastro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_cadastro))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cb_visualizar = New System.Windows.Forms.CheckBox()
        Me.txt_razao = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_senha = New System.Windows.Forms.MaskedTextBox()
        Me.txt_repetir = New System.Windows.Forms.MaskedTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_resposta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_resposta = New System.Windows.Forms.Label()
        Me.cmb_perguntas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_email = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_cnpj = New System.Windows.Forms.MaskedTextBox()
        Me.btn_voltar = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label3.Location = New System.Drawing.Point(474, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 29)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "CNPJ"
        '
        'txt_nome
        '
        Me.txt_nome.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_nome.Location = New System.Drawing.Point(24, 39)
        Me.txt_nome.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(446, 32)
        Me.txt_nome.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(215, 29)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nome da Empresa"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label1.Location = New System.Drawing.Point(529, 73)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 29)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Senha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label4.Location = New System.Drawing.Point(539, 139)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 29)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Repetir senha"
        '
        'cb_visualizar
        '
        Me.cb_visualizar.AutoSize = True
        Me.cb_visualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cb_visualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cb_visualizar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.cb_visualizar.Location = New System.Drawing.Point(765, 122)
        Me.cb_visualizar.Margin = New System.Windows.Forms.Padding(2)
        Me.cb_visualizar.Name = "cb_visualizar"
        Me.cb_visualizar.Size = New System.Drawing.Size(100, 44)
        Me.cb_visualizar.TabIndex = 22
        Me.cb_visualizar.Text = "Visualizar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "senha"
        Me.cb_visualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cb_visualizar.UseVisualStyleBackColor = True
        '
        'txt_razao
        '
        Me.txt_razao.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_razao.Location = New System.Drawing.Point(24, 169)
        Me.txt_razao.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_razao.Name = "txt_razao"
        Me.txt_razao.Size = New System.Drawing.Size(237, 32)
        Me.txt_razao.TabIndex = 27
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label7.Location = New System.Drawing.Point(19, 138)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 29)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Razão Social"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Button1.Location = New System.Drawing.Point(24, 281)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(133, 50)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Criar conta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_senha
        '
        Me.txt_senha.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_senha.Location = New System.Drawing.Point(534, 104)
        Me.txt_senha.Name = "txt_senha"
        Me.txt_senha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_senha.Size = New System.Drawing.Size(217, 32)
        Me.txt_senha.TabIndex = 30
        '
        'txt_repetir
        '
        Me.txt_repetir.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_repetir.Location = New System.Drawing.Point(538, 168)
        Me.txt_repetir.Name = "txt_repetir"
        Me.txt_repetir.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_repetir.Size = New System.Drawing.Size(217, 32)
        Me.txt_repetir.TabIndex = 31
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.txt_resposta)
        Me.GroupBox2.Controls.Add(Me.lbl_resposta)
        Me.GroupBox2.Controls.Add(Me.cmb_perguntas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lbl_email)
        Me.GroupBox2.Controls.Add(Me.txt_email)
        Me.GroupBox2.Controls.Add(Me.lbl_usuario)
        Me.GroupBox2.Controls.Add(Me.txt_usuario)
        Me.GroupBox2.Controls.Add(Me.cmb_tipo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txt_cnpj)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_repetir)
        Me.GroupBox2.Controls.Add(Me.txt_nome)
        Me.GroupBox2.Controls.Add(Me.txt_senha)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txt_razao)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cb_visualizar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.Highlight
        Me.GroupBox2.Location = New System.Drawing.Point(12, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(871, 356)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        '
        'txt_resposta
        '
        Me.txt_resposta.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_resposta.Location = New System.Drawing.Point(473, 242)
        Me.txt_resposta.Name = "txt_resposta"
        Me.txt_resposta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_resposta.Size = New System.Drawing.Size(302, 32)
        Me.txt_resposta.TabIndex = 42
        '
        'lbl_resposta
        '
        Me.lbl_resposta.AutoSize = True
        Me.lbl_resposta.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_resposta.Location = New System.Drawing.Point(474, 213)
        Me.lbl_resposta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_resposta.Name = "lbl_resposta"
        Me.lbl_resposta.Size = New System.Drawing.Size(200, 29)
        Me.lbl_resposta.TabIndex = 41
        Me.lbl_resposta.Text = "Resposta secreta"
        '
        'cmb_perguntas
        '
        Me.cmb_perguntas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_perguntas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_perguntas.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.cmb_perguntas.FormattingEnabled = True
        Me.cmb_perguntas.Location = New System.Drawing.Point(24, 242)
        Me.cmb_perguntas.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_perguntas.Name = "cmb_perguntas"
        Me.cmb_perguntas.Size = New System.Drawing.Size(444, 33)
        Me.cmb_perguntas.TabIndex = 40
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label5.Location = New System.Drawing.Point(19, 213)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(195, 29)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Pergunta secreta"
        '
        'lbl_email
        '
        Me.lbl_email.AutoSize = True
        Me.lbl_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_email.Location = New System.Drawing.Point(243, 73)
        Me.lbl_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_email.Name = "lbl_email"
        Me.lbl_email.Size = New System.Drawing.Size(74, 29)
        Me.lbl_email.TabIndex = 37
        Me.lbl_email.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_email.Location = New System.Drawing.Point(248, 104)
        Me.txt_email.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(280, 32)
        Me.txt_email.TabIndex = 38
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.lbl_usuario.Location = New System.Drawing.Point(19, 73)
        Me.lbl_usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(96, 29)
        Me.lbl_usuario.TabIndex = 35
        Me.lbl_usuario.Text = "Usuário"
        '
        'txt_usuario
        '
        Me.txt_usuario.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.txt_usuario.Location = New System.Drawing.Point(24, 104)
        Me.txt_usuario.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(212, 32)
        Me.txt_usuario.TabIndex = 36
        '
        'cmb_tipo
        '
        Me.cmb_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo.Font = New System.Drawing.Font("Bernard MT Condensed", 15.75!)
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(265, 169)
        Me.cmb_tipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(259, 33)
        Me.cmb_tipo.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!)
        Me.Label6.Location = New System.Drawing.Point(259, 138)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(260, 29)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Segmento da Empresa"
        '
        'txt_cnpj
        '
        Me.txt_cnpj.Location = New System.Drawing.Point(479, 32)
        Me.txt_cnpj.Mask = "00,000,000/0000-00"
        Me.txt_cnpj.Name = "txt_cnpj"
        Me.txt_cnpj.Size = New System.Drawing.Size(252, 38)
        Me.txt_cnpj.TabIndex = 32
        '
        'btn_voltar
        '
        Me.btn_voltar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_voltar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_voltar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_voltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.06993!)
        Me.btn_voltar.Image = CType(resources.GetObject("btn_voltar.Image"), System.Drawing.Image)
        Me.btn_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_voltar.Location = New System.Drawing.Point(736, 416)
        Me.btn_voltar.Name = "btn_voltar"
        Me.btn_voltar.Size = New System.Drawing.Size(89, 39)
        Me.btn_voltar.TabIndex = 32
        Me.btn_voltar.Text = "Voltar"
        Me.btn_voltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_voltar.UseVisualStyleBackColor = False
        '
        'frm_cadastro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(895, 466)
        Me.Controls.Add(Me.btn_voltar)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.Name = "frm_cadastro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cb_visualizar As CheckBox
    Friend WithEvents txt_razao As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_senha As MaskedTextBox
    Friend WithEvents txt_repetir As MaskedTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_voltar As Button
    Friend WithEvents txt_cnpj As MaskedTextBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_perguntas As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_email As Label
    Friend WithEvents txt_email As TextBox
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents txt_usuario As TextBox
    Friend WithEvents txt_resposta As MaskedTextBox
    Friend WithEvents lbl_resposta As Label
End Class
