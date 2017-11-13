Module modulo_principal
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, tipo_conta, usuario As String
    Public conexao = Application.StartupPath & "\banco\maindb.mdb"

    Sub conecta_banco()
        Try
            db = CreateObject("ADODB.Connection")
            db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & conexao)
        Catch ex As Exception
            MsgBox("Conexão com banco falhou!")
        End Try
    End Sub

    Sub primeira_listagem()
        With frm_manutencao.dgv_dados
            Dim cont As Integer
            .Rows.Clear()
            sql = "SELECT * FROM tb_login WHERE status_conta='ativa' ORDER BY usuario"
            rs = db.Execute(sql)
            cont = 1
            Do While rs.EOF = False
                .Rows.Add(cont, rs.Fields(1).Value, rs.Fields(6).Value, Nothing, Nothing, Nothing)
                rs.MoveNext()
                cont = cont + 1
            Loop
        End With
    End Sub
    Sub Limpar()
        With frm_cadastro
            .txt_email.Clear()
            .txt_repetir.Clear()
            .txt_resposta.Clear()
            .txt_senha.Clear()
            .txt_usuario.Clear()
            .cmb_perguntas.Text = Nothing
            .cmb_tipo.Text = Nothing
            .cb_visualizar.Checked = False
        End With
        With frm_login
            .txt_senha.Clear()
            .txt_usuario.Clear()
            .cmb_nivel.Text = Nothing
        End With
        With frm_digitacao
            .txt_credito.Clear()
            .txt_debito.Clear()
            .txt_desc.Clear()
            .txt_nome.Clear()
            .txt_quant.Clear()
            .txt_valor_total.Clear()
            .txt_valor_unitario.Clear()
        End With
        With frm_manutencao
            .txt_parametros.Clear()
            .cmb_selecione.Text = Nothing
            .rd_ativas.Checked = False
            .rd_bloqueadas.Checked = False
            .rd_todas.Checked = False
        End With
        With frm_recuperar
            .txt_resposta.Clear()
            .txt_usuario.Clear()
            .cmb_perguntas.Text = Nothing
        End With
        With frm_relatorio
            .cmb_metodo.Text = Nothing
            .cb_inicio.Checked = False
        End With
    End Sub
End Module
