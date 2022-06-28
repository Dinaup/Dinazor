Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ScriptsDeSeccionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ScriptsDeSecciones_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ScriptsDeSecciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ScriptsDeSecciones_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("50f00cd4-cb75-47ff-af10-4105a68f5e92"))
              me.ID = new GUID("50f00cd4-cb75-47ff-af10-4105a68f5e92")
              me.Titulo  = "Scripts > De Secciones"
          End sub
          Public Class ScriptsDeSecciones_FilaC
              Public SeccionID As Guid
              Public Eliminado As Decimal
              Public ID As Guid
              Public TextoPrincipal As String
              Public FechaUltimaModificacion As Date?
              Public Script As String
              Public FechaAltaSistema As Date?
              Public Seccion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Eliminado = o("Eliminado").DEC
              Me.ID = o("ID").ToGuid
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Script = o("Script").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              End Sub
          End Class
      End Class
  End Class
End Class