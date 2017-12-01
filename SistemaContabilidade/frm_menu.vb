Public Class frm_menu
    Private Sub CadastroDeContasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastroDeContasToolStripMenuItem.Click
        frm_cadastro.Show()
        Me.Close()
    End Sub

    Private Sub ListarContasAtivasbloqueadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarContasAtivasbloqueadasToolStripMenuItem.Click
        frm_manutencao.Show()
        Me.Close()
    End Sub

    Private Sub CadastroDeClientesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frm_cadastro.Show()
        Me.Close()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        frm_login.Show()
        Me.Close()
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
        Me.Close()
    End Sub

    Private Sub RelatórioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatórioToolStripMenuItem.Click
        frm_relatorio.Show()
    End Sub

    Private Sub EstoqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstoqueToolStripMenuItem.Click
        If tipo_conta = "Administrador" Then
            MsgBox("Não é permitido ao Administrador cadastrar produtos.")
        Else
            frm_estoque.Show()
            Me.Close()
        End If
    End Sub
End Class