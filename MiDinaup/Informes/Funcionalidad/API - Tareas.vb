Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class APITareasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of APITareas_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of APITareas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New APITareas_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("3290a212-ee36-463b-bc31-9a4300753cb0"))
              me.ID = new GUID("3290a212-ee36-463b-bc31-9a4300753cb0")
              me.Titulo  = "API - Tareas"
          End sub
          Public Class APITareas_FilaC
              Public Encargado As String
              Public EncargadoFoto As Guid
              Public Prioridad As Integer
              Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Encargado = o("Encargado").STR
              Me.EncargadoFoto = o("EncargadoFoto").ToGuid
              Me.Prioridad = o("Prioridad").INT
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
          End Class
      End Class
  End Class
End Class