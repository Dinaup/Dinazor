Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EmpleadosUbicacionesConAccesoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EmpleadosUbicacionesConAcceso_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("6ee4463c-c902-48f5-9f0a-06576668cffc"))
              me.ID = new GUID("6ee4463c-c902-48f5-9f0a-06576668cffc")
              me.Titulo  = "Empleados > Ubicaciones con acceso"
              Agregar_Respuesta("Empleado",Empleado)
          End sub
          <ProtoContract>
          Public Class EmpleadosUbicacionesConAcceso_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public AccesoTodos As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.AccesoTodos = o("AccesoTodos").BOOL
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EmpleadosUbicacionesConAcceso_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EmpleadosUbicacionesConAcceso_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class