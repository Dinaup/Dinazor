Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelControlDeHorariosTurnosEnCursoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelControlDeHorariosTurnosEnCurso_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("8d65220a-5f3b-4cec-9f40-ce926604dca9"))
              me.ID = new GUID("8d65220a-5f3b-4cec-9f40-ce926604dca9")
              me.Titulo  = "Panel Control de Horarios > Turnos en curso"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class PanelControlDeHorariosTurnosEnCurso_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Empleado As String
                <ProtoBuf.ProtoMember(101)>  Public EmpleadoIcono As Guid
                <ProtoBuf.ProtoMember(102)>  Public Estado As Integer
                <ProtoBuf.ProtoMember(103)>  Public Ubicacion As String
                <ProtoBuf.ProtoMember(104)>  Public Turno As String
                <ProtoBuf.ProtoMember(105)>  Public Inicio As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.EmpleadoIcono = o("EmpleadoIcono").ToGuid
              Me.Estado = ctype(o("Estado").INT(0), EnumTipoDeRealizacionDeTurnoE)
              Me.Ubicacion = o("Ubicacion").STR
              Me.Turno = o("Turno").STR
              Me.Inicio = o("Inicio").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelControlDeHorariosTurnosEnCurso_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelControlDeHorariosTurnosEnCurso_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class