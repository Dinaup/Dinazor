Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposIdentificacionDeCamposC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposIdentificacionDeCampos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposIdentificacionDeCampos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposIdentificacionDeCampos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("da9d6090-5d9d-42a2-a91b-e410e1e0d61a"))
              me.ID = new GUID("da9d6090-5d9d-42a2-a91b-e410e1e0d61a")
              me.Titulo  = "Campos > Identificación de campos"
          End sub
          Public Class CamposIdentificacionDeCampos_FilaC
              Public Seccion As String
              Public Etiqueta As String
              Public ID As Guid
              Public EtiquetaAbreviada As String
              Public Pestana As String
              Public NombrePR As String
              Public FechaUltimaModificacion As Date?
              Public FechaAltaSistema As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.Etiqueta = o("Etiqueta").STR
              Me.ID = o("ID").ToGuid
              Me.EtiquetaAbreviada = o("EtiquetaAbreviada").STR
              Me.Pestana = o("Pestana").STR
              Me.NombrePR = o("NombrePR").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              End Sub
          End Class
      End Class
  End Class
End Class