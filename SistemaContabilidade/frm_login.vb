Public Class frm_login
    Dim n_tentativas As Integer
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With cmb_nivel.Items
            .Add("Usuário")
            .Add("Administrador")
        End With
        cmb_nivel.SelectedIndex = 0
        txt_usuario.Focus()
        conecta_banco()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles link_esqueceu.LinkClicked
        usuario = txt_usuario.Text
        frm_recuperar.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_entrar.Click
        If txt_usuario.Text = Nothing Or txt_senha.Text = Nothing Then
            MsgBox("Você precisa digitar o usuário e senha!", vbInformation + vbOKOnly, "Atenção")
        Else
            sql = "SELECT * FROM tb_login WHERE usuario='" & txt_usuario.Text & "' OR email='" & txt_usuario.Text & "'"
            rs = db.Execute(sql)

            If rs.EOF = True Then
                MsgBox("Usuário ou senha está incorreto!", vbInformation + vbOKOnly, "Erro")
            Else
                If n_tentativas <= 0 Then
                    MsgBox("Você está bloqueado!" + vbNewLine + "Contacte um administrador.", vbExclamation + vbOKOnly, "Número de tentativas excedido!")
                    btn_entrar.Enabled = False
                Else
                    Dim senhaExata = StrComp(txt_senha.Text, rs.Fields(3).Value, vbBinaryCompare)
                    Dim usuarioExato = StrComp(txt_usuario.Text, rs.Fields(1).Value, vbBinaryCompare)
                    Dim emailExato = StrComp(txt_usuario.Text, rs.Fields(2).Value, vbBinaryCompare)

                    If senhaExata = 0 And (usuarioExato = 0 Or emailExato = 0) Then
                        tipo_conta = cmb_nivel.Text

                        If tipo_conta = rs.Fields(7).Value Then
                            frm_menu.Show()
                        Else
                            MsgBox("Você precisa acessar como " & rs.Fields(7).Value, vbInformation + vbOKOnly, "Atenção")
                        End If
                    Else
                        MsgBox("Usuário ou senha está incorreto!", vbInformation + vbOKOnly, "Erro")

                        If Not rs.Fields(7).Value = "Administrador" Then
                            n_tentativas = n_tentativas - 1
                            sql = "UPDATE tb_login SET n_tentativas =" & n_tentativas & ", status_conta='bloqueada' WHERE id_usuario = " & rs.Fields(0).Value & ""
                            db.Execute(sql)
                            lbl_tentativas.Text = n_tentativas

                            If n_tentativas = 0 Then
                                btn_entrar.Enabled = False
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txt_usuario_LostFocus(sender As Object, e As EventArgs) Handles txt_usuario.LostFocus
        sql = "SELECT * FROM tb_login WHERE usuario='" & txt_usuario.Text & "' OR email='" & txt_usuario.Text & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            lbl_tentativas.Text = rs.Fields(8).Value.ToString
            n_tentativas = rs.Fields(8).Value

            If n_tentativas <= 0 Then
                btn_entrar.Enabled = False
            Else
                btn_entrar.Enabled = True
            End If
        Else
            lbl_tentativas.Text = "3"
            n_tentativas = 3
            btn_entrar.Enabled = True
        End If
    End Sub
End Class
