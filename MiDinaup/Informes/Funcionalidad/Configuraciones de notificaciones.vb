Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ConfiguracionesDeNotificacionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ConfiguracionesDeNotificaciones_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ConfiguracionesDeNotificaciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ConfiguracionesDeNotificaciones_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c021d070-73d7-4200-833e-d2df0668a733"))
              me.ID = new GUID("c021d070-73d7-4200-833e-d2df0668a733")
              me.Titulo  = "Configuraciones de notificaciones"
          End sub
          Public Class ConfiguracionesDeNotificaciones_FilaC
              Public TextoPrincipal As String
              Public Tipo As Integer
              Public Titulonotificacion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Tipo = o("Tipo").INT
              Me.Titulonotificacion = o("Titulonotificacion").STR
              End Sub
          End Class
      End Class
  End Class
End Class