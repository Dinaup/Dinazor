Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelesTodosLosPanelesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelesTodosLosPaneles_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("1a409397-01d3-4e4c-afae-aa1809753daa"))
              me.ID = new GUID("1a409397-01d3-4e4c-afae-aa1809753daa")
              me.Titulo  = "Paneles > Todos los paneles"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class PanelesTodosLosPaneles_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Tipo As Boolean
                <ProtoBuf.ProtoMember(101)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(102)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(103)>  Public ID As Guid
                <ProtoBuf.ProtoMember(104)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(105)>  Public Eliminado As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Tipo = o("Tipo").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Eliminado = o("Eliminado").BOOL
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelesTodosLosPaneles_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelesTodosLosPaneles_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class