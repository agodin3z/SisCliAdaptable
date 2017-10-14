Imports System.Data
Imports System.Data.SqlClient

Public Class cConexion

    'cadena de conexion con la base de datos
    'atributo que tendra la conexion con la base de datos
    Private cn As SqlConnection
    'da es un sqldataadapter encargado de ejecutra sentencias SQL
    Private da As SqlDataAdapter
    'agregar un sqlcommand
    Private comando As SqlCommand

    'constructor encargado de conectar con la base de datos
    Sub New()

        Dim cadena As String
        Dim servidor As String = "."
        Dim db As String = "SISCLIAD_Vet"
        cadena = "Data source=" & servidor & ";initial catalog=" & db & ";Integrated Security=True"
        cn = New SqlConnection(cadena)

    End Sub

    'funcion que retorna una consulta general de cualquier tabla de la base de datos
    Public Function consultaGeneral(ByVal tabla As String) As DataTable

        Dim sql As String = "SELECT * FROM " & tabla
        da = New SqlDataAdapter(sql, cn)
        Dim dsa As New DataSet
        da.Fill(dsa, tabla)
        Return dsa.Tables(0)

    End Function

    Public Function ValidarDatos(ByVal campos As String, ByVal tabla As String, ByVal condicion As String) As DataTable

        Dim sql As String = "SELECT " & campos & " FROM " & tabla & " WHERE " & condicion
        da = New SqlDataAdapter(sql, cn)
        Dim dsa As New DataSet
        da.Fill(dsa, tabla)
        Return dsa.Tables(0)

    End Function

    Public Function consultaCondicionada(ByVal tabla As String, ByVal condicion As String) As DataTable

        Dim sql As String = "SELECT * FROM " & tabla & " WHERE " & condicion
        da = New SqlDataAdapter(sql, cn)
        Dim dsa As New DataSet
        da.Fill(dsa, tabla)
        Return dsa.Tables(0)

    End Function

    'Consulta para mandar a llamar campos con variables, y unirlos con las demas tablas de las bases de datos
    'Usado en: la mayoria de los formularios con datagridview
    Public Function consultaCondicionadas(ByVal campos As String, ByVal tabla As String, ByVal innerjoin As String, ByVal condicion As String) As DataTable

        Dim sql As String = "SELECT " & campos & " FROM " & tabla & " " & innerjoin & " " & condicion
        da = New SqlDataAdapter(sql, cn)
        Dim dsa As New DataSet
        da.Fill(dsa, tabla)
        Return dsa.Tables(0)

    End Function

    'Funcion temporal para validar la existencia de un usuario y al nuevo sumarle un +1 si existe"
    Public Function Correlativo(ByVal campo As String, ByVal tabla As String, ByVal condicion As String) As Integer

        Dim sql As String = "SELECT COUNT(" & campo & ") + 1 FROM " & tabla & " " & condicion
        cn.Open()
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = Integer.Parse(comando.ExecuteScalar)
        cn.Close()
        Return i

    End Function

    'Regresa el dato de si el campo que se intenta ingresar ya existe
    'Usado en: vetUsuarios
    Public Function consultaExistente(ByVal tabla As String, ByVal condicion As String) As Integer

        Dim sql As String = "SELECT COUNT(*) FROM " & tabla & " WHERE " & condicion
        cn.Open()
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = Integer.Parse(comando.ExecuteScalar)
        cn.Close()
        Return i

    End Function

    'funcion para agregar datos en cualquier tabla
    Public Function InsertarFila(ByVal tabla As String, ByVal campos As String, ByVal valores As String) As Integer

        Dim sql As String
        sql = "INSERT INTO " & tabla & " " & campos & " VALUES (" & valores & ")"
        cn.Open()
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = comando.ExecuteNonQuery
        cn.Close()
        Return i

    End Function

    'eliminar registros de cualquier tabla
    Public Function eliminar(ByVal tabla As String, ByVal condicion As String) As Integer

        Dim sql As String
        sql = "DELETE FROM " & tabla & " WHERE " & condicion
        cn.Open()
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = comando.ExecuteNonQuery
        cn.Close()
        Return i

    End Function

    'consulta filtrada para poder modificar
    Public Function consultaFiltrada(ByVal tabla As String, ByVal condicion As String) As DataTable

        Dim sql As String
        sql = "SELECT * FROM " & tabla & " WHERE " & condicion
        da = New SqlDataAdapter(sql, cn)
        Dim dsa As New DataSet
        da.Fill(dsa, tabla)
        Return dsa.Tables(0)

    End Function

    'actualizar registros de cualquier tabla
    Public Function actualizar(ByVal tabla As String, ByVal NuevosV As String, ByVal condicion As String) As Integer

        Dim sql As String
        sql = "UPDATE " & tabla & " SET " & NuevosV & " WHERE " & condicion
        cn.Open()
        comando = New SqlCommand(sql, cn)
        Dim i As Integer = comando.ExecuteNonQuery
        cn.Close()
        Return i

    End Function

End Class

