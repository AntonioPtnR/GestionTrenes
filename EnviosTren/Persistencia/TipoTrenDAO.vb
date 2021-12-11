Public Class TipoTrenDAO
    Public ReadOnly Property Tipos_Tren As Collection

    Public Sub New()
        Me.Tipos_Tren = New Collection
    End Sub

    Public Sub LeerTodos(ruta As String)
        Dim tt As TipoTren
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente(ruta).Leer("SELECT * FROM Tipos_Tren ORDER BY IdTipoTren")
        For Each aux In col
            tt = New TipoTren(CInt(aux(1).ToString))
            tt.DescTipoTren = aux(2).ToString
            tt.CapacidadMax = CInt(aux(3).ToString)
            Me.Tipos_Tren.Add(tt)
        Next
    End Sub

    Public Sub LeerTodos()
        Dim tt As TipoTren
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT * FROM Tipos_Tren ORDER BY IdTipoTren")
        For Each aux In col
            tt = New TipoTren(CInt(aux(1).ToString))
            tt.DescTipoTren = aux(2).ToString
            tt.CapacidadMax = CInt(aux(3).ToString)
            Me.Tipos_Tren.Add(tt)
        Next
    End Sub

    Public Sub LeerRTT(fechaI As Date, fechaF As Date)
        Dim tt As TipoTren
        Dim col, aux As Collection
        col = AgenteBD.ObtenerAgente().Leer("SELECT tt.IdTipoTren,tt.DescTipoTren,COUNT(*) FROM (Tipos_Tren tt INNER JOIN Trenes t ON tt.IdTipoTren=t.TipoTren) INNER JOIN Viajes v ON(t.Matricula=v.Tren)  WHERE v.FechaViaje BETWEEN #" & Format(fechaI, "yyyy/MM/dd") & "# AND #" & Format(fechaF, "yyyy/MM/dd") & "# GROUP BY tt.IdTipoTren,tt.DescTipoTren ORDER BY COUNT(*) DESC")
        For Each aux In col
            tt = New TipoTren(CInt(aux(1).ToString))
            tt.DescTipoTren = aux(2).ToString
            tt.numTT = CInt(aux(3).ToString)
            Me.Tipos_Tren.Add(tt)
        Next
    End Sub

    Public Sub Leer(ByRef tt As TipoTren)
        Dim col As Collection : Dim aux As Collection
        col = AgenteBD.ObtenerAgente.Leer("SELECT * FROM Tipos_Tren WHERE IdTipoTren=" & tt.IdTipoTren & ";")
        For Each aux In col
            tt.DescTipoTren = aux(2).ToString
            tt.CapacidadMax = CInt(aux(3).ToString)
        Next
    End Sub

    Public Function Insertar(ByVal tt As TipoTren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("INSERT INTO Tipos_Tren (DescTipoTren, CapacidadMax) VALUES ('" & tt.DescTipoTren & "', " & tt.CapacidadMax & ");")
    End Function

    Public Function Actualizar(ByVal tt As TipoTren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("UPDATE Tipos_Tren SET DescTipoTren='" & tt.DescTipoTren & "', CapacidadMax=" & tt.CapacidadMax & " WHERE IdTipoTren=" & tt.IdTipoTren & ";")
    End Function

    Public Function Borrar(ByVal tt As TipoTren) As Integer
        Return AgenteBD.ObtenerAgente.Modificar("DELETE FROM Tipos_Tren WHERE IdTipoTren=" & tt.IdTipoTren & ";")
    End Function
End Class
