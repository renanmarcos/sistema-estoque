Public Class frm_planoContas
    Dim sugestoes As New AutoCompleteStringCollection

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Name = "ativo" Then
            tab_cadastro.SelectTab(0)
        End If

        If TreeView1.SelectedNode.Name = "passivo" Then
            tab_cadastro.SelectTab(1)
        End If
    End Sub

    Private Sub frm_planoContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conecta_banco()
        cmb_tipo_ativo.SelectedIndex = 0
        cmb_tipo_passivo.SelectedIndex = 0

        sql = "SELECT * FROM tb_produtos WHERE cnpj='" & cnpj & "'"
        rs = db.Execute(sql)

        Do While Not rs.EOF
            sugestoes.Add(rs.Fields("nome").Value)
            lote = rs.Fields("lote").Value
            rs.MoveNext()
        Loop

        txt_nome_ativo.AutoCompleteCustomSource = sugestoes
        txt_nome_passivo.AutoCompleteCustomSource = sugestoes
    End Sub

    Private Sub btn_cadastrar_ativo_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_ativo.Click
        If tab_cadastro.SelectedTab Is tab_ativo Then
            If cmb_tipo_ativo.SelectedItem = "Compra" Then
                'Em produção ainda. Lógica:
                ' - Verificar se o produto existe, se não existir, cadastrar em tb_produtos e depois inserir no tb_entrada.
                ' - Se já existe, apenas inserir no tb_entrada

                ' ATENÇÃO: PRECISO TER O MESMO PRODUTO CADASTRADO EM EMPRESAS DIFERENTES, PORQUE O ID TEM QUE SER UNICO
                ' OU SEJA... SOU OBRIGADO A CADASTRAR O MESMO PRODUTO SE ELE JA EXISTIR EM OUTRO CNPJ

                'sql = "INSERT INTO tb_entrada VALUES('" & cnpj & "', '" & lote & "', "
            End If
        End If
    End Sub

    Private Sub txt_nome_ativo_LostFocus(sender As Object, e As EventArgs) Handles txt_nome_ativo.LostFocus
        sql = "SELECT * FROM tb_produtos WHERE nome='" & txt_nome_ativo.Text & "' AND cnpj='" & cnpj & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            txt_desc_ativo.Text = rs.Fields("descricao").Value
            txt_desc_ativo.Enabled = False
        Else
            txt_desc_ativo.Enabled = True
            txt_desc_ativo.Text = Nothing
            txt_desc_ativo.Focus()
        End If
    End Sub

    Private Sub txt_nome_passivo_LostFocus(sender As Object, e As EventArgs) Handles txt_nome_passivo.LostFocus
        sql = "SELECT * FROM tb_produtos WHERE nome='" & txt_nome_ativo.Text & "' AND cnpj='" & cnpj & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            txt_desc_passivo.Text = rs.Fields("descricao").Value
            txt_desc_passivo.Enabled = False
        Else
            txt_desc_passivo.Enabled = True
            txt_desc_passivo.Text = Nothing
            txt_desc_passivo.Focus()
        End If
    End Sub
End Class