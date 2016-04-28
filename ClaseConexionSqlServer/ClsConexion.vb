'****************************************'
' Creador: Jose Angel Flores Garcia      '
' Modulo: Clase Conexion a SqlServer     '
'****************************************'

Option Strict Off

Imports Microsoft.VisualBasic
Imports System
Imports System.Data.SqlClient

Public Class ClsConexion
    Private _Servidor As String
    Private _BaseDatos As String
    Private _Usuario As String
    Private _Clave As String
    Private AuxConexion As String
    Private MiConexion As SqlConnection
    Private MiComando As SqlCommand
    Private _Regis As SqlDataReader
    Private _AuxSql As String


    Public Property Servidor As String
        Get
            Return _Servidor
        End Get
        Set(ByVal Value As String)
            If (_Servidor <> Value) Then
                _Servidor = Value
            End If
        End Set
    End Property

    Public Property BaseDatos As String
        Get
            Return _BaseDatos
        End Get
        Set(ByVal Value As String)
            If (_BaseDatos <> Value) Then
                _BaseDatos = Value
            End If
        End Set
    End Property

    Public Property Usuario As String
        Get
            Return _Usuario
        End Get
        Set(ByVal Value As String)
            If (_Usuario <> Value) Then
                _Usuario = Value
            End If
        End Set
    End Property

    Public WriteOnly Property Clave As String
        Set(ByVal Value As String)
            If (_Clave <> Value) Then
                _Clave = Value
            End If
        End Set
    End Property

    Public Property AuxSql As String
        Get
            Return _AuxSql
        End Get
        Set(ByVal Value As String)
            If (_AuxSql <> Value) Then
                _AuxSql = Value
            End If
        End Set
    End Property

    Public ReadOnly Property Regis As SqlDataReader
        Get
            Return _Regis
        End Get
    End Property

    Public Sub Conectar()
        AuxConexion = "Data Source = " & _Servidor.Trim & _
                      "; Initial Catalog = " & _BaseDatos.Trim & _
                      "; User Id = " & _Usuario.Trim & _
                      "; Pwd = " & _Clave.Trim & _
                      "; Integrated Security = False"

        miConexion = New SqlConnection(AuxConexion)

        Try
            MiConexion.Open()            
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    Public Sub Desconectar()
        Try
            miConexion.Close()
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    Public Sub Ejecutar()
        Try
            miComando = New SqlCommand(_AuxSql, miConexion)
            miComando.ExecuteNonQuery()
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    Public Sub Lectura()
        If Not IsNothing(_Regis) Then
            _Regis.Close()
        End If

        Try
            miComando = New SqlCommand(_AuxSql, miConexion)
            _Regis = miComando.ExecuteReader
        Catch ex As SqlException
            Throw ex
        End Try
    End Sub

    Public Function Lectura2() As SqlDataReader
        If Not IsNothing(_Regis) Then
            _Regis.Close()
        End If

        Try
            MiComando = New SqlCommand(_AuxSql, MiConexion)
            _Regis = MiComando.ExecuteReader
        Catch ex As SqlException
            Throw ex
        End Try
        Return _Regis
    End Function

    Public Function Nivel() As String
        Dim niv As String = ""

        Try
            MiComando = New SqlCommand("exec sp_helpuser '" & _Usuario & "'", MiConexion)
            _Regis = MiComando.ExecuteReader
            If _Regis.HasRows Then
                _Regis.Read()
                niv = _Regis!RoleName
            End If
        Catch ex As SqlException
            Throw ex
        End Try
        _Regis.Close()

        Return niv

    End Function
End Class
