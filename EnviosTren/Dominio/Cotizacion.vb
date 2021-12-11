Public Class Cotizacion
    Public Property Producto As Producto
    Public Property Fecha As Date
    Public Property EurosPorTonelada As Double
    Public ReadOnly Property CotDAO As CotizacionDAO

    Public Sub New()
        Me.CotDAO = New CotizacionDAO
    End Sub

    Public Sub New(prod As Producto, fecha As Date)
        Me.CotDAO = New CotizacionDAO
        Me.Producto = prod
        Me.Fecha = CDate(Format(fecha, "yyyy/MM/dd"))
    End Sub

    Public Sub LeerTodasCotizaciones(ruta As String)
        Me.CotDAO.LeerTodas(ruta)
    End Sub

    Public Sub LeerTodasCotizaciones()
        Me.CotDAO.LeerTodas()
    End Sub

    Public Sub LeerCotizacion()
        Me.CotDAO.Leer(Me)
    End Sub

    Public Function InsertarCotizacion() As Integer
        Return Me.CotDAO.Insertar(Me)
    End Function

    Public Function ActualizarCotizacion() As Integer
        Return Me.CotDAO.Actualizar(Me)
    End Function

    Public Function BorrarCotizacion() As Integer
        Return Me.CotDAO.Borrar(Me)
    End Function

End Class
