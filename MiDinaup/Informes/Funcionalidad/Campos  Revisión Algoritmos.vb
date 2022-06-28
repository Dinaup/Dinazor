Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisionAlgoritmosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisionAlgoritmos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisionAlgoritmos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposRevisionAlgoritmos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("03b570c5-06e6-4faa-b39e-c6eb444bf210"))
              me.ID = new GUID("03b570c5-06e6-4faa-b39e-c6eb444bf210")
              me.Titulo  = "Campos > Revisión Algoritmos"
          End sub
          Public Class CamposRevisionAlgoritmos_FilaC
              Public Etiqueta As String
              Public FechaAltaSistema As Date?
              Public Algoritmo As String
              Public FechaUltimaModificacion As Date?
              Public Formato As Decimal
              Public ID As Guid
              Public SeccionID As Guid
              Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Etiqueta = o("Etiqueta").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Algoritmo = o("Algoritmo").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Formato = o("Formato").DEC
              Me.ID = o("ID").ToGuid
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Seccion = o("Seccion").STR
              End Sub
          End Class
      End Class
  End Class
End Class