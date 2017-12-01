Public Class frm_rel_view
    Public relHTML As String

    Private Sub frm_rel_view_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        wb_rel_view.DocumentText = relHTML
    End Sub
End Class