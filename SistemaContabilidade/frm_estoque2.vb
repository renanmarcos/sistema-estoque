Public Class frm_estoque2
    Dim cont As Integer
    Private Sub frm_estoque2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_categoria.SelectedIndex = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_nome.Text = Nothing Or txt_descricao.Text = Nothing Or cmb_categoria.Text = Nothing Then
            MessageBox.Show(Me, "Preencha todos os dados corretamente", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            If editar = 1 Then
                sql = "UPDATE tb_produtos set nome = '" & txt_nome.Text & "' , descricao = '" & txt_descricao.Text &
                "' , categoria = '" & cmb_categoria.Text & "' where nome = '" & frm_estoque.nomeproduto & "'"
            Else
                sql = "select * from tb_produtos"
                rs = db.Execute(sql)
                Do While rs.EOF = False
                    cont = cont + 1
                    rs.MoveNext()
                Loop

                sql = "INSERT INTO tb_produtos (cnpj, id, nome, descricao, categoria) VALUES(" &
                      "'" & cnpj & "', '" & cont + 1 & "', '" & txt_nome.Text & "', '" & txt_descricao.Text & "', '" & cmb_categoria.Text & "')"
            End If
        End If

        db.Execute(sql)
        MessageBox.Show(Me, "Salvo com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        With frm_estoque.dgv_Produtos
            .Rows.Clear()
            sql = "select * from tb_produtos where cnpj = '" & cnpj & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            Loop
        End With
    End Sub
End Class