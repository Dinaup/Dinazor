Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EmpleadosEmpresasAdministrablesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EmpleadosEmpresasAdministrables_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("3f8993ad-6eab-48fd-b245-e9e6ce0cd19f"))
              me.ID = new GUID("3f8993ad-6eab-48fd-b245-e9e6ce0cd19f")
              me.Titulo  = "Empleados > Empresas administrables"
              Agregar_Respuesta("Empleado",Empleado)
          End sub
          <ProtoContract>
          Public Class EmpleadosEmpresasAdministrables_FilaC
                <ProtoMember(100)>  Public Archivada As Boolean
                <ProtoMember(101)>  Public AccesoTodos As Boolean
                <ProtoMember(102)>  Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Archivada = o("Archivada").BOOL
              Me.AccesoTodos = o("AccesoTodos").BOOL
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EmpleadosEmpresasAdministrables_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EmpleadosEmpresasAdministrables_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class