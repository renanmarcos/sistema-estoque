Public Class frm_estoque
    Public resp, nomeproduto As String

    Private Sub frm_estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        With dgv_Produtos
            .Rows.Clear()
            sql = "select * from tb_produtos where cnpj = '" & cnpj & "'"
            rs = db.Execute(sql)
            Do While rs.EOF = False
                .Rows.Add(rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                rs.MoveNext()
            Loop
        End With
        lbl_cnpj.Text = cnpj
    End Sub

    Private Sub dgv_Produtos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_Produtos.CellContentClick
        With dgv_Produtos
            If .CurrentRow.Cells(3).Selected = True Then
                nomeproduto = .CurrentRow.Cells(0).Value.ToString
                sql = "select * from tb_produtos where nome = '" & nomeproduto & "'"
                rs = db.Execute(sql)
                frm_estoque2.txt_nome.Text = nomeproduto
                frm_estoque2.txt_descricao.Text = rs.Fields(3).Value
                frm_estoque2.cmb_categoria.SelectedIndex = frm_estoque2.cmb_categoria.FindString(rs.Fields(4).Value)
                frm_estoque2.Show()
                editar = 1

            ElseIf .CurrentRow.Cells(4).Selected = True Then
                nomeproduto = .CurrentRow.Cells(0).Value.ToString
                resp = MsgBox("Deseja excluir o produto: " & nomeproduto & "?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Atenção")
                If resp = MsgBoxResult.Yes Then
                    sql = "delete * from tb_produtos where nome ='" & nomeproduto & "'"
                    rs = db.Execute(sql)
                    With dgv_Produtos
                        .Rows.Clear()
                        sql = "select * from tb_produtos where cnpj = '" & cnpj & "'"
                        rs = db.Execute(sql)
                        Do While rs.EOF = False
                            .Rows.Add(rs.Fields(2).Value, rs.Fields(3).Value, rs.Fields(4).Value)
                            rs.MoveNext()
                        Loop
                    End With
                End If
            End If
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        frm_menu.Show()
    End Sub

    Private Sub btn_Adicionar_Click(sender As Object, e As EventArgs) Handles btn_Adicionar.Click
        editar = 0
        frm_estoque2.Show()
    End Sub
End Class