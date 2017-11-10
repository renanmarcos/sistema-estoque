Public Class frm_planoContas

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        If TreeView1.SelectedNode.Name = "ativo" Then
            tab_cadastro.SelectTab(1)
        End If

        If TreeView1.SelectedNode.Name = "passivo" Then
            tab_cadastro.SelectTab(0)
        End If
    End Sub
End Class