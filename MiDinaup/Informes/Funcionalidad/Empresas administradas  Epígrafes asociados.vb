Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EmpresasAdministradasEpigrafesAsociadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EmpresasAdministradasEpigrafesAsociados_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2ec558bd-de37-489d-a8f9-ca5b2e49e7dc"))
              me.ID = new GUID("2ec558bd-de37-489d-a8f9-ca5b2e49e7dc")
              me.Titulo  = "Empresas administradas > Epígrafes asociados"
          End sub
          <ProtoContract>
          Public Class EmpresasAdministradasEpigrafesAsociados_FilaC
                <ProtoMember(100)>  Public Epigrafe As String
                <ProtoMember(101)>  Public Activo As Boolean
                <ProtoMember(102)>  Public Principal As Boolean
                <ProtoMember(103)>  Public VolumenOperaciones As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Epigrafe = o("Epigrafe").STR
              Me.Activo = o("Activo").BOOL
              Me.Principal = o("Principal").BOOL
              Me.VolumenOperaciones = o("VolumenOperaciones").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EmpresasAdministradasEpigrafesAsociados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EmpresasAdministradasEpigrafesAsociados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class