Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposSistemaDeImportacionC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposSistemaDeImportacion_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposSistemaDeImportacion_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposSistemaDeImportacion_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("48ba9aac-c44b-463d-a513-024f046f4c3a"))
              me.ID = new GUID("48ba9aac-c44b-463d-a513-024f046f4c3a")
              me.Titulo  = "Campos > Sistema de importación"
          End sub
          Public Class CamposSistemaDeImportacion_FilaC
              Public Etiqueta As String
              Public Formato As Decimal
              Public ID As Guid
              Public FechaUltimaModificacion As Date?
              Public Obligatorio As Boolean
              Public FechaAltaSistema As Date?
              Public IconoID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Etiqueta = o("Etiqueta").STR
              Me.Formato = o("Formato").DEC
              Me.ID = o("ID").ToGuid
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Obligatorio = o("Obligatorio").BOOL
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.IconoID = o("IconoID").ToGuid
              End Sub
          End Class
      End Class
  End Class
End Class