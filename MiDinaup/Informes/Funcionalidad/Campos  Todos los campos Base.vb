Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposTodosLosCamposBaseC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposTodosLosCamposBase_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposTodosLosCamposBase_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposTodosLosCamposBase_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("19cc278a-8ab9-407e-8644-fb3a16a87eab"))
              me.ID = new GUID("19cc278a-8ab9-407e-8644-fb3a16a87eab")
              me.Titulo  = "Campos > Todos los campos Base"
          End sub
          Public Class CamposTodosLosCamposBase_FilaC
              Public Formato As Decimal
              Public SeccionID As Guid
              Public Nombre As String
              Public FechaUltimaModificacion As Date?
              Public Seccion As String
              Public ID As Guid
              Public FechaAltaSistema As Date?
              Public Eliminado As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Formato = o("Formato").DEC
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Nombre = o("Nombre").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Eliminado = o("Eliminado").BOOL
              End Sub
          End Class
      End Class
  End Class
End Class