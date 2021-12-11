Public Class Viaje
    Public Property FechaViaje As Date
    Public Property Tren As Tren
    Public Property Producto As Producto
    Public Property DesProducto As String
    Public Property ToneladasTransportadas As Integer
    Public Property Cotizacion As Double
    Public Property Beneficio As Double
    Public ReadOnly Property ViaDAO As ViajeDAO

    Public Sub New()
        Me.ViaDAO = New ViajeDAO
    End Sub

    Public Sub New(f As Date, t As Tren, p As Producto)
        Me.ViaDAO = New ViajeDAO
        Me.FechaViaje = CDate(Format(f, "yyyy/MM/dd"))
        Me.Tren = t
        Me.Producto = p
    End Sub

    Public Sub New(f As Date, p As Producto)
        Me.ViaDAO = New ViajeDAO
        Me.FechaViaje = CDate(Format(f, "yyyy/MM/dd"))
        Me.Producto = p
    End Sub

    Public Sub LeerTodosViajes(ruta As String)
        Me.ViaDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTodosViajes()
        Me.ViaDAO.LeerTodas()
    End Sub

    Public Sub MostrarInfoViajeMaxBeneficio()
        Me.ViaDAO.LeerVMaxBeneficio()
    End Sub

    Public Sub LeerViaje()
        Me.ViaDAO.Leer(Me)
    End Sub

    Public Sub LeerProductosFechas(fechaI As Date, fechaF As Date, tren As String)
        Me.ViaDAO.LeerPFechas(fechaI, fechaF, tren)
    End Sub
    Public Function InsertarViaje() As Integer
        Return Me.ViaDAO.Insertar(Me)
    End Function

    Public Function ActualizarViaje() As Integer
        Return Me.ViaDAO.Actualizar(Me)
    End Function

    Public Function BorrarViaje() As Integer
        Return Me.ViaDAO.Borrar(Me)
    End Function
End Class
