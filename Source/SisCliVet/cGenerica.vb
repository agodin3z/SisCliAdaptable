Imports Microsoft.VisualBasic

Public Class cGenerica

    Shared Sub showFrm(ByVal frm As Windows.Forms.Form, ByVal padre As Windows.Forms.Form)
        frm.MdiParent = padre
        frm.Show()
    End Sub

    Shared Sub ShowDlg(ByVal frm As Windows.Forms.Form, ByVal padre As Windows.Forms.Form)
        frm.ShowDialog(padre)
    End Sub

    Shared Sub limpiarTextbox(ByVal grupo As Windows.Forms.GroupBox)
        For Each control As Control In grupo.Controls
            If TypeOf control Is Windows.Forms.TextBox Then
                control.Text = ""
            End If
        Next
    End Sub

    'Sistema de "Login" Temporal
    ' Valor 0: No hay sesion iniciada
    ' Valor 1: Sesion iniciada por Admin
    ' Valor 2: Sesion iniciada por Medico
    Shared Property usr As String = ""
    Shared Property mUser As Integer = 0 'Medicina General
    Shared Property vUser As Integer = 0 'Veterinaria
    Shared Property uErr As Integer = 1 'Manejo de Error de Sesion
    Shared Property uExit As Integer = 0 'Manejo de Salir durante login
    'FIN Sistema Temporal de Login
End Class
