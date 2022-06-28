Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisionDeRelacionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisionDeRelaciones_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisionDeRelaciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposRevisionDeRelaciones_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("9926b248-878c-462e-bfc0-4cd332352c52"))
              me.ID = new GUID("9926b248-878c-462e-bfc0-4cd332352c52")
              me.Titulo  = "Campos > Revisión de Relaciones"
          End sub
          Public Class CamposRevisionDeRelaciones_FilaC
              Public Funcionalidadnativadecampo As Decimal
              Public Seccion As String
              Public ID As Guid
              Public FechaAltaSistema As Date?
              Public EsBase As Boolean
              Public Icono As Guid
              Public RelacionID As Guid
              Public Nombre As String
              Public SeccionID As Guid
              Public Formato As Decimal
              Public FechaUltimaModificacion As Date?
              Public Relacion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Funcionalidadnativadecampo = o("Funcionalidadnativadecampo").DEC
              Me.Seccion = o("Seccion").STR
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.EsBase = o("EsBase").BOOL
              Me.Icono = o("Icono").ToGuid
              Me.RelacionID = o("RelacionID").ToGuid
              Me.Nombre = o("Nombre").STR
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Formato = o("Formato").DEC
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Relacion = o("Relacion").STR
              End Sub
          End Class
      End Class
  End Class
End Class