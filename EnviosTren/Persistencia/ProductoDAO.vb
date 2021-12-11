Public Class ProductoDAO

    Public ReadOnly Property Productos As Collection

    Public Sub New()
        Me.Productos = New Collection
    End Sub

    Public Sub LeerTodos(ruta As String)
        Dim p As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Productos ORDER BY IdProducto")
        For Each aux In col
            p = New Producto(CInt(aux(1).ToString))
            p.DescripProducto = aux(2).ToString
            Me.Productos.Add(p)
        Next
    End Sub

    Public Sub LeerTodos()
        Dim p As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Productos ORDER BY IdProducto")
        For Each aux In col
            p = New Producto(CInt(aux(1).ToString))
            p.DescripProducto = aux(2).ToString
            Me.Productos.Add(p)
        Next
    End Sub

    Public Sub LeerRP(fechaI As Date, fechaF As Date)
        Dim prod As Producto
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT p.IdProducto,p.DescripProducto, COUNT(*) FROM Productos p INNER JOIN Viajes v ON(p.IdProducto=v.Producto) WHERE v.FechaViaje BETWEEN #" & Format(fechaI, "yyyy/MM/dd") & "# AND #" & Format(fechaF, "yyyy/MM/dd") & "#GROUP BY p.IdProducto,p.DescripProducto ORDER BY COUNT(*) DESC")
        For Each aux In col
            prod = New Producto(CInt(aux(1).ToString))
            prod.DescripProducto = aux(2).ToString
            prod.numP = CInt(aux(3).ToString)
            Me.Productos.Add(prod)
        Next
    End Sub

    Public Sub Leer(ByRef p As Producto)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Productos WHERE IdProducto=" & p.IdProducto & ";")
        For Each aux In col
            p.DescripProducto = aux(2).ToString
        Next
    End Sub

    Public Function Insertar(ByVal p As Producto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Productos (DescripProducto) VALUES ('" & p.DescripProducto & "');")
    End Function

    Public Function Actualizar(ByVal p As Producto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Productos SET DescripProducto='" & p.DescripProducto & "' WHERE IdProducto=" & p.IdProducto & ";")
    End Function

    Public Function Borrar(ByVal p As Producto) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Productos WHERE IdProducto=" & p.IdProducto & ";")
    End Function

End Class
