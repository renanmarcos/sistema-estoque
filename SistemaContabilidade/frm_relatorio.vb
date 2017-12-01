Public Class frm_relatorio
    Public relHTML As String = ""

    Private Sub frm_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_metodo.SelectedIndex = 0

        sql = "SELECT nome FROM tb_produtos WHERE cnpj = '" & cnpj & "'"
        rs = db.Execute(sql)

        If Not rs.EOF Then
            While Not rs.EOF
                lst_produtos.Items.Add(rs.Fields(0).Value)
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

        relHTML = "<html><head>
        <meta http-equiv='X-UA-Compatible' content='IE=edge'>
		<style type='text/css'>
		    body{font-family: Arial, Helvetica, sans-serif; margin: 0px; padding: 0px}
		    table{text-align: center;width: 100%;border-color: #333;font-size: 16px;}
		    #tr-title{font-weight: 600;background-color: #eee;font-size: 14px;}
		    #tr-info{background-color: #ccc;font-size: 16px;}
		    #tr-info2{background-color: #bbb;font-weight: 600;font-size: 12px;}
		    tr{font-size: 14px;}
            .gray-td{background-color: #eee;}
		</style>
	    </head><body><table border='1' cellspacing='0' cellpadding='10px'>
		<!--<tr id='tr-title'><td colspan='10'>" & lst_produtos.SelectedItem.ToString & " - Relatório " & cmb_metodo.Text & "</td></tr>-->
		<tr id='tr-info'><td rowspan='2'>DATA</td><td colspan='3'>ENTRADA</td><td colspan='3'>SAÍDA</td><td colspan='3'>SALDO</td></tr>
		<tr id='tr-info2'><td>QTD</td><td>PREÇO UNIT.</td><td>VALOR TOTAL</td><td>QTD</td><td>PREÇO UNIT.</td><td>VALOR TOTAL</td><td>QTD</td><td>PREÇO UNIT.</td><td>VALOR TOTAL</td></tr>"

        sql = "SELECT id FROM tb_produtos WHERE nome = '" & lst_produtos.SelectedItem & "' AND cnpj = '" & cnpj & "'"
        rs = db.Execute(sql)

        Select Case cmb_metodo.SelectedIndex
            Case 0
                gerarPEPS(rs.Fields(0).Value)
            Case 1
                gerarUEPS(rs.Fields(0).Value)
            Case 2
                gerarMP(rs.Fields(0).Value)
        End Select

        relHTML += "</table></body></html>"

        frm_rel_view.Text = "Relatório " & cmb_metodo.SelectedItem & " de " & lst_produtos.SelectedItem
        frm_rel_view.relHTML = relHTML
        frm_rel_view.ShowDialog()
    End Sub

    Public Sub gerarPEPS(idProd As Integer)
        'Coleção para saldo
        Dim saldo As New ArrayList

        'RecordSet's e querys
        Dim rsEntrada, rsSaida As New ADODB.Recordset
        sql = "SELECT data_entrada, hora_entrada, quantidade, valor_unitario, valor_total FROM tb_entrada WHERE id = " & idProd & " ORDER BY data_entrada, hora_entrada"
        rsEntrada = db.Execute(sql)
        'sql = "SELECT data_saida, hora_saida, quantidade, valor_unitario, valor_total FROM tb_saida_peps WHERE id = " & idProd & " ORDER BY data_saida, hora_saida" 'Ignora essa linha
        sql = "SELECT MIN(data_saida) AS data, MIN(hora_saida) AS hora, SUM(quantidade) AS qtd, SUM(valor_unitario) AS vunit, SUM(valor_total) AS vtotal FROM tb_saida_peps WHERE id = " & idProd & " GROUP BY id, data_saida"
        rsSaida = db.Execute(sql)

        'Nmero de registros
        Dim RecordCount As Integer = rsEntrada.RecordCount
        If rsEntrada.RecordCount < rsSaida.RecordCount Then
            RecordCount = rsSaida.RecordCount
        End If

        While Not rsEntrada.EOF Or Not rsSaida.EOF

            'Datas
            Dim dataEntrada, dataSaida As DateTime
            If rsEntrada.EOF Then
                dataEntrada = DateTime.MaxValue
            Else
                dataEntrada = DateTime.Parse(rsEntrada.Fields(0).Value & " " & rsEntrada.Fields(1).Value, New Globalization.CultureInfo("pt-BR"), Globalization.DateTimeStyles.NoCurrentDateDefault)
            End If
            If rsSaida.EOF Then
                dataSaida = DateTime.MaxValue
            Else
                dataSaida = DateTime.Parse(rsSaida.Fields(0).Value & " " & rsSaida.Fields(1).Value, New Globalization.CultureInfo("pt-BR"), Globalization.DateTimeStyles.NoCurrentDateDefault)
            End If

            relHTML += "<tr>"
            If dataEntrada <= dataSaida Then 'Primeiro vem entrada
                'Adiciona no saldo
                saldo.Add(New Lote(rsEntrada.Fields(2).Value, rsEntrada.Fields(3).Value, rsEntrada.Fields(4).Value))

                'Calcula saldo total
                Dim qtds As String = "", valores As String = "", total As Double = 0D, precoUnit As Double = rsEntrada.Fields(3).Value, totalUnit As Double = rsEntrada.Fields(4).Value
                For Each l As Lote In saldo
                    qtds += l.qtd & "<br>"
                    valores += l.valor.ToString("C") & "<br>"
                    total += l.total
                Next

                relHTML += "
                <td>" & dataEntrada.ToShortDateString & "</td>
                <td>" & rsEntrada.Fields(2).Value & "</td><td>" & precoUnit.ToString("C") & "</td><td>" & totalUnit.ToString("C") & "</td>
                <td class='gray-td'></td><td class='gray-td'></td><td class='gray-td'></td>
                <td>" & qtds & "</td><td>" & valores & "</td><td>" & total.ToString("C") & "</td>"

                If Not rsEntrada.EOF Then
                    rsEntrada.MoveNext()
                End If
            Else 'Primeiro vem saída
                'Subtrai do saldo
                Dim qtdSaida As Integer = rsSaida.Fields(2).Value, lotesToRemove As ArrayList = New ArrayList, lotesSaida As ArrayList = New ArrayList
                For Each l As Lote In saldo
                    If qtdSaida = 0 Then
                        Exit For
                    End If
                    Dim loteSaida As Lote = New Lote(0, 0D, 0D)
                    If l.qtd < qtdSaida Then 'Remove da saída, lote some
                        qtdSaida -= l.qtd
                        lotesToRemove.Add(l)

                        loteSaida.qtd = l.qtd
                        loteSaida.valor = l.valor
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                    ElseIf l.qtd = qtdSaida Then 'Justo de um lote, lote some
                        lotesToRemove.Add(l)

                        loteSaida.qtd = l.qtd
                        loteSaida.valor = l.valor
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                    Else 'Remove do lote
                        l.qtd -= qtdSaida
                        l.recalculateTotal()

                        loteSaida.qtd = qtdSaida
                        loteSaida.valor = l.valor
                        qtdSaida = 0
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                        Exit For
                    End If
                Next

                For Each l As Lote In lotesToRemove
                    saldo.Remove(l)
                Next

                'Calcula saldo descontado
                Dim qtdDesc As String = "", valoresDesc As String = "", totalDesc As Double = 0D
                For Each l As Lote In lotesSaida
                    qtdDesc += l.qtd & "<br>"
                    valoresDesc += l.valor.ToString("C") & "<br>"
                    totalDesc += l.total
                Next


                'Calcula saldo total
                Dim qtds As String = "", valores As String = "", total As Double = 0D ', precoUnit As Double = rsSaida.Fields(3).Value, totalUnit As Double = rsSaida.Fields(4).Value
                For Each l As Lote In saldo
                    qtds += l.qtd & "<br>"
                    valores += l.valor.ToString("C") & "<br>"
                    total += l.total
                Next

                'gera HTML
                '<td>" & rsSaida.Fields(2).Value & "</td><td>" & precoUnit.ToString("C") & "</td><td>" & totalUnit.ToString("C") & "</td>
                relHTML += "
                <td>" & dataSaida.ToShortDateString & "</td>
                <td class='gray-td'></td><td class='gray-td'></td><td class='gray-td'></td>
                
                <td>" & qtdDesc & "</td><td>" & valoresDesc & "</td><td>" & totalDesc.ToString("C") & "</td>
                <td>" & qtds & "</td><td>" & valores & "</td><td>" & total.ToString("C") & "</td>"

                If Not rsSaida.EOF Then
                    rsSaida.MoveNext()
                End If
            End If
            relHTML += "</tr>"

        End While
    End Sub

    Public Sub gerarUEPS(idProd As Integer)
        'Coleção para saldo
        Dim saldo As New ArrayList

        'RecordSet's e querys
        Dim rsEntrada, rsSaida As New ADODB.Recordset
        sql = "SELECT data_entrada, hora_entrada, quantidade, valor_unitario, valor_total FROM tb_entrada WHERE id = " & idProd & " ORDER BY data_entrada, hora_entrada"
        rsEntrada = db.Execute(sql)
        'sql = "SELECT data_saida, hora_saida, quantidade, valor_unitario, valor_total FROM tb_saida_peps WHERE id = " & idProd & " ORDER BY data_saida, hora_saida" 'Ignora essa linha
        sql = "SELECT MIN(data_saida) AS data, MIN(hora_saida) AS hora, SUM(quantidade) AS qtd, SUM(valor_unitario) AS vunit, SUM(valor_total) AS vtotal FROM tb_saida_ueps WHERE id = " & idProd & " GROUP BY id, data_saida"
        rsSaida = db.Execute(sql)

        'Nmero de registros
        Dim RecordCount As Integer = rsEntrada.RecordCount
        If rsEntrada.RecordCount < rsSaida.RecordCount Then
            RecordCount = rsSaida.RecordCount
        End If

        While Not rsEntrada.EOF Or Not rsSaida.EOF

            'Datas
            Dim dataEntrada, dataSaida As DateTime
            If rsEntrada.EOF Then
                dataEntrada = DateTime.MaxValue
            Else
                dataEntrada = DateTime.Parse(rsEntrada.Fields(0).Value & " " & rsEntrada.Fields(1).Value, New Globalization.CultureInfo("pt-BR"), Globalization.DateTimeStyles.NoCurrentDateDefault)
            End If
            If rsSaida.EOF Then
                dataSaida = DateTime.MaxValue
            Else
                dataSaida = DateTime.Parse(rsSaida.Fields(0).Value & " " & rsSaida.Fields(1).Value, New Globalization.CultureInfo("pt-BR"), Globalization.DateTimeStyles.NoCurrentDateDefault)
            End If

            relHTML += "<tr>"
            If dataEntrada <= dataSaida Then 'Primeiro vem entrada
                'Adiciona no saldo
                saldo.Add(New Lote(rsEntrada.Fields(2).Value, rsEntrada.Fields(3).Value, rsEntrada.Fields(4).Value))

                'Calcula saldo total
                Dim qtds As String = "", valores As String = "", total As Double = 0D, precoUnit As Double = rsEntrada.Fields(3).Value, totalUnit As Double = rsEntrada.Fields(4).Value
                For Each l As Lote In saldo
                    qtds += l.qtd & "<br>"
                    valores += l.valor.ToString("C") & "<br>"
                    total += l.total
                Next

                relHTML += "
                <td>" & dataEntrada.ToShortDateString & "</td>
                <td>" & rsEntrada.Fields(2).Value & "</td><td>" & precoUnit.ToString("C") & "</td><td>" & totalUnit.ToString("C") & "</td>
                <td class='gray-td'></td><td class='gray-td'></td><td class='gray-td'></td>
                <td>" & qtds & "</td><td>" & valores & "</td><td>" & total.ToString("C") & "</td>"

                If Not rsEntrada.EOF Then
                    rsEntrada.MoveNext()
                End If
            Else 'Primeiro vem saída
                'Subtrai do saldo
                Dim qtdSaida As Integer = rsSaida.Fields(2).Value, lotesToRemove As ArrayList = New ArrayList, lotesSaida As ArrayList = New ArrayList
                saldo.Reverse()
                For Each l As Lote In saldo
                    If qtdSaida = 0 Then
                        Exit For
                    End If
                    Dim loteSaida As Lote = New Lote(0, 0D, 0D)
                    If l.qtd < qtdSaida Then 'Remove da saída, lote some
                        qtdSaida -= l.qtd
                        lotesToRemove.Add(l)

                        loteSaida.qtd = l.qtd
                        loteSaida.valor = l.valor
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                    ElseIf l.qtd = qtdSaida Then 'Justo de um lote, lote some
                        lotesToRemove.Add(l)

                        loteSaida.qtd = l.qtd
                        loteSaida.valor = l.valor
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                    Else 'Remove do lote
                        l.qtd -= qtdSaida
                        l.recalculateTotal()

                        loteSaida.qtd = qtdSaida
                        loteSaida.valor = l.valor
                        qtdSaida = 0
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                        Exit For
                    End If
                Next
                saldo.Reverse()

                For Each l As Lote In lotesToRemove
                    saldo.Remove(l)
                Next

                'Calcula saldo descontado
                Dim qtdDesc As String = "", valoresDesc As String = "", totalDesc As Double = 0D
                For Each l As Lote In lotesSaida
                    qtdDesc += l.qtd & "<br>"
                    valoresDesc += l.valor.ToString("C") & "<br>"
                    totalDesc += l.total
                Next


                'Calcula saldo total
                Dim qtds As String = "", valores As String = "", total As Double = 0D ', precoUnit As Double = rsSaida.Fields(3).Value, totalUnit As Double = rsSaida.Fields(4).Value
                saldo.Reverse()
                For Each l As Lote In saldo
                    qtds += l.qtd & "<br>"
                    valores += l.valor.ToString("C") & "<br>"
                    total += l.total
                Next
                saldo.Reverse()

                'gera HTML
                '<td>" & rsSaida.Fields(2).Value & "</td><td>" & precoUnit.ToString("C") & "</td><td>" & totalUnit.ToString("C") & "</td>
                relHTML += "
                <td>" & dataSaida.ToShortDateString & "</td>
                <td class='gray-td'></td><td class='gray-td'></td><td class='gray-td'></td>
                
                <td>" & qtdDesc & "</td><td>" & valoresDesc & "</td><td>" & totalDesc.ToString("C") & "</td>
                <td>" & qtds & "</td><td>" & valores & "</td><td>" & total.ToString("C") & "</td>"

                If Not rsSaida.EOF Then
                    rsSaida.MoveNext()
                End If
            End If
            relHTML += "</tr>"
        End While
    End Sub

    Public Sub gerarMP(idProd As Integer)
        'Coleção para saldo
        Dim saldo As New ArrayList

        'RecordSet's e querys
        Dim rsEntrada, rsSaida As New ADODB.Recordset
        sql = "SELECT data_entrada, hora_entrada, quantidade, valor_unitario, valor_total FROM tb_entrada WHERE id = " & idProd & " ORDER BY data_entrada, hora_entrada"
        rsEntrada = db.Execute(sql)
        sql = "SELECT data_saida, hora_saida, quantidade, valor_unitario, valor_total FROM tb_saida_media WHERE id = " & idProd & " ORDER BY data_saida, hora_saida"
        rsSaida = db.Execute(sql)

        'Nmero de registros
        Dim RecordCount As Integer = rsEntrada.RecordCount
        If rsEntrada.RecordCount < rsSaida.RecordCount Then
            RecordCount = rsSaida.RecordCount
        End If

        While Not rsEntrada.EOF Or Not rsSaida.EOF

            'Datas
            Dim dataEntrada, dataSaida As DateTime
            If rsEntrada.EOF Then
                dataEntrada = DateTime.MaxValue
            Else
                dataEntrada = DateTime.Parse(rsEntrada.Fields(0).Value & " " & rsEntrada.Fields(1).Value, New Globalization.CultureInfo("pt-BR"), Globalization.DateTimeStyles.NoCurrentDateDefault)
            End If
            If rsSaida.EOF Then
                dataSaida = DateTime.MaxValue
            Else
                dataSaida = DateTime.Parse(rsSaida.Fields(0).Value & " " & rsSaida.Fields(1).Value, New Globalization.CultureInfo("pt-BR"), Globalization.DateTimeStyles.NoCurrentDateDefault)
            End If

            relHTML += "<tr>"
            If dataEntrada <= dataSaida Then 'Primeiro vem entrada
                'Adiciona no saldo
                saldo.Add(New Lote(rsEntrada.Fields(2).Value, rsEntrada.Fields(3).Value, rsEntrada.Fields(4).Value))

                'Calcula saldo total
                Dim qtds As String = "", valores As String = "", total As Double = 0D, precoUnit As Double = rsEntrada.Fields(3).Value, totalUnit As Double = rsEntrada.Fields(4).Value
                For Each l As Lote In saldo
                    qtds += l.qtd & "<br>"
                    valores += l.valor.ToString("C") & "<br>"
                    total += l.total
                Next

                relHTML += "
                <td>" & dataEntrada.ToShortDateString & "</td>
                <td>" & rsEntrada.Fields(2).Value & "</td><td>" & precoUnit.ToString("C") & "</td><td>" & totalUnit.ToString("C") & "</td>
                <td class='gray-td'></td><td class='gray-td'></td><td class='gray-td'></td>
                <td>" & qtds & "</td><td>" & valores & "</td><td>" & total.ToString("C") & "</td>"

                If Not rsEntrada.EOF Then
                    rsEntrada.MoveNext()
                End If
            Else 'Primeiro vem saída
                'Subtrai do saldo
                Dim qtdSaida As Integer = rsSaida.Fields(2).Value, lotesToRemove As ArrayList = New ArrayList, lotesSaida As ArrayList = New ArrayList
                saldo.Reverse()
                For Each l As Lote In saldo
                    If qtdSaida = 0 Then
                        Exit For
                    End If
                    Dim loteSaida As Lote = New Lote(0, 0D, 0D)
                    If l.qtd < qtdSaida Then 'Remove da saída, lote some
                        qtdSaida -= l.qtd
                        lotesToRemove.Add(l)

                        loteSaida.qtd = l.qtd
                        loteSaida.valor = l.valor
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                    ElseIf l.qtd = qtdSaida Then 'Justo de um lote, lote some
                        lotesToRemove.Add(l)

                        loteSaida.qtd = l.qtd
                        loteSaida.valor = l.valor
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                    Else 'Remove do lote
                        l.qtd -= qtdSaida
                        l.recalculateTotal()

                        loteSaida.qtd = qtdSaida
                        loteSaida.valor = l.valor
                        qtdSaida = 0
                        loteSaida.recalculateTotal()
                        lotesSaida.Add(loteSaida)
                        Exit For
                    End If
                Next
                saldo.Reverse()

                For Each l As Lote In lotesToRemove
                    saldo.Remove(l)
                Next

                'Calcula saldo descontado
                Dim qtdDesc As String = "", valoresDesc As String = "", totalDesc As Double = 0D
                For Each l As Lote In lotesSaida
                    qtdDesc += l.qtd & "<br>"
                    valoresDesc += l.valor.ToString("C") & "<br>"
                    totalDesc += l.total
                Next

                'Calcula saldo total
                Dim qtds As String = "", valores As String = "", total As Double = 0D ', precoUnit As Double = rsSaida.Fields(3).Value, totalUnit As Double = rsSaida.Fields(4).Value
                saldo.Reverse()
                For Each l As Lote In saldo
                    qtds += l.qtd & "<br>"
                    valores += l.valor.ToString("C") & "<br>"
                    total += l.total
                Next
                saldo.Reverse()

                'gera HTML
                '<td>" & rsSaida.Fields(2).Value & "</td><td>" & precoUnit.ToString("C") & "</td><td>" & totalUnit.ToString("C") & "</td>
                relHTML += "
                <td>" & dataSaida.ToShortDateString & "</td>
                <td class='gray-td'></td><td class='gray-td'></td><td class='gray-td'></td>
                
                <td>" & qtdDesc & "</td><td>" & valoresDesc & "</td><td>" & totalDesc.ToString("C") & "</td>
                <td>" & qtds & "</td><td>" & valores & "</td><td>" & total.ToString("C") & "</td>"

                If Not rsSaida.EOF Then
                    rsSaida.MoveNext()
                End If
            End If
            relHTML += "</tr>"
        End While
    End Sub
End Class

Public Class Lote
    Public qtd As Integer
    Public valor As Double
    Public total As Double

    Public Sub New(qtd As Integer, valor As Double, total As Double)
        Me.qtd = qtd
        Me.valor = valor
        Me.total = total
    End Sub

    Public Sub recalculateTotal()
        Me.total = Me.qtd * Me.valor
    End Sub
End Class
