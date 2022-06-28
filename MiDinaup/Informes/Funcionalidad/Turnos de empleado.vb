Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class TurnosDeEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of TurnosDeEmpleado_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of TurnosDeEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New TurnosDeEmpleado_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Empleado As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("1fe7861e-95a1-40f9-aaac-183064744913"))
              me.ID = new GUID("1fe7861e-95a1-40f9-aaac-183064744913")
              me.Titulo  = "Turnos de empleado"
              Agregar_Respuesta("Empleado",Empleado)
          End sub
          Public Class TurnosDeEmpleado_FilaC
              Public Duracion As Integer
              Public Estado As Integer
              Public Inicio As Date?
              Public Fin As Date?
              Public Realizacion As Integer
              Public Ubicacion As String
              Public Empleado As String
              Public Margeninicio As Date?
              Public Descripcioncorta As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Duracion = o("Duracion").INT
              Me.Estado = o("Estado").INT
              Me.Inicio = o("Inicio").ToDateTime_UTC
              Me.Fin = o("Fin").ToDateTime_UTC
              Me.Realizacion = o("Realizacion").INT
              Me.Ubicacion = o("Ubicacion").STR
              Me.Empleado = o("Empleado").STR
              Me.Margeninicio = o("Margeninicio").ToDateTime_UTC
              Me.Descripcioncorta = o("Descripcioncorta").STR
              End Sub
          End Class
      End Class
  End Class
End Class