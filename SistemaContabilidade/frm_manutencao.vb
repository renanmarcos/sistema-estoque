Public Class frm_manutencao
    Dim cont As Integer
    Private Sub frm_manutencao_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        With cmb_selecione.Items
            .Add("usuario")
            .Add("email")
        End With
        cmb_selecione.SelectedIndex = 0
        conecta_banco()
        primeira_listagem()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_parametros.TextChanged
        If rd_todas.Checked Then
            gerar_dados("tudo")
        ElseIf rd_bloqueadas.Checked Then
            gerar_dados("bloqueada")
        Else
            gerar_dados("ativa")
        End If
    End Sub

    Private Sub dgv_dados_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_dados.CellContentClick
        If dgv_dados.CurrentRow.Cells(3).Selected Then

            sql = "SELECT * FROM tb_login WHERE usuario='" & dgv_dados.CurrentRow.Cells(1).Value & "'"
            rs = db.Execute(sql)

            If rs.Fields(7).Value = "Administrador" Then
                MsgBox("Você não pode editar o Administrador.", vbExclamation + vbOKOnly, "Erro")
            Else
                sql = "UPDATE tb_login SET status_conta='ativa', n_tentativas=3 WHERE usuario='" & dgv_dados.CurrentRow.Cells(1).Value & "'"
                db.Execute(sql)
                rd_ativas.Checked = True
                MsgBox("Usuário ativado com sucesso!", vbOKOnly, "Concluído")
            End If

        ElseIf dgv_dados.CurrentRow.Cells(4).Selected Then

            sql = "SELECT * FROM tb_login WHERE usuario='" & dgv_dados.CurrentRow.Cells(1).Value & "'"
            rs = db.Execute(sql)

            If rs.Fields(7).Value = "Administrador" Then
                MsgBox("Você não pode editar o Administrador.", vbExclamation + vbOKOnly, "Erro")
            Else
                sql = "UPDATE tb_login SET status_conta='bloqueada', n_tentativas=0 WHERE usuario='" & dgv_dados.CurrentRow.Cells(1).Value & "'"
                db.Execute(sql)
                rd_bloqueadas.Checked = True
                MsgBox("Usuário bloqueado com sucesso!", vbOKOnly, "Concluido")
            End If

        ElseIf dgv_dados.CurrentRow.Cells(5).Selected Then

            sql = "SELECT * FROM tb_login WHERE usuario='" & dgv_dados.CurrentRow.Cells(1).Value & "'"
            rs = db.Execute(sql)

            If rs.Fields(7).Value = "Administrador" Then
                MsgBox("Você não pode editar o Administrador.", vbExclamation + vbOKOnly, "Erro")
            Else
                sql = "DELETE FROM tb_login WHERE usuario='" & dgv_dados.CurrentRow.Cells(1).Value & "'"
                db.Execute(sql)
                rd_todas.Checked = True
                MsgBox("Usuário excluído com sucesso!", vbOKOnly, "Concluido")
            End If

        End If
    End Sub

    Private Sub rd_bloqueadas_CheckedChanged(sender As Object, e As EventArgs) Handles rd_bloqueadas.CheckedChanged
        gerar_dados("bloqueada")
    End Sub

    Private Sub rd_todas_CheckedChanged(sender As Object, e As EventArgs) Handles rd_todas.CheckedChanged
        gerar_dados("tudo")
    End Sub

    Private Sub rd_ativas_CheckedChanged(sender As Object, e As EventArgs) Handles rd_ativas.CheckedChanged
        gerar_dados("ativa")
    End Sub

    Sub gerar_dados(situacao As String)
        Dim cont As Integer

        If Not cmb_selecione.Text = Nothing Then
            If situacao = "tudo" Then
                With dgv_dados
                    .Rows.Clear()
                    sql = "SELECT * FROM tb_login WHERE " & cmb_selecione.Text & " LIKE '" & txt_parametros.Text & "%' ORDER BY usuario"
                    rs = db.Execute(sql)
                    cont = 1
                    Do While rs.EOF = False
                        .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(6).Value, Nothing, Nothing, Nothing)
                        rs.MoveNext()
                        cont = cont + 1
                    Loop
                End With
            Else
                With dgv_dados
                    .Rows.Clear()
                    sql = "SELECT * FROM tb_login WHERE " & cmb_selecione.Text & " LIKE '" & txt_parametros.Text & "%' AND status_conta='" & situacao & "' ORDER BY usuario"
                    rs = db.Execute(sql)
                    cont = 1
                    Do While rs.EOF = False
                        .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(6).Value, Nothing, Nothing, Nothing)
                        rs.MoveNext()
                        cont = cont + 1
                    Loop
                End With
            End If
        Else
        End If
    End Sub

    Private Sub btn_voltar_Click(sender As Object, e As EventArgs) Handles btn_voltar.Click
        Me.Close()
        frm_menu.Show()
    End Sub
End Class