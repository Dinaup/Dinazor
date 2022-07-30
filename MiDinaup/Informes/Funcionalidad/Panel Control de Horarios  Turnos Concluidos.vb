Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanelControlDeHorariosTurnosConcluidosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanelControlDeHorariosTurnosConcluidos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("91b61de7-ee0e-4c40-8a63-f01894ecfff1"))
              me.ID = new GUID("91b61de7-ee0e-4c40-8a63-f01894ecfff1")
              me.Titulo  = "Panel Control de Horarios > Turnos Concluidos"
          End sub
          <ProtoContract>
          Public Class PanelControlDeHorariosTurnosConcluidos_FilaC
                <ProtoMember(100)>  Public Empleado As String
                <ProtoMember(101)>  Public EmpleadoIcono As Guid
                <ProtoMember(102)>  Public Ubicacion As String
                <ProtoMember(103)>  Public Turno As String
                <ProtoMember(104)>  Public Estado As Integer
                <ProtoMember(105)>  Public Diferencia As Integer
                <ProtoMember(106)>  Public Inicio As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.EmpleadoIcono = o("EmpleadoIcono").ToGuid
              Me.Ubicacion = o("Ubicacion").STR
              Me.Turno = o("Turno").STR
              Me.Estado = ctype(o("Estado").INT(0), EnumTipoDeRealizacionDeTurnoE)
              Me.Diferencia = o("Diferencia").INT
              Me.Inicio = o("Inicio").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanelControlDeHorariosTurnosConcluidos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanelControlDeHorariosTurnosConcluidos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class