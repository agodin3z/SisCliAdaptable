Imports System.Data
Imports System.Data.SqlClient

Public Class cConexion
    Private con As SqlConnection 'Cadena de conexion con la base de datos
    Private da As SqlDataAdapter 'Encargado de ejecutar sentencias SQL
    Private comando As SqlCommand

    'Encargado de conectar con la base de datos
    Sub New()
        Dim servidor As String = "."
        Dim db As String = "SISCLIAD_Med"
        Dim cadena As String = "Data Source=" & servidor & ";Initial Catalog=" & db & ";Integrated Security=True"
        con = New SqlConnection(cadena)
    End Sub

    'Ejecuta cualquier accion de consulta
    Private Function consultar(ByVal sql As String, ByVal tabla As String) As DataTable
        da = New SqlDataAdapter(sql, con)
        Dim dset As New DataSet
        da.Fill(dset, tabla)
        Return dset.Tables(0)
    End Function

    'Ejecuta cualquier comando de mantenimiento de tablas
    Private Function mantenimiento(ByVal sql As String) As Integer
        con.Open()
        comando = New SqlCommand(sql, con)
        Dim i As Integer = comando.ExecuteNonQuery
        con.Close()
        Return i
    End Function

    'Ejecuta cualquier accion de obtener un valor Integer
    Private Function obtener(ByVal sql As String)
        con.Open()
        comando = New SqlCommand(sql, con)
        Dim i = comando.ExecuteScalar
        con.Close()
        Return i
    End Function

    'Funcion que retorna una consulta general de cualquier tabla
    Public Function consultaGeneral(ByVal tabla As String) As DataTable
        Dim sql As String = "SELECT * FROM " & tabla
        Return consultar(sql, tabla)
    End Function

    'Funcion que retorna una consulta condicionada de cualquier tabla
    Public Function consultaCondicionada(ByVal tabla As String, ByVal condicion As String) As DataTable
        Dim sql As String = "SELECT * FROM " & tabla & " WHERE " & condicion
        Return consultar(sql, tabla)
    End Function
    
    'Consulta para mandar a llamar campos con variables, y unirlos con las demas tablas
    Public Function consultaCondicionada(ByVal campos As String, ByVal tabla As String, ByVal innerjoin As String, ByVal condicion As String) As DataTable
        Dim sql As String = "SELECT " & campos & " FROM " & tabla & " " & innerjoin & " " & condicion
        Return consultar(sql, tabla)
    End Function

    'Consulta para mandar a llamar campos con variables, y unirlos con las demas tablas
    Public Function consultaCondicionada(ByVal campos As String, ByVal tabla As String, ByVal innerjoin As String) As DataTable
        Dim sql As String = "SELECT " & campos & " FROM " & tabla & " " & innerjoin
        Return consultar(sql, tabla)
    End Function

    'Valida datos
    Public Function validarDatos(ByVal campos As String, ByVal tabla As String, ByVal condicion As String) As DataTable
        Dim sql As String = "SELECT " & campos & " FROM " & tabla & " WHERE " & condicion
        Return consultar(sql, tabla)
    End Function

    'Validar la existencia de un usuario y al nuevo sumarle un +1 si existe
    Public Function correlativo(ByVal campo As String, ByVal tabla As String, ByVal condicion As String) As Integer
        Dim sql As String = "SELECT COUNT(" & campo & ") + 1 FROM " & tabla & " WHERE " & condicion
        Return obtener(sql)
    End Function

    'Verifica si el dato ya existe
    Public Function consultaExistente(ByVal tabla As String, ByVal condicion As String) As Integer
        Dim sql As String = "SELECT COUNT(*) FROM " & tabla & " WHERE " & condicion
        Return obtener(sql)
    End Function

    'Obtiene un valor de cualquier tabla
    Public Function consultaExistente(ByVal campo As String, ByVal tabla As String, ByVal condicion As String)
        Dim sql As String = "SELECT " & campo & " FROM " & tabla & " WHERE " & condicion
        Return obtener(sql)
    End Function

    'Agregar datos en cualquier tabla indicando el/los campos
    Public Function insertar(ByVal tabla As String, ByVal campos As String, ByVal valores As String) As Integer
        Dim sql As String = "INSERT INTO " & tabla & " (" & campos & ") VALUES (" & valores & ")"
        Return mantenimiento(sql)
    End Function

    'Agregar datos en cualquier tabla 
    Public Function insertar(ByVal tabla As String, ByVal valores As String) As Integer
        Dim sql As String = "INSERT INTO " & tabla & " VALUES (" & valores & ")"
        Return mantenimiento(sql)
    End Function

    'Eliminar registros de cualquier tabla
    Public Function eliminar(ByVal tabla As String, ByVal condicion As String) As Integer
        Dim sql As String = "DELETE FROM " & tabla & " WHERE " & condicion
        Return mantenimiento(sql)
    End Function

    'Actualizar registros de cualquier tabla
    Public Function actualizar(ByVal tabla As String, ByVal NuevosV As String, ByVal condicion As String) As Integer
        Dim sql As String = "UPDATE " & tabla & " SET " & NuevosV & " WHERE " & condicion
        Return mantenimiento(sql)
    End Function
    Public Function actualizar(ByVal tabla As String, ByVal campo As String, ByVal id As String, ByVal valId As String, ByVal img As Byte())
        con.Open()
        comando.CommandText = "UPDATE " & tabla & " SET " & campo & "=@foto WHERE " & id & "='" & valId & "'"
        comando.Connection = con
        comando.Parameters.Add("@foto", System.Data.SqlDbType.Image)
        comando.Parameters("@foto").Value = img
        Dim i = comando.ExecuteNonQuery()
        con.Close()
        Return i
    End Function

    Public Function selectImg(ByVal tabla As String, ByVal campo As String, ByVal condicion As String) As Byte()
        comando = New SqlCommand
        con.Open()
        comando.CommandText = "SELECT " & campo & " FROM " & tabla & " " & condicion
        comando.Connection = con
        Dim imagen As Byte() = CType(comando.ExecuteScalar(), Byte())
        con.Close()
        Return imagen
    End Function
End Class