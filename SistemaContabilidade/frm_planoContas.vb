Public Class frm_planoContas
    Dim sugestoes As New AutoCompleteStringCollection
    Dim id, cont, totalativo, totalpassivo As Integer
    Dim nome As String
    Dim qtd, vunitario, vtotal As Double
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Name = "ativo" Then
            tab_cadastro.SelectTab(0)
        End If

        If TreeView1.SelectedNode.Name = "passivo" Then
            tab_cadastro.SelectTab(1)
        End If
    End Sub

    Private Sub frm_planoContas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim rs2 As New ADODB.Recordset
        conecta_banco()
        cmb_tipo_ativo.SelectedIndex = 0
        cmb_tipo_passivo.SelectedIndex = 0
        cmb_categoria_ativo.SelectedIndex = 0
        cmb_categoria_passivo.SelectedIndex = 0
        atualizarSugestoes()

        sql = "SELECT * FROM tb_entrada INNER Join tb_produtos on tb_produtos.id = tb_entrada.id WHERE tb_produtos.cnpj='" & cnpj & "' AND tb_entrada.grupo_contas='ativo'"
        rs = db.Execute(sql)
        Do While Not rs.EOF
            totalativo = rs.Fields("valor_total").Value + totalativo
            sql = "SELECT IIF(ISNULL(SUM(valor_total)), 0, SUM(valor_total)) as teste FROM tb_saida_peps WHERE lote=" & rs.Fields("lote").Value & ""
            rs2 = db.Execute(sql)
            totalativo = totalativo - rs2.Fields("teste").Value
            rs.MoveNext()
        Loop
        sql = "SELECT * FROM tb_entrada INNER Join tb_produtos on tb_produtos.id = tb_entrada.id WHERE tb_produtos.cnpj='" & cnpj & "' AND tb_entrada.grupo_contas='passivo'"
        rs = db.Execute(sql)
        Do While Not rs.EOF
            totalpassivo = rs.Fields("valor_total").Value + totalpassivo
            sql = "SELECT IIF(ISNULL(SUM(valor_total)), 0, SUM(valor_total)) as teste FROM tb_saida_peps WHERE lote=" & rs.Fields("lote").Value & ""
            rs2 = db.Execute(sql)
            totalpassivo = totalpassivo - rs2.Fields("teste").Value
            rs.MoveNext()
        Loop

        sql = "SELECT * FROM (tb_produtos INNER JOIN tb_entrada ON tb_produtos.id = tb_entrada.id) WHERE tb_produtos.cnpj='" & cnpj & "' AND grupo_contas='ativo'"
        rs = db.Execute(sql)
        TreeView1.Nodes.Add(New TreeNode("1. Ativo " + totalativo.ToString("c")))
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("1.1. Bancos c/ Movimento"))
        TreeView1.Nodes(0).Nodes(0).Nodes.Add(New TreeNode("1.1.1. Banco Itaú"))
        TreeView1.Nodes(0).Nodes.Add(New TreeNode("1.2. Estoque de mercadoria"))
        cont = 0
        Do While Not rs.EOF
            If Not rs.Fields("nome").Value = nome Then
                cont = cont + 1
                TreeView1.Nodes(0).Nodes(1).Nodes.Add("1.2." + cont.ToString + ". " + rs.Fields("nome").Value)
            End If
            nome = rs.Fields("nome").Value
            rs.MoveNext()
        Loop
        TreeView1.Nodes.Add(New TreeNode("2. Passivo " + totalpassivo.ToString("c")))
        TreeView1.Nodes(1).Nodes.Add(New TreeNode("2.1. Bancos c/ Movimento"))
        TreeView1.Nodes(1).Nodes(0).Nodes.Add(New TreeNode("2.1.1. Banco Itaú"))
        TreeView1.Nodes(1).Nodes.Add(New TreeNode("2.2. Estoque de mercadoria"))
        sql = "SELECT * FROM (tb_produtos INNER JOIN tb_entrada ON tb_produtos.id = tb_entrada.id) WHERE tb_produtos.cnpj='" & cnpj & "' AND grupo_contas='passivo'"
        rs = db.Execute(sql)
        cont = 0
        Do While Not rs.EOF
            If Not rs.Fields("nome").Value = nome Then
                cont = cont + 1
                TreeView1.Nodes(1).Nodes(1).Nodes.Add("2.2." + cont.ToString + ". " + rs.Fields("nome").Value)
            End If
            nome = rs.Fields("nome").Value
            rs.MoveNext()
        Loop

    End Sub

    Private Sub btn_cadastrar_ativo_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_ativo.Click
        cadastrarProduto(cmb_tipo_ativo, txt_nome_ativo, txt_desc_ativo, txt_qtd_ativo, txt_vunit_ativo, "ativo",
                         cmb_categoria_ativo)
    End Sub

    Private Sub txt_nome_ativo_LostFocus(sender As Object, e As EventArgs) Handles txt_nome_ativo.LostFocus
        procurarDescricao(txt_nome_ativo, txt_desc_ativo, cmb_categoria_ativo)
    End Sub

    Private Sub txt_nome_passivo_LostFocus(sender As Object, e As EventArgs) Handles txt_nome_passivo.LostFocus
        procurarDescricao(txt_nome_passivo, txt_desc_passivo, cmb_categoria_passivo)
    End Sub

    Private Sub txt_vunit_ativo_LostFocus(sender As Object, e As EventArgs) Handles txt_vunit_ativo.LostFocus
        calcularTotal(txt_qtd_ativo, txt_vunit_ativo, txt_vtotal_ativo)
    End Sub

    Private Sub txt_qtd_ativo_LostFocus(sender As Object, e As EventArgs) Handles txt_qtd_ativo.LostFocus
        calcularTotal(txt_qtd_ativo, txt_vunit_ativo, txt_vtotal_ativo)
    End Sub

    Private Sub txt_qtd_passivo_LostFocus(sender As Object, e As EventArgs) Handles txt_qtd_passivo.LostFocus
        calcularTotal(txt_qtd_passivo, txt_vunit_passivo, txt_vtotal_passivo)
    End Sub

    Private Sub txt_vunit_passivo_LostFocus(sender As Object, e As EventArgs) Handles txt_vunit_passivo.LostFocus
        calcularTotal(txt_qtd_passivo, txt_vunit_passivo, txt_vtotal_passivo)
    End Sub

    Private Sub calcularTotal(txt_qtd As TextBox, txt_vunit As TextBox, txt_vtotal As TextBox)
        If Not (txt_qtd.Text = Nothing Or txt_vunit.Text = Nothing) Then
            Try
                qtd = Integer.Parse(txt_qtd.Text)
                vunitario = Double.Parse(txt_vunit.Text)
                vtotal = qtd * vunitario

                txt_vtotal.Text = vtotal.ToString("C")
            Catch ex As Exception
                MsgBox("Você precisa digitar número inteiro na quantidade e número no valor unitário")
            End Try
        End If
    End Sub

    Private Sub atualizarSugestoes()
        sql = "SELECT * FROM tb_produtos WHERE cnpj='" & cnpj & "'"
        rs = db.Execute(sql)

        Do While Not rs.EOF
            sugestoes.Add(rs.Fields("nome").Value)
            rs.MoveNext()
        Loop

        txt_nome_ativo.AutoCompleteCustomSource = sugestoes
        txt_nome_passivo.AutoCompleteCustomSource = sugestoes
    End Sub

    Private Sub TreeView1_NodeMouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TreeView1.NodeMouseDoubleClick
        Dim test As String
        Dim vetor As Object
        test = TreeView1.SelectedNode.Text
        vetor = Split(test, ". ")
        If Not vetor(1).Contains("R$") And Not vetor(1).Contains("Banco") And Not vetor(1).Contains("Estoque") Then
            If (vetor(0).Contains("1.2")) Then
                tab_cadastro.SelectTab(0)
                sql = "SELECT * FROM tb_produtos WHERE nome='" & vetor(1) & "'"
                rs = db.Execute(sql)
                txt_nome_ativo.Focus()
                txt_nome_ativo.Text = rs.Fields("nome").Value
                txt_desc_ativo.Focus()
                txt_desc_passivo.Enabled = True
                txt_desc_passivo.Clear()
                txt_nome_passivo.Clear()
                cmb_categoria_passivo.Enabled = True

            Else
                tab_cadastro.SelectTab(1)
                sql = "SELECT * FROM tb_produtos WHERE nome='" & vetor(1) & "'"
                rs = db.Execute(sql)
                txt_nome_passivo.Focus()
                txt_nome_passivo.Text = rs.Fields("nome").Value
                txt_desc_passivo.Focus()
                txt_desc_ativo.Enabled = True
                cmb_categoria_ativo.Enabled = True
                txt_desc_ativo.Clear()
                txt_nome_ativo.Clear()
            End If
        End If
    End Sub

    Private Sub tab_ativo_Click(sender As Object, e As EventArgs) Handles tab_ativo.Click

    End Sub

    Private Sub btn_cadastrar_passivo_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_passivo.Click
        cadastrarProduto(cmb_tipo_passivo, txt_nome_passivo, txt_desc_passivo, txt_qtd_passivo, txt_vunit_passivo,
                         "passivo", cmb_categoria_passivo)
    End Sub

    Private Sub cmb_tipo_ativo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_ativo.SelectedIndexChanged
        If cmb_tipo_ativo.SelectedIndex = 1 Then
            txt_vunit_ativo.Hide()
            txt_vtotal_ativo.Hide()
            lbl_vunit_ativo.Hide()
            lbl_vtotal_ativo.Hide()
            txt_vunit_passivo.Clear()
            txt_vtotal_passivo.Clear()
        Else
            txt_vunit_ativo.Show()
            txt_vtotal_ativo.Show()
            lbl_vunit_ativo.Show()
            lbl_vtotal_ativo.Show()
        End If
    End Sub

    Private Sub cmb_tipo_passivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_passivo.SelectedIndexChanged
        If cmb_tipo_passivo.SelectedIndex = 1 Then
            txt_vunit_passivo.Hide()
            txt_vtotal_passivo.Hide()
            lbl_vtotal_passivo.Hide()
            lbl_vunit_passivo.Hide()
            txt_vunit_passivo.Clear()
            txt_vtotal_passivo.Clear()
        Else
            txt_vunit_passivo.Show()
            txt_vtotal_passivo.Show()
            lbl_vunit_passivo.Show()
            lbl_vtotal_passivo.Show()
        End If
    End Sub

    Private Sub procurarDescricao(txt_nome As TextBox, txt_desc As TextBox, cmb_categoria As ComboBox)
        sql = "SELECT * FROM tb_produtos WHERE nome='" & txt_nome.Text & "' AND cnpj='" & cnpj & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            txt_desc.Text = rs.Fields("descricao").Value
            cmb_categoria.SelectedItem = rs.Fields("categoria").Value
            txt_desc.Enabled = False
            cmb_categoria.Enabled = False
        Else
            txt_desc.Enabled = True
            cmb_categoria.Enabled = True
            txt_desc.Text = Nothing
            cmb_categoria.SelectedIndex = 0
            txt_desc.Focus()
        End If
    End Sub

    Private Sub cadastrarProduto(cmb_tipo As ComboBox, txt_nome As TextBox, txt_desc As TextBox,
                                 txt_qtd As TextBox, txt_vunit As TextBox, grupoConta As String,
                                 cmb_categoria As ComboBox)

        If cmb_tipo.SelectedItem = "Compra" Then
            If txt_nome.Text = Nothing Or txt_desc.Text = Nothing Or txt_qtd.Text = Nothing Or txt_vunit.Text = Nothing Then
                MsgBox("Preencha todos os campos")
            Else
                Try
                    sql = "SELECT * FROM tb_produtos WHERE cnpj='" & cnpj & "' AND nome='" & txt_nome.Text & "'"
                    rs = db.Execute(sql)

                    If Not rs.EOF Then
                        id = rs.Fields("id").Value

                        sql = "INSERT INTO tb_entrada (id, quantidade, valor_unitario, valor_total, grupo_contas, " &
                              "data_entrada, hora_entrada) VALUES(" & id & ", " & txt_qtd.Text & ", " &
                              "'" & txt_vunit.Text & "', '" & vtotal & "', '" & grupoConta & "', " &
                              "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                        db.Execute(sql)

                        MsgBox("Produto inserido com sucesso!")
                    Else
                        Dim id As Integer

                        sql = "SELECT IIF(ISNULL(MAX(id)), 0, MAX(id)) AS idMaximo FROM tb_produtos"
                        rs = db.Execute(sql)
                        id = rs.Fields("idMaximo").Value + 1

                        sql = "INSERT INTO tb_produtos VALUES('" & cnpj & "', " & id & ", " &
                              "'" & txt_nome.Text & "', '" & txt_desc.Text & "', '" & cmb_categoria.Text & "')"
                        db.Execute(sql)

                        sql = "INSERT INTO tb_entrada (id, quantidade, valor_unitario, valor_total, grupo_contas, " &
                              "data_entrada, hora_entrada) VALUES(" & id & ", " & txt_qtd.Text & ", " &
                              "'" & txt_vunit.Text & "', '" & vtotal & "', '" & grupoConta & "', " &
                              "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                        db.Execute(sql)
                        atualizarSugestoes()

                        MsgBox("Produto inserido com sucesso!")
                    End If
                Catch ex As Exception
                    MsgBox("Verifique se todos os campos estão corretos.")
                End Try
            End If
        Else
            If txt_nome.Text = Nothing Or txt_desc.Text = Nothing Or txt_qtd.Text = Nothing Then
                MsgBox("Preencha todos os campos")
            Else
                sql = "SELECT * FROM tb_produtos WHERE cnpj='" & cnpj & "' AND nome='" & txt_nome.Text & "'"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    Dim qtdEntrada, qtdSaida, qtdTotal, qtdDigitada As Integer

                    Try
                        qtdDigitada = Integer.Parse(txt_qtd.Text)
                    Catch ex As FormatException
                        MsgBox("Você precisa digitar um número inteiro na quantidade")
                        Exit Sub
                    End Try

                    id = rs.Fields("id").Value

                    sql = "SELECT IIF(ISNULL(SUM(quantidade)), 0, SUM(quantidade)) FROM tb_entrada WHERE id=" & id
                    rs = db.Execute(sql)
                    qtdEntrada = rs.Fields(0).Value

                    sql = "SELECT IIF(ISNULL(SUM(quantidade)), 0, SUM(quantidade)) FROM tb_saida_peps WHERE id=" & id
                    rs = db.Execute(sql)
                    qtdSaida = rs.Fields(0).Value

                    qtdTotal = qtdEntrada - qtdSaida

                    If qtdDigitada > qtdTotal Or qtdDigitada <= 0 Then
                        MsgBox("Você está tentando vender mais produtos do que o existente no estoque ou um valor menor ou igual a zero.")
                        Exit Sub
                    Else
                        Dim rsAux As New ADODB.Recordset
                        Dim qtdAtualLote As Integer = 0

                        sql = "SELECT * FROM tb_entrada WHERE id=" & id & ""
                        rs = db.Execute(sql)

                        While qtdDigitada > 0
                            sql = "SELECT IIF(ISNULL(SUM(tb_saida_peps.quantidade)), 0, SUM(tb_saida_peps.quantidade)) AS somaPeps " &
                                "FROM tb_entrada INNER JOIN tb_saida_peps ON tb_entrada.lote = tb_saida_peps.lote " &
                                "WHERE tb_entrada.lote=" & rs.Fields("lote").Value & ""
                            rsAux = db.Execute(sql)

                            qtdAtualLote = rs.Fields("quantidade").Value - rsAux.Fields("somaPeps").Value

                            If Not qtdAtualLote = 0 Then
                                If qtdDigitada >= qtdAtualLote Then

                                    qtdDigitada -= qtdAtualLote

                                    sql = "INSERT INTO tb_saida_peps VALUES(" & id & ", " & rs.Fields("lote").Value & ", " & qtdAtualLote & "," &
                                          "" & rs.Fields("valor_unitario").Value & ", " & qtdAtualLote * rs.Fields("valor_unitario").Value & ", '" & grupoConta & "', " &
                                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                                    db.Execute(sql)
                                Else

                                    sql = "INSERT INTO tb_saida_peps VALUES(" & id & ", " & rs.Fields("lote").Value & ", " & qtdDigitada & "," &
                                          "" & rs.Fields("valor_unitario").Value & ", " & qtdDigitada * rs.Fields("valor_unitario").Value & ", '" & grupoConta & "', " &
                                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                                    db.Execute(sql)

                                    qtdDigitada = 0
                                End If
                            End If

                            rs.MoveNext()
                        End While

                        sql = "SELECT * FROM tb_entrada WHERE id=" & id & ""
                        rs = db.Execute(sql)
                        rs.MoveLast()
                        qtdDigitada = Integer.Parse(txt_qtd.Text)

                        While qtdDigitada > 0
                            sql = "SELECT IIF(ISNULL(SUM(tb_saida_ueps.quantidade)), 0, SUM(tb_saida_ueps.quantidade)) AS somaUeps " &
                                "FROM tb_entrada INNER JOIN tb_saida_ueps ON tb_entrada.lote = tb_saida_ueps.lote " &
                                "WHERE tb_entrada.lote=" & rs.Fields("lote").Value & ""
                            rsAux = db.Execute(sql)

                            qtdAtualLote = rs.Fields("quantidade").Value - rsAux.Fields("somaUeps").Value

                            If Not qtdAtualLote = 0 Then
                                If qtdDigitada >= qtdAtualLote Then

                                    qtdDigitada -= qtdAtualLote

                                    sql = "INSERT INTO tb_saida_ueps VALUES(" & id & ", " & rs.Fields("lote").Value & ", " & qtdAtualLote & "," &
                                          "" & rs.Fields("valor_unitario").Value & ", " & qtdAtualLote * rs.Fields("valor_unitario").Value & ", '" & grupoConta & "', " &
                                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                                    db.Execute(sql)
                                Else

                                    sql = "INSERT INTO tb_saida_ueps VALUES(" & id & ", " & rs.Fields("lote").Value & ", " & qtdDigitada & "," &
                                          "" & rs.Fields("valor_unitario").Value & ", " & qtdDigitada * rs.Fields("valor_unitario").Value & ", '" & grupoConta & "', " &
                                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                                    db.Execute(sql)

                                    qtdDigitada = 0
                                End If
                            End If

                            rs.MovePrevious()
                        End While

                        Dim valorUnitario As Double
                        sql = "SELECT SUM(valor_total) AS somaValor, SUM(quantidade) AS qtdTotal FROM tb_entrada WHERE id=" & id & ""
                        rs = db.Execute(sql)
                        valorUnitario = rs.Fields("somaValor").Value / rs.Fields("qtdTotal").Value
                        valorUnitario = Math.Round(valorUnitario, 2)
                        qtdDigitada = Integer.Parse(txt_qtd.Text)

                        sql = "INSERT INTO tb_saida_media VALUES(" & id & ", " & qtdDigitada & ", '" & valorUnitario & "', '" & valorUnitario * qtdDigitada & "', " &
                              "'" & grupoConta & "', '" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                        db.Execute(sql)

                        MsgBox("Vendido com sucesso!")
                    End If
                Else
                    MsgBox("Você não pode vender um produto que não existe.")
                End If
            End If
        End If
    End Sub
End Class