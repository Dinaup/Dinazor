Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ProductosD
      Public Class InventarioC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of Inventario_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c9e7b503-51dc-4894-af3c-841c4850b381"))
              me.ID = new GUID("c9e7b503-51dc-4894-af3c-841c4850b381")
              me.Titulo  = "Inventario"
          End sub
          <ProtoContract>
          Public Class Inventario_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public StockDisponible As Decimal
                <ProtoMember(102)>  Public StockTramite As Decimal
                <ProtoMember(103)>  Public Fabricante As String
                <ProtoMember(104)>  Public Imagen As Guid
                <ProtoMember(105)>  Public Categoria As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.StockDisponible = o("StockDisponible").DEC
              Me.StockTramite = o("StockTramite").DEC
              Me.Fabricante = o("Fabricante").STR
              Me.Imagen = o("Imagen").ToGuid
              Me.Categoria = o("Categoria").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of Inventario_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New Inventario_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class