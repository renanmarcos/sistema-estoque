Public Class frm_cadastro
    Dim objeto As New Valida_CPF_CNPJ
    Dim id As Integer
    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_tipo.Items
            .Add("Administração")
            .Add("Tecnologia")
            .Add("Comercial")
            .Add("Consultoria")
            .Add("Quimica")
            .Add("Educação")
        End With
        cmb_tipo.SelectedIndex = 0
        With cmb_perguntas.Items
            .Add("Qual é o segundo nome da mãe?")
            .Add("Primeira escola que estudou?")
            .Add("Qual era o nome do seu primeiro animal de estimação?")
            .Add("Qual é a sua comida favorita?")
            .Add("Qual é a profissão do seu avô?")
            .Add("Nome da empresa do seu primeiro emprego?")
        End With
        cmb_perguntas.SelectedIndex = 0
        conecta_banco()
    End Sub

    Private Sub cb_visualizar_CheckedChanged(sender As Object, e As EventArgs) Handles cb_visualizar.CheckedChanged
        If cb_visualizar.Checked Then
            txt_senha.PasswordChar = Nothing
            txt_repetir.PasswordChar = Nothing
        Else
            txt_senha.PasswordChar = "*"
            txt_repetir.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_nome.Text = Nothing Or txt_cnpj.MaskCompleted = False Or txt_usuario.Text = Nothing Or txt_email.Text = Nothing Or txt_resposta.Text = Nothing Or txt_senha.Text = Nothing Or txt_repetir.Text = Nothing Or txt_razao.Text = Nothing Then
            MsgBox("Todos os campos precisam ser preenchidos.", vbInformation + vbOKOnly, "Atenção")
        Else

            objeto.cnpj = txt_cnpj.Text

            If objeto.isCnpjValido = False Then
                MessageBox.Show("CNPJ Iválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If StrComp(txt_senha.Text, txt_repetir.Text, vbBinaryCompare) = 0 Then
                Verifica_ID()
                sql = "SELECT * FROM tb_login WHERE usuario='" & txt_nome.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    sql = "INSERT INTO tb_empresa VALUES ('" & txt_cnpj.Text & "', " _
                      & id & ", '" & txt_nome.Text & "' ,'" & txt_razao.Text & "', '" & cmb_tipo.Text & "')"
                    db.Execute(sql)

                    sql = "INSERT INTO tb_login (id_usuario, usuario, email, senha, pergunta_secreta, resposta_secreta)" &
                          "VALUES ('" & id & "', '" & txt_usuario.Text & "', " &
                          "'" & txt_email.Text & "', '" & txt_senha.Text & "', '" & cmb_perguntas.Text & "'," &
                          "'" & txt_resposta.Text & "')"
                    db.Execute(sql)

                    MsgBox("Usuário cadastrado com sucesso!", vbOKOnly, "Concluído")
                    Limpar()
                Else
                    MsgBox("Usuário já cadastrado no sistema.", vbInformation + vbOKOnly, "Erro")
                End If
            Else
                MsgBox("Senhas não coincidem.", vbInformation + vbOKOnly, "Atenção")
            End If
        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu.Show()
    End Sub
    Sub Verifica_ID()
        sql = "SELECT MAX (id_usuario) AS ultimoID FROM tb_login"
        rs = db.Execute(sql)

        If rs.BOF = True Then
            id = 1
        Else
            id = rs.Fields("ultimoID").Value + 1
        End If
    End Sub
End Class