Public Class frm_menu
    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        frm_cadastro.Show()
    End Sub

    Private Sub ListarContasAtivasbloqueadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarContasAtivasbloqueadasToolStripMenuItem.Click
        frm_manutencao.Show()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
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
        lbl_empresa.Text = "Empresa: " & nome_fantasia
        lbl_cnpj.Text = "CNPJ: " & cnpj
    End Sub

    Private Sub PlanoDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlanoDeContasToolStripMenuItem.Click
        frm_planoContas.Show()
    End Sub

    Private Sub RelatórioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioToolStripMenuItem.Click
        frm_relatorio.Show()
    End Sub
End Class