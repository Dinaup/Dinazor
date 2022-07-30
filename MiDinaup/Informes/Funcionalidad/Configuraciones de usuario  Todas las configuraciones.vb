Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ConfiguracionesDeUsuarioTodasLasConfiguracionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ConfiguracionesDeUsuarioTodasLasConfiguraciones_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("b675da85-ef36-439f-bb1d-31ff4a547df8"))
              me.ID = new GUID("b675da85-ef36-439f-bb1d-31ff4a547df8")
              me.Titulo  = "Configuraciones de usuario > Todas las configuraciones"
          End sub
          <ProtoContract>
          Public Class ConfiguracionesDeUsuarioTodasLasConfiguraciones_FilaC
                <ProtoMember(100)>  Public ID As Guid
                <ProtoMember(101)>  Public FechaAltaSistema As DateTime
                <ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ConfiguracionesDeUsuarioTodasLasConfiguraciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ConfiguracionesDeUsuarioTodasLasConfiguraciones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class