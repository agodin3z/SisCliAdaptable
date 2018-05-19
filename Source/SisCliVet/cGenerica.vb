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

    'Validar Numero con 2 decimales
    Shared Sub DosDecimales(ByVal Texto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim ch As Char = e.KeyChar
        If Texto.TextLength = 0 Then
            If Char.IsDigit(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            If Texto.TextLength < 7 Then
                If ch = Chr(46) And Texto.Text.IndexOf(".") <> -1 Then
                    e.Handled = True

                End If
                If Not Char.IsDigit(ch) And (ch <> Chr(8)) And (ch <> Chr(46)) Then
                    e.Handled = True
                End If
                If Char.IsDigit(ch) Or ch = "." Then
                    Dim result As String = Texto.Text.Substring(0, Texto.SelectionStart) _
                                           + e.KeyChar _
                                           + Texto.Text.Substring(Texto.SelectionStart + Texto.SelectionLength)
                    Dim parts() As String = result.Split(".")
                    If parts.Length > 1 Then
                        If parts(1).Length > 2 Then
                            e.Handled = True
                        End If
                    End If
                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    'Validar solo texto
    Shared Sub SoloTexto(ByVal Texto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Texto.TextLength < 50 Then
            If Char.IsLetter(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            ElseIf Char.IsSeparator(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    'Metodo para validar un TextBox con el formato del numero de Telefono
    Shared Sub Telefono(ByVal Texto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Texto.TextLength = 0 Then
            If e.KeyChar = "2" Or e.KeyChar = "7" Or e.KeyChar = "6" Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        Else
            If Texto.TextLength < 8 Then
                If Char.IsDigit(e.KeyChar) Then
                    e.Handled = False
                ElseIf Char.IsControl(e.KeyChar) Then
                    e.Handled = False
                Else
                    e.Handled = True
                End If
            ElseIf Char.IsControl(e.KeyChar) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If
    End Sub

    'Metodo para validar un TextBox con el formato de solo numeros
    Shared Sub SoloNumeros(ByVal Texto As Windows.Forms.TextBox, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
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
