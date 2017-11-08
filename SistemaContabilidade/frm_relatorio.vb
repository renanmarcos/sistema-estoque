Public Class frm_relatorio
    Private Sub frm_relatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmb_metodo.SelectedIndex = 0
    End Sub

    Private Sub btn_gerar_Click(sender As Object, e As EventArgs) Handles btn_gerar.Click

    End Sub

    Private Sub cb_inicio_CheckedChanged(sender As Object, e As EventArgs) Handles cb_inicio.CheckedChanged
        If cb_inicio.Checked Then
            dtp_inicio.Enabled = False
            dtp_final.Enabled = False
        Else
            dtp_inicio.Enabled = True
            dtp_final.Enabled = True
        End If
    End Sub
End Class