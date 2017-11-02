Public Class frm_recuperar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not (txt_usuario.Text = Nothing Or txt_resposta.Text = Nothing) Then
            sql = "SELECT * FROM tb_login WHERE usuario='" & txt_usuario.Text & "' OR email='" & txt_usuario.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = False Then
                Dim usuarioExato = StrComp(txt_usuario.Text, rs.Fields(1).Value, vbBinaryCompare)
                Dim emailExato = StrComp(txt_usuario.Text, rs.Fields(3).Value, vbBinaryCompare)

                If usuarioExato = 0 Or emailExato = 0 Then
                    If rs.Fields(4).Value = cmb_perguntas.Text And rs.Fields(5).Value = txt_resposta.Text Then
                        MsgBox("Sua senha é: " & rs.Fields(3).Value, vbOKOnly, "Recuperar senha concluído")
                    Else
                        MsgBox("Pergunta secreta ou resposta secreta não correspondem.", vbExclamation + vbOKOnly, "Erro")
                    End If
                Else
                    MsgBox("Pergunta secreta ou resposta secreta não correspondem.", vbExclamation + vbOKOnly, "Erro")
                End If
            Else
                MsgBox("Usuário ou E-mail não encontrados.", vbInformation + vbOKOnly, "Erro")
            End If
        Else
            MsgBox("Usuário ou resposta secreta não podem estar vazios.", vbInformation + vbOKOnly, "Atenção")
        End If
    End Sub

    Private Sub frm_recuperar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_usuario.Text = usuario
        With cmb_perguntas.Items
            .Add("Qual é o segundo nome da mãe?")
            .Add("Primeira escola que estudou?")
            .Add("Qual era o nome do seu primeiro animal de estimação?")
            .Add("Qual é a sua comida favorita?")
            .Add("Qual é a profissão do seu avô?")
            .Add("Nome da empresa do seu primeiro emprego?")
        End With

        cmb_perguntas.SelectedIndex = 0
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu.Show()
    End Sub
End Class