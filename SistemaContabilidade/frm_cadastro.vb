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
        If txt_usuario.Text = Nothing Or txt_cnpj.Text = Nothing Or txt_senha.Text = Nothing Or txt_repetir.Text = Nothing Or txt_razao.Text = Nothing Then
            MsgBox("Todos os campos precisam ser preenchidos.", vbInformation + vbOKOnly, "Atenção")
        Else
            If txt_cnpj.TextLength = 14 Then
                txt_cnpj.Mask = "00.000.000/0000-00"
                objeto.cnpj = txt_cnpj.Text
                If objeto.isCnpjValido = False Then
                    MessageBox.Show("CNPJ Iválido!", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Exit Sub
                End If
            End If
            If StrComp(txt_senha.Text, txt_repetir.Text, vbBinaryCompare) = 0 Then
                Verifica_ID()
                sql = "SELECT * FROM tb_login WHERE usuario='" & txt_usuario.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = True Then
                    sql = "INSERT INTO tb_empresa (cnpj, id_usuario, nome_fantasia, razao_social, categoria, senha) VALUES ('" & txt_cnpj.Text & "', " _
                      & id & ", '" & txt_razao.Text & "', '" & cmb_tipo.Text & "', '" _
                      & txt_senha.Text & "')"
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

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu.Show()
    End Sub
    Sub Verifica_ID()
        sql = "select MAX (id_usuario) as id from tb_login"
        rs = db.Execute(sql)
        If rs.BOF = True Then
            id = 1
        Else
            id = rs.Fields(0).Value + 1
        End If
    End Sub

End Class