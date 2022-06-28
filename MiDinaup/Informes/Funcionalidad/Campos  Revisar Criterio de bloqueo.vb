Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisarCriterioDeBloqueoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisarCriterioDeBloqueo_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisarCriterioDeBloqueo_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposRevisarCriterioDeBloqueo_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("dddd5afb-ecc2-4dbe-a250-fc130101dd56"))
              me.ID = new GUID("dddd5afb-ecc2-4dbe-a250-fc130101dd56")
              me.Titulo  = "Campos > Revisar Criterio de bloqueo"
          End sub
          Public Class CamposRevisarCriterioDeBloqueo_FilaC
              Public Seccion As String
              Public BloqueodeServidor As Decimal
              Public FechaUltimaModificacion As Date?
              Public Etiqueta As String
              Public FechaAltaSistema As Date?
              Public ID As Guid
              Public BloquedeTerminal As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.BloqueodeServidor = o("BloqueodeServidor").DEC
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Etiqueta = o("Etiqueta").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.BloquedeTerminal = o("BloquedeTerminal").DEC
              End Sub
          End Class
      End Class
  End Class
End Class