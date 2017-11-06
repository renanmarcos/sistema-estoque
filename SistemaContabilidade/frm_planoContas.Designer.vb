<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_planoContas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Ativo Circulante")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Passivo")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Receitas Com Vendas")
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Custos com mercadorias vendidas")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Receitas/Despesas", New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode4})
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SuspendLayout()
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(12, 12)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "ativo_circulante"
        TreeNode1.Text = "Ativo Circulante"
        TreeNode2.Name = "passivo"
        TreeNode2.Text = "Passivo"
        TreeNode3.Name = "receitas_vendas"
        TreeNode3.Text = "Receitas Com Vendas"
        TreeNode4.Name = "custos"
        TreeNode4.Text = "Custos com mercadorias vendidas"
        TreeNode5.Name = "receitas"
        TreeNode5.Text = "Receitas/Despesas"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2, TreeNode5})
        Me.TreeView1.Size = New System.Drawing.Size(688, 457)
        Me.TreeView1.TabIndex = 0
        '
        'frm_planoContas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 481)
        Me.Controls.Add(Me.TreeView1)
        Me.Name = "frm_planoContas"
        Me.Text = "frm_planoContas"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TreeView1 As TreeView
End Class
