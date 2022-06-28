Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EmpresasAdministradasEmpleadosConAccesoAEmpresaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Empresa As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d848399f-9f62-47b2-a3a8-130b1fe7f1d7"))
              me.ID = new GUID("d848399f-9f62-47b2-a3a8-130b1fe7f1d7")
              me.Titulo  = "Empresas administradas > Empleados con acceso a empresa"
              Agregar_Respuesta("Empresa",Empresa)
          End sub
          Public Class EmpresasAdministradasEmpleadosConAccesoAEmpresa_FilaC
              Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
          End Class
      End Class
  End Class
End Class