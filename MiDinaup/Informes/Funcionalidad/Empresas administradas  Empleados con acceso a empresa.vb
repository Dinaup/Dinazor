Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EmpresasAdministradasEmpleadosConAccesoAEmpresaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC)
          Public TokenCambios As Guid
          Sub new(Empresa As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d848399f-9f62-47b2-a3a8-130b1fe7f1d7"))
              me.ID = new GUID("d848399f-9f62-47b2-a3a8-130b1fe7f1d7")
              me.Titulo  = "Empresas administradas > Empleados con acceso a empresa"
              Agregar_Respuesta("Empresa",Empresa)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC
                <ProtoBuf.ProtoMember(100)>  Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class