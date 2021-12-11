Public Class Producto
    Public Property IdProducto As Integer
    Public Property DescripProducto As String
    Public Property numP As Integer
    Public ReadOnly Property ProDAO As ProductoDAO

    Public Sub New()
        Me.ProDAO = New ProductoDAO
    End Sub

    Public Sub New(id As Integer)
        Me.ProDAO = New ProductoDAO
        Me.IdProducto = id
    End Sub

    Public Sub LeerTodosProductos(ruta As String)
        Me.ProDAO.LeerTodos(ruta)
    End Sub

    Public Sub LeerTodosProductos()
        Me.ProDAO.LeerTodos()
    End Sub

    Public Sub LeerProducto()
        Me.ProDAO.Leer(Me)
    End Sub

    Public Sub LeerRankingProductos(fechaI As Date, fechaS As Date)
        Me.ProDAO.LeerRP(fechaI, fechaS)
    End Sub

    Public Function InsertarProducto() As Integer
        Return Me.ProDAO.Insertar(Me)
    End Function

    Public Function ActualizarProducto() As Integer
        Return Me.ProDAO.Actualizar(Me)
    End Function

    Public Function BorrarProducto() As Integer
        Return Me.ProDAO.Borrar(Me)
    End Function
End Class
