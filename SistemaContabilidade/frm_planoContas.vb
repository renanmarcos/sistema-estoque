Public Class frm_planoContas
    Dim sugestoes As New AutoCompleteStringCollection
    Dim id_entrada, id_saida As Integer
    Dim cnpj = "88.724.022/0001-45"
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
        conecta_banco()
        cmb_tipo_ativo.SelectedIndex = 0
        cmb_tipo_passivo.SelectedIndex = 0
        cmb_categoria_ativo.SelectedIndex = 0
        cmb_categoria_passivo.SelectedIndex = 0
        atualizarSugestoes()
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
                qtd = Double.Parse(txt_qtd.Text)
                vunitario = Double.Parse(txt_vunit.Text)
                vtotal = qtd * vunitario

                txt_vtotal.Text = vtotal.ToString("C")
            Catch ex As Exception
                MsgBox("Você precisa digitar números nas quantidades")
            End Try
        End If
    End Sub

    Private Sub atualizarSugestoes()
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

    Private Sub btn_cadastrar_passivo_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_passivo.Click
        cadastrarProduto(cmb_tipo_passivo, txt_nome_passivo, txt_desc_passivo, txt_qtd_passivo, txt_vunit_passivo,
                         "passivo", cmb_categoria_passivo)
    End Sub

    Private Sub cmb_tipo_ativo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_ativo.SelectedIndexChanged
        If cmb_tipo_ativo.SelectedIndex = 1 Then
            txt_vunit_ativo.Hide()
            lbl_vunit_ativo.Hide()
            txt_vtotal_ativo.Clear()
        Else
            txt_vunit_ativo.Show()
            lbl_vunit_ativo.Show()
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
                sql = "SELECT * FROM tb_produtos WHERE cnpj='" & cnpj & "' AND nome='" & txt_nome.Text & "'"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    id_entrada = rs.Fields("id_entrada").Value

                    sql = "INSERT INTO tb_entrada VALUES(" & id_entrada & ", " & txt_qtd.Text & ", " &
                          "" & txt_vunit.Text & ", " & vtotal & ", '" & grupoConta & "', " &
                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                    db.Execute(sql)

                    MsgBox("Produto inserido com sucesso!")
                Else
                    Dim lote, id As Integer

                    sql = "SELECT MAX(lote) AS maximoLote FROM tb_produtos WHERE cnpj='" & cnpj & "'"
                    rs = db.Execute(sql)
                    lote = rs.Fields("maximoLote").Value + 1

                    sql = "SELECT MAX(id_entrada) AS id FROM tb_produtos"
                    rs = db.Execute(sql)
                    id = rs.Fields("id").Value + 1

                    sql = "INSERT INTO tb_produtos VALUES('" & cnpj & "', " & lote & ", " & id & ", " & id & ", " &
                          "'" & txt_nome.Text & "', '" & txt_desc.Text & "', '" & cmb_categoria.Text & "')"
                    db.Execute(sql)

                    sql = "INSERT INTO tb_entrada VALUES(" & id & ", " & txt_qtd.Text & ", " &
                          "" & txt_vunit.Text & ", " & vtotal & ", '" & grupoConta & "', " &
                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                    db.Execute(sql)
                    atualizarSugestoes()

                    MsgBox("Produto inserido com sucesso!")
                End If
            End If
        Else
            'MsgBox("Venda (em desenvolvimento)")
            'Continuar aqui.
            'É necessário dar 3 insert... Um em PEPS, outro em UEPS e outro em Custo Médio

            '- Lógica:
            ' 1 - Verificar na tb_produtos o id do produto digitado

            ' 2 - Com o id do produto, fazer um laço para verificar e somar o campo "quantidade"
            ' enquanto existir produto com aquele id na cláusula WHERE

            ' 3 - Se a quantidade do produto for igual ou menor que zero, mostrar uma mensagem dizendo
            ' que não se pode vender aquele produto.

            ' 4 - Se a quantidade for válida, fazer a venda nos três métodos de estoque.

            ' MÉTODO PEPS:
            ' 5 - Verificar antes se a quantidade digitada é maior ou igual a quantidade existente em estoque.

            ' 6 - Enquanto a quantidade digitada for diferente de 0, retirar o primeiro produto encontrado no
            ' laço e descontar na variável de quantidade. Assim que retirar, fazer um insert no tb_saida_peps
            ' com as informações da quantidade retirada.
            If txt_nome.Text = Nothing Or txt_desc.Text = Nothing Or txt_qtd.Text = Nothing Then
                MsgBox("Preencha todos os campos")
            Else
                sql = "SELECT * FROM tb_produtos WHERE cnpj='" & cnpj & "' AND nome='" & txt_nome.Text & "'"
                rs = db.Execute(sql)

                If Not rs.EOF Then
                    Dim qtdEntrada, qtdSaida, qtdTotal, qtdDigitada As Integer

                    qtdDigitada = Integer.Parse(txt_qtd.Text)
                    id_saida = rs.Fields("id_saida").Value

                    sql = "SELECT sum(quantidade) FROM tb_entrada WHERE id_entrada=" & id_saida
                    rs = db.Execute(sql)
                    qtdEntrada = rs.Fields(0).Value

                    sql = "SELECT sum(quantidade) FROM tb_saida_media WHERE id_saida=" & id_saida
                    rs = db.Execute(sql)
                    qtdSaida = rs.Fields(0).Value

                    qtdTotal = qtdEntrada - qtdSaida

                    If qtdDigitada > qtdTotal Or qtdDigitada <= 0 Then
                        MsgBox("Você está tentando vender mais produtos do que o existente no estoque.")
                        Exit Sub
                    Else
                        ' AQUI ESTA ERRADO, MUDAR. CONTINUAR DAQUI...
                        sql = "SELECT * FROM tb_entrada WHERE id_entrada=" & id_saida
                        rs = db.Execute(sql)

                        Do While Not rs.EOF Or qtdDigitada = 0
                            qtdDigitada -= qtdTotal

                            sql = "INSERT INTO tb_saida_peps VALUES(" & id_saida & ", " & rs.Fields("quantidade").Value & "," &
                                "" & rs.Fields("valor_unitario").Value & ", " & rs.Fields("valor_total").Value & ", '" & grupoConta & "', " &
                                "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                            db.Execute(sql)
                            rs.MoveNext()
                        Loop

                        MsgBox("Vendido com sucesso!")
                    End If
                Else
                    MsgBox("Você não pode vender um produto que não existe.")
                End If
            End If
        End If
    End Sub
End Class