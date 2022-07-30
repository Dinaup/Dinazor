Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ParametrosDeConfiguracionTodosLosParametrosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ParametrosDeConfiguracionTodosLosParametros_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2c5f3b54-fcfb-4d8a-8901-2a5827fcd68d"))
              me.ID = new GUID("2c5f3b54-fcfb-4d8a-8901-2a5827fcd68d")
              me.Titulo  = "Parámetros de Configuración > Todos los parámetros"
          End sub
          <ProtoContract>
          Public Class ParametrosDeConfiguracionTodosLosParametros_FilaC
                <ProtoMember(100)>  Public Categoria As String
                <ProtoMember(101)>  Public TextoPrincipal As String
                <ProtoMember(102)>  Public FechaAltaSistema As DateTime
                <ProtoMember(103)>  Public Subcategoria As String
                <ProtoMember(104)>  Public Eliminado As Boolean
                <ProtoMember(105)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(106)>  Public KeyWord As String
                <ProtoMember(107)>  Public ID As Guid
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
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ParametrosDeConfiguracionTodosLosParametros_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ParametrosDeConfiguracionTodosLosParametros_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class