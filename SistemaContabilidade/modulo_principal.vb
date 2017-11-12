Module modulo_principal
    Public db As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public sql, tipo_conta, usuario, cnpj, nome_fantasia As String
    Public lote As Integer
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
End Module
