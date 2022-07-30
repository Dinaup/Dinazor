Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ProductosD
      Public Class NivelesDeStockC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of NivelesDeStock_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("bc9fedb4-295d-4679-b9d9-64513fd0b28f"))
              me.ID = new GUID("bc9fedb4-295d-4679-b9d9-64513fd0b28f")
              me.Titulo  = "Niveles de Stock"
          End sub
          <ProtoContract>
          Public Class NivelesDeStock_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Imagen As Guid
                <ProtoMember(102)>  Public StockMinimo As Decimal
                <ProtoMember(103)>  Public StockInventario As Decimal
                <ProtoMember(104)>  Public StockTramite As Decimal
                <ProtoMember(105)>  Public StockDisponible As Decimal
                <ProtoMember(106)>  Public EstadodeInventario As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Imagen = o("Imagen").ToGuid
              Me.StockMinimo = o("StockMinimo").DEC
              Me.StockInventario = o("StockInventario").DEC
              Me.StockTramite = o("StockTramite").DEC
              Me.StockDisponible = o("StockDisponible").DEC
              Me.EstadodeInventario = o("EstadodeInventario").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of NivelesDeStock_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New NivelesDeStock_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class