Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class RecursosHumanosD
      Public Class ConfiguracionDeHorariosPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ConfiguracionDeHorariosPorEmpleado_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ConfiguracionDeHorariosPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ConfiguracionDeHorariosPorEmpleado_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("a9411e2c-2f06-4f4d-816b-f7663d72f977"))
              me.ID = new GUID("a9411e2c-2f06-4f4d-816b-f7663d72f977")
              me.Titulo  = "Configuración de horarios por empleado"
          End sub
          Public Class ConfiguracionDeHorariosPorEmpleado_FilaC
              Public TextoPrincipal As String
              Public Margeninicio As Integer
              Public Horarios As String
              Public Margenfin As Integer
              Public Fueradehorario As Boolean
              Public Horasextra As Decimal
              Public Retrasos As Decimal
              Public Turnosautomaticos As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Margeninicio = o("Margeninicio").INT
              Me.Horarios = o("Horarios").STR
              Me.Margenfin = o("Margenfin").INT
              Me.Fueradehorario = o("Fueradehorario").BOOL
              Me.Horasextra = o("Horasextra").DEC
              Me.Retrasos = o("Retrasos").DEC
              Me.Turnosautomaticos = o("Turnosautomaticos").BOOL
              End Sub
          End Class
      End Class
  End Class
End Class