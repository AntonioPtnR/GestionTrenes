Public Class CotizacionDAO
    Public ReadOnly Property Cotizaciones As Collection

    Public Sub New()
        Me.Cotizaciones = New Collection
    End Sub

    Public Sub LeerTodas(ruta As String)
        Dim c As Cotizacion
        Dim p As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Cotizaciones ORDER BY Producto")
        For Each aux In col
            p = New Producto(CInt(aux(1).ToString))
            c = New Cotizacion(p, CDate(aux(2).ToString))
            c.EurosPorTonelada = CDbl(aux(3).ToString)
            Me.Cotizaciones.Add(c)
        Next
    End Sub

    Public Sub LeerTodas()
        Dim c As Cotizacion
        Dim p As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT c.Producto, p.DescripProducto, c.Fecha, c.EurosPorTonelada FROM Cotizaciones c, Productos p WHERE c.Producto = p.IdProducto ORDER BY Producto")
        For Each aux In col
            p = New Producto(CInt(aux(1).ToString))
            p.DescripProducto = aux(2).ToString
            c = New Cotizacion(p, CDate(aux(3).ToString))
            c.EurosPorTonelada = CDbl(aux(4).ToString)
            Me.Cotizaciones.Add(c)
        Next
    End Sub

    Public Sub Leer(ByRef c As Cotizacion)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Cotizaciones WHERE Producto=" & c.Producto.IdProducto & " AND Fecha=#" & Format(c.Fecha, "yyyy/MM/dd") & "#;")
        For Each aux In col
            c.EurosPorTonelada = CDbl(aux(3).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal c As Cotizacion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Cotizaciones VALUES (" & c.Producto.IdProducto & ", #" & Format(c.Fecha, "yyyy/MM/dd") & "#, " & Replace(c.EurosPorTonelada.ToString, ",", ".") & ");")
    End Function

    Public Function Actualizar(ByVal c As Cotizacion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Cotizaciones SET EurosPorTonelada =" & Replace(c.EurosPorTonelada.ToString, ",", ".") & " WHERE Producto=" & c.Producto.IdProducto & " AND Fecha=#" & Format(c.Fecha, "yyyy/MM/dd") & "#;")
    End Function

    Public Function Borrar(ByVal c As Cotizacion) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Cotizaciones WHERE Producto=" & c.Producto.IdProducto & " AND Fecha=#" & Format(c.Fecha, "yyyy/MM/dd") & "#;")
    End Function
End Class
