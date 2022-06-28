Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisarRelacionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisarRelaciones_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisarRelaciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposRevisarRelaciones_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c822a1d0-f17f-48f6-adc3-62c4ca619720"))
              me.ID = new GUID("c822a1d0-f17f-48f6-adc3-62c4ca619720")
              me.Titulo  = "Campos > Revisar Relaciones"
          End sub
          Public Class CamposRevisarRelaciones_FilaC
              Public Relacionesbase As Boolean
              Public FechaAltaSistema As Date?
              Public Seccionrelacionada As String
              Public Seccion As String
              Public FechaUltimaModificacion As Date?
              Public ID As Guid
              Public Etiqueta As String
              Public CampoPR As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Relacionesbase = o("Relacionesbase").BOOL
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Seccionrelacionada = o("Seccionrelacionada").STR
              Me.Seccion = o("Seccion").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.Etiqueta = o("Etiqueta").STR
              Me.CampoPR = o("CampoPR").STR
              End Sub
          End Class
      End Class
  End Class
End Class