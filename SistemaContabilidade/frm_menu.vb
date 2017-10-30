Public Class frm_menu
    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        frm_cadastro.Show()
    End Sub

    Private Sub ListarContasAtivasbloqueadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarContasAtivasbloqueadasToolStripMenuItem.Click
        frm_manutencao.Show()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeClientesToolStripMenuItem.Click
        frm_cadastro.Show()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        Me.Close()
        frm_login.Show()
    End Sub

    Private Sub EncerrarSistemaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSistemaToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub frm_menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If tipo_conta = "Usuário" Then
            ManutençãoDeContasToolStripMenuItem.Visible = False
        End If
    End Sub
End Class