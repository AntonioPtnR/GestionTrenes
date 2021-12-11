Public Class TrenDAO
    Public ReadOnly Property Trenes As Collection

    Public Sub New()
        Me.Trenes = New Collection
    End Sub

    Public Sub LeerTodos(ruta As String)
        Dim t As Tren
        Dim tipot As TipoTren
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT t.Matricula, t.TipoTren, tt.DescTipoTren FROM Trenes t, Tipos_Tren tt WHERE t.TipoTren = tt.IdTipoTren ORDER BY Matricula")
        For Each aux In col
            t = New Tren(aux(1).ToString)
            tipot = New TipoTren(CInt(aux(2).ToString))
            tipot.DescTipoTren = aux(3).ToString
            t.TipoTren = tipot
            Me.Trenes.Add(t)
        Next
    End Sub

    Public Sub LeerTodos()
        Dim t As Tren
        Dim tipot As TipoTren
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT t.Matricula, t.TipoTren, tt.DescTipoTren FROM Trenes t, Tipos_Tren tt WHERE t.TipoTren = tt.IdTipoTren ORDER BY Matricula")
        For Each aux In col
            t = New Tren(aux(1).ToString)
            tipot = New TipoTren(CInt(aux(2).ToString))
            tipot.DescTipoTren = aux(3).ToString
            t.TipoTren = tipot
            Me.Trenes.Add(t)
        Next
    End Sub

    Public Sub LeerTDisp(fecha As Date)
        Dim t As Tren
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT t.Matricula FROM Trenes t WHERE t.Matricula NOT IN(SELECT v.Tren FROM Viajes v WHERE v.FechaViaje= #" & Format(fecha, "yyyy/MM/dd") & "#);")
        For Each aux In col
            t = New Tren(aux(1).ToString)
            Me.Trenes.Add(t)
        Next
    End Sub

    Public Sub Leer(ByRef t As Tren)
        Dim tipot As TipoTren
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Trenes WHERE Matricula='" & t.Matricula & "';")
        For Each aux In col
            tipot = New TipoTren(CInt(aux(2).ToString))
            t.TipoTren = tipot
        Next
    End Sub

    Public Function Insertar(ByVal t As Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Trenes VALUES ('" & t.Matricula & "', " & t.TipoTren.IdTipoTren & ");")
    End Function

    Public Function Actualizar(ByVal t As Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Trenes SET TipoTren=" & t.TipoTren.IdTipoTren & " WHERE Matricula='" & t.Matricula & "';")
    End Function

    Public Function Borrar(ByVal t As Tren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Trenes WHERE Matricula='" & t.Matricula & "';")
    End Function
End Class
