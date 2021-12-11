Public Class TipoTren
    Public Property IdTipoTren As Integer
    Public Property DescTipoTren As String
    Public Property CapacidadMax As Integer
    Public Property numTT As Integer
    Public ReadOnly Property TTrenDAO As TipoTrenDAO

    Public Sub New()
        Me.TTrenDAO = New TipoTrenDAO
    End Sub

    Public Sub New(id As Integer)
        Me.TTrenDAO = New TipoTrenDAO
        Me.IdTipoTren = id
    End Sub

    Public Sub LeerTodosTiposTren(ruta As String)
        Me.TTrenDAO.LeerTodos(ruta)
    End Sub

    Public Sub LeerTodosTiposTren()
        Me.TTrenDAO.LeerTodos()
    End Sub

    Public Sub LeerTipoTren()
        Me.TTrenDAO.Leer(Me)
    End Sub

    Public Sub LeerRankingTipoTren(fechaI As Date, fechaF As Date)
        Me.TTrenDAO.LeerRTT(fechaI, fechaF)
    End Sub

    Public Function InsertarTipoTren() As Integer
        Return Me.TTrenDAO.Insertar(Me)
    End Function

    Public Function ActualizarTipoTren() As Integer
        Return Me.TTrenDAO.Actualizar(Me)
    End Function

    Public Function BorrarTipoTren() As Integer
        Return Me.TTrenDAO.Borrar(Me)
    End Function
End Class
