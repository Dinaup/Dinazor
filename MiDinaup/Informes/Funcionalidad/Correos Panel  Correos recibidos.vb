Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CorreosPanelCorreosRecibidosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CorreosPanelCorreosRecibidos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CorreosPanelCorreosRecibidos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CorreosPanelCorreosRecibidos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("29a7080c-3969-4c53-97f9-6b3782a403ba"))
              me.ID = new GUID("29a7080c-3969-4c53-97f9-6b3782a403ba")
              me.Titulo  = "Correos Panel > Correos recibidos"
          End sub
          Public Class CorreosPanelCorreosRecibidos_FilaC
              Public EstadoIcono As Integer
              Public Recibido As Date?
              Public Asunto As String
              Public Estado As String
              Public Buzon As String
              Public Autor As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.EstadoIcono = o("EstadoIcono").INT
              Me.Recibido = o("Recibido").ToDateTime_UTC
              Me.Asunto = o("Asunto").STR
              Me.Estado = o("Estado").STR
              Me.Buzon = o("Buzon").STR
              Me.Autor = o("Autor").STR
              End Sub
          End Class
      End Class
  End Class
End Class