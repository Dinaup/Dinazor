Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class DestinadoresTodosLosDestinadoresC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of DestinadoresTodosLosDestinadores_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e7ffd09f-74a9-4358-9878-b1024917fa04"))
              me.ID = new GUID("e7ffd09f-74a9-4358-9878-b1024917fa04")
              me.Titulo  = "Destinadores > Todos los destinadores"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class DestinadoresTodosLosDestinadores_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Puedeagregarlibre As Boolean
                <ProtoBuf.ProtoMember(101)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(102)>  Public EtiquetaSingular As String
                <ProtoBuf.ProtoMember(103)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(104)>  Public SeccionDestino As String
                <ProtoBuf.ProtoMember(105)>  Public Eliminado As Boolean
                <ProtoBuf.ProtoMember(106)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(107)>  Public SeccionDestinoID As Guid
                <ProtoBuf.ProtoMember(108)>  Public SeccionOrigen As String
                <ProtoBuf.ProtoMember(109)>  Public ID As Guid
                <ProtoBuf.ProtoMember(110)>  Public SeccionID As Guid
                <ProtoBuf.ProtoMember(111)>  Public EtiquetaPlural As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Puedeagregarlibre = o("Puedeagregarlibre").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.EtiquetaSingular = o("EtiquetaSingular").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.SeccionDestino = o("SeccionDestino").STR
              Me.Eliminado = o("Eliminado").BOOL
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.SeccionDestinoID = o("SeccionDestinoID").ToGuid
              Me.SeccionOrigen = o("SeccionOrigen").STR
              Me.ID = o("ID").ToGuid
              Me.SeccionID = o("SeccionID").ToGuid
              Me.EtiquetaPlural = o("EtiquetaPlural").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of DestinadoresTodosLosDestinadores_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New DestinadoresTodosLosDestinadores_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class