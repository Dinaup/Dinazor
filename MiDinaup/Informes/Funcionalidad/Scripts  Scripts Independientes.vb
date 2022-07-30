Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ScriptsScriptsIndependientesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ScriptsScriptsIndependientes_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("a8ff59ff-2052-4a2d-93b3-21c52321f72b"))
              me.ID = new GUID("a8ff59ff-2052-4a2d-93b3-21c52321f72b")
              me.Titulo  = "Scripts > Scripts Independientes"
          End sub
          <ProtoContract>
          Public Class ScriptsScriptsIndependientes_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public TituloLegible As String
                <ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.TituloLegible = o("TituloLegible").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ScriptsScriptsIndependientes_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ScriptsScriptsIndependientes_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class