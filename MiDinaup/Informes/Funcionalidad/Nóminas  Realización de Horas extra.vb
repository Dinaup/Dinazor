Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class NominasRealizacionDeHorasExtraC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of NominasRealizacionDeHorasExtra_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("0baa399b-e54f-456b-a3d9-eab77884204c"))
              me.ID = new GUID("0baa399b-e54f-456b-a3d9-eab77884204c")
              me.Titulo  = "Nóminas > Realización de Horas extra"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class NominasRealizacionDeHorasExtra_FilaC
                <ProtoMember(100)>  Public Fecha As Date?
                <ProtoMember(101)>  Public Fuerzamayor As Boolean
                <ProtoMember(102)>  Public Importe As Decimal
                <ProtoMember(103)>  Public Horas As Decimal
                <ProtoMember(104)>  Public RetHora As Decimal
                <ProtoMember(105)>  Public RetTotal As Decimal
                <ProtoMember(106)>  Public Estado As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDate
              Me.Fuerzamayor = o("Fuerzamayor").BOOL
              Me.Importe = o("Importe").DEC
              Me.Horas = o("Horas").DEC
              Me.RetHora = o("RetHora").DEC
              Me.RetTotal = o("RetTotal").DEC
              Me.Estado = ctype(o("Estado").INT(0), EnumTipoDeRealizacionDeTurnoE)
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of NominasRealizacionDeHorasExtra_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New NominasRealizacionDeHorasExtra_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class