Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ParametrosDeConfiguracionTodosLosParametrosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ParametrosDeConfiguracionTodosLosParametros_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ParametrosDeConfiguracionTodosLosParametros_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ParametrosDeConfiguracionTodosLosParametros_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2c5f3b54-fcfb-4d8a-8901-2a5827fcd68d"))
              me.ID = new GUID("2c5f3b54-fcfb-4d8a-8901-2a5827fcd68d")
              me.Titulo  = "Parámetros de Configuración > Todos los parámetros"
          End sub
          Public Class ParametrosDeConfiguracionTodosLosParametros_FilaC
              Public Categoria As String
              Public TextoPrincipal As String
              Public FechaAltaSistema As Date?
              Public Subcategoria As String
              Public Eliminado As Boolean
              Public FechaUltimaModificacion As Date?
              Public KeyWord As String
              Public ID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Categoria = o("Categoria").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Subcategoria = o("Subcategoria").STR
              Me.Eliminado = o("Eliminado").BOOL
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.KeyWord = o("KeyWord").STR
              Me.ID = o("ID").ToGuid
              End Sub
          End Class
      End Class
  End Class
End Class