Imports Microsoft.VisualBasic

Public Class cGenerica

    Shared Sub showFrm(ByVal frm As Windows.Forms.Form, ByVal padre As Windows.Forms.Form)
        frm.MdiParent = padre
        frm.Show()
    End Sub

    Shared Sub ShowDlg(ByVal frm As Windows.Forms.Form, ByVal padre As Windows.Forms.Form)
        frm.ShowDialog(padre)
    End Sub

    'Sistema de "Login" Temporal
    Shared Property mUser As Integer = 0
    Shared Property oUser As Integer = 0
    Shared Property vUser As Integer = 0
    Public Sub user(ByVal a As String, ByVal u As Integer)
        If a = "m" Then
            mUser = u
        ElseIf a = "o" Then
            oUser = u
        ElseIf a = "v" Then
            vUser = u
        End If
    End Sub
End Class
