Public Class frm_relatorio
    Private Sub frm_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_metodo.SelectedIndex = 0

        sql = "SELECT nome FROM tb_produtos WHERE cnpj = '" & cnpj & "'"
        rs = db.Execute(sql)

        If Not rs.EOF Then
            While Not rs.EOF
                lst_produtos.Items.Add(rs.Fields(0))
                rs.MoveNext()
            End While
        Else
            MessageBox.Show("Não há produtos cadastrados. Não é possível continuar", "Erro")
            Close()
        End If
    End Sub

    Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click
        If lst_produtos.SelectedIndex = -1 Then
            MessageBox.Show("Selecione um produto da lista!", "Atenção")
            Exit Sub
        End If

        sql = "SELECT quantidade, valor_unitario, valor_total, data_saida, hora_saida
FROM tb_produtos INNER JOIN tb_saida_peps ON tb_produtos.id_saida = tb_saida_peps.id_saida
WHERE tb_produtos.id_saida=1;"
    End Sub
End Class