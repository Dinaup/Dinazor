Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class DestinadoresTodosLosDestinadoresC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of DestinadoresTodosLosDestinadores_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of DestinadoresTodosLosDestinadores_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New DestinadoresTodosLosDestinadores_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e7ffd09f-74a9-4358-9878-b1024917fa04"))
              me.ID = new GUID("e7ffd09f-74a9-4358-9878-b1024917fa04")
              me.Titulo  = "Destinadores > Todos los destinadores"
          End sub
          Public Class DestinadoresTodosLosDestinadores_FilaC
              Public Puedeagregarlibre As Boolean
              Public FechaUltimaModificacion As Date?
              Public EtiquetaSingular As String
              Public TextoPrincipal As String
              Public SeccionDestino As String
              Public Eliminado As Boolean
              Public FechaAltaSistema As Date?
              Public SeccionDestinoID As Guid
              Public SeccionOrigen As String
              Public ID As Guid
              Public SeccionID As Guid
              Public EtiquetaPlural As String
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
          End Class
      End Class
  End Class
End Class