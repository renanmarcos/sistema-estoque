Public Class frm_cadastro
    Private Sub frm_cadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_perguntas.Items
            .Add("Qual é o segundo nome da mãe?")
            .Add("Primeira escola que estudou?")
            .Add("Qual era o nome do seu primeiro animal de estimação?")
            .Add("Qual é a sua comida favorita?")
            .Add("Qual é a profissão do seu avô?")
            .Add("Nome da empresa do seu primeiro emprego?")
        End With
        cmb_perguntas.SelectedIndex = 0

        With cmb_tipo.Items
            .Add("Usuário")
            .Add("Administrador")
        End With
        cmb_tipo.SelectedIndex = 0
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
        If txt_usuario.Text = Nothing Or txt_email.Text = Nothing Or txt_senha.Text = Nothing Or txt_repetir.Text = Nothing Or txt_resposta.Text = Nothing Then
            MsgBox("Todos os campos precisam ser preenchidos.", vbInformation + vbOKOnly, "Atenção")
        Else
            If StrComp(txt_senha.Text, txt_repetir.Text, vbBinaryCompare) = 0 Then
                sql = "SELECT * FROM tb_login WHERE usuario='" & txt_usuario.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    sql = "INSERT INTO tb_login (usuario, email, senha, pergunta_secreta, resposta_secreta, status_conta, tipo_conta, n_tentativas) VALUES ('" & txt_usuario.Text & "', '" _
                      & txt_email.Text & "', '" & txt_senha.Text & "', '" & cmb_perguntas.Text & "', '" _
                      & txt_resposta.Text & "', 'ativa', '" & cmb_tipo.Text & "', 3)"
                    db.Execute(sql)
                    MsgBox("Usuário cadastrado com sucesso!", vbOKOnly, "Concluído")
                Else
                    MsgBox("Usuário já cadastrado no sistema.", vbInformation + vbOKOnly, "Erro")
                End If
            Else
                MsgBox("Senhas não coincidem.", vbInformation + vbOKOnly, "Atenção")
            End If
        End If
    End Sub
End Class