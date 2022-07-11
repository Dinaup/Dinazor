Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class RecursosHumanosD
      Public Class ConfiguracionDeHorariosPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ConfiguracionDeHorariosPorEmpleado_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("a9411e2c-2f06-4f4d-816b-f7663d72f977"))
              me.ID = new GUID("a9411e2c-2f06-4f4d-816b-f7663d72f977")
              me.Titulo  = "Configuración de horarios por empleado"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class ConfiguracionDeHorariosPorEmpleado_FilaC
                <ProtoBuf.ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(101)>  Public Margeninicio As Integer
                <ProtoBuf.ProtoMember(102)>  Public Horarios As String
                <ProtoBuf.ProtoMember(103)>  Public Margenfin As Integer
                <ProtoBuf.ProtoMember(104)>  Public Fueradehorario As Boolean
                <ProtoBuf.ProtoMember(105)>  Public Horasextra As Decimal
                <ProtoBuf.ProtoMember(106)>  Public Retrasos As Decimal
                <ProtoBuf.ProtoMember(107)>  Public Turnosautomaticos As Boolean
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
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ConfiguracionDeHorariosPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ConfiguracionDeHorariosPorEmpleado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class