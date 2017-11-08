<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_rel_view
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
        Me.wb_rel_view = New System.Windows.Forms.WebBrowser()
        Me.SuspendLayout()
        '
        'wb_rel_view
        '
        Me.wb_rel_view.Dock = System.Windows.Forms.DockStyle.Fill
        Me.wb_rel_view.IsWebBrowserContextMenuEnabled = False
        Me.wb_rel_view.Location = New System.Drawing.Point(0, 0)
        Me.wb_rel_view.MinimumSize = New System.Drawing.Size(20, 20)
        Me.wb_rel_view.Name = "wb_rel_view"
        Me.wb_rel_view.Size = New System.Drawing.Size(682, 428)
        Me.wb_rel_view.TabIndex = 0
        '
        'frm_rel_view
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 428)
        Me.Controls.Add(Me.wb_rel_view)
        Me.Name = "frm_rel_view"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Relatório produto x"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents wb_rel_view As WebBrowser
End Class
