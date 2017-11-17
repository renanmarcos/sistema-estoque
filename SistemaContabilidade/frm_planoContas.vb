Public Class frm_planoContas
    Dim sugestoes As New AutoCompleteStringCollection
    Dim id_entrada As Integer
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
        atualizarSugestoes()
    End Sub

    Private Sub btn_cadastrar_ativo_Click(sender As Object, e As EventArgs) Handles btn_cadastrar_ativo.Click
        If tab_cadastro.SelectedTab Is tab_ativo Then
            If cmb_tipo_ativo.SelectedItem = "Compra" Then

                sql = "SELECT * FROM tb_produtos WHERE cnpj='" & cnpj & "' AND nome='" & txt_nome_ativo.Text & "'"
                rs = db.Execute(sql)

                If rs.EOF = False Then
                    id_entrada = rs.Fields("id_entrada").Value

                    sql = "INSERT INTO tb_entrada VALUES(" & id_entrada & ", " & txt_qtd_ativo.Text & ", " &
                          "" & txt_vunit_ativo.Text & ", " & vtotal & ", 'ativo', " &
                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                    db.Execute(sql)
                Else
                    Dim lote, id As Integer

                    sql = "SELECT MAX(lote) AS maximoLote FROM tb_produtos WHERE cnpj='" & cnpj & "'"
                    rs = db.Execute(sql)
                    lote = rs.Fields("maximoLote").Value + 1

                    sql = "SELECT MAX(id_entrada) AS id FROM tb_produtos"
                    rs = db.Execute(sql)
                    id = rs.Fields("id").Value + 1

                    sql = "INSERT INTO tb_produtos VALUES('" & cnpj & "', " & lote & ", " & id & ", " & id & ", " &
                          "'" & txt_nome_ativo.Text & "', '" & txt_desc_ativo.Text & "', '" & txt_tipo_ativo.Text & "')"
                    db.Execute(sql)

                    sql = "INSERT INTO tb_entrada VALUES(" & id & ", " & txt_qtd_ativo.Text & ", " &
                          "" & txt_vunit_ativo.Text & ", " & vtotal & ", 'ativo', " &
                          "'" & DateTime.Now.ToString("dd/MM/yyyy") & "', '" & DateTime.Now.ToString("HH:mm:00") & "')"
                    db.Execute(sql)

                    atualizarSugestoes()

                End If
            End If
        End If
    End Sub

    Private Sub txt_nome_ativo_LostFocus(sender As Object, e As EventArgs) Handles txt_nome_ativo.LostFocus
        sql = "SELECT * FROM tb_produtos WHERE nome='" & txt_nome_ativo.Text & "' AND cnpj='" & cnpj & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            txt_desc_ativo.Text = rs.Fields("descricao").Value
            txt_tipo_ativo.Text = rs.Fields("tipo").Value
            txt_desc_ativo.Enabled = False
            txt_tipo_ativo.Enabled = False
        Else
            txt_desc_ativo.Enabled = True
            txt_tipo_ativo.Enabled = True
            txt_desc_ativo.Text = Nothing
            txt_tipo_ativo.Text = Nothing
            txt_desc_ativo.Focus()
        End If
    End Sub

    Private Sub txt_nome_passivo_LostFocus(sender As Object, e As EventArgs) Handles txt_nome_passivo.LostFocus
        sql = "SELECT * FROM tb_produtos WHERE nome='" & txt_nome_ativo.Text & "' AND cnpj='" & cnpj & "'"
        rs = db.Execute(sql)

        If rs.EOF = False Then
            txt_desc_passivo.Text = rs.Fields("descricao").Value
            txt_tipo_passivo.Text = rs.Fields("tipo").Value
            txt_desc_passivo.Enabled = False
            txt_tipo_passivo.Enabled = False
        Else
            txt_desc_passivo.Enabled = True
            txt_tipo_passivo.Enabled = True
            txt_desc_passivo.Text = Nothing
            txt_tipo_passivo.Text = Nothing
            txt_desc_passivo.Focus()
        End If
    End Sub

    Private Sub txt_vunit_ativo_LostFocus(sender As Object, e As EventArgs) Handles txt_vunit_ativo.LostFocus
        calcularTotal("ativo")
    End Sub

    Private Sub txt_qtd_ativo_LostFocus(sender As Object, e As EventArgs) Handles txt_qtd_ativo.LostFocus
        calcularTotal("ativo")
    End Sub

    Private Sub txt_qtd_passivo_LostFocus(sender As Object, e As EventArgs) Handles txt_qtd_passivo.LostFocus
        calcularTotal("passivo")
    End Sub

    Private Sub txt_vunit_passivo_LostFocus(sender As Object, e As EventArgs) Handles txt_vunit_passivo.LostFocus
        calcularTotal("passivo")
    End Sub

    Private Sub calcularTotal(tipo As String)
        If tipo = "ativo" Then
            If Not (txt_qtd_ativo.Text = Nothing Or txt_vunit_ativo.Text = Nothing) Then
                Try
                    qtd = Double.Parse(txt_qtd_ativo.Text)
                    vunitario = Double.Parse(txt_vunit_ativo.Text)
                    vtotal = qtd * vunitario

                    txt_vtotal_ativo.Text = vtotal.ToString("C")
                Catch ex As Exception
                    MsgBox("Você precisa digitar números nas quantidades")
                End Try
            End If
        Else
            If Not (txt_qtd_passivo.Text = Nothing Or txt_vunit_passivo.Text = Nothing) Then
                Try
                    qtd = Double.Parse(txt_qtd_passivo.Text)
                    vunitario = Double.Parse(txt_vunit_passivo.Text)
                    vtotal = qtd * vunitario

                    txt_vtotal_passivo.Text = vtotal.ToString("C")
                Catch ex As Exception
                    MsgBox("Você precisa digitar números nas quantidades")
                End Try
            End If
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
End Class