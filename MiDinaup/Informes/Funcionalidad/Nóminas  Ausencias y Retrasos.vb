Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class NominasAusenciasYRetrasosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of NominasAusenciasYRetrasos_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("7c79a937-bca1-4c26-b343-7375ebdebebf"))
              me.ID = new GUID("7c79a937-bca1-4c26-b343-7375ebdebebf")
              me.Titulo  = "Nóminas > Ausencias y Retrasos"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class NominasAusenciasYRetrasos_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Importe As Decimal
                <ProtoBuf.ProtoMember(101)>  Public Fecha As Date?
                <ProtoBuf.ProtoMember(102)>  Public Horas As Decimal
                <ProtoBuf.ProtoMember(103)>  Public Deduccion As Decimal
                <ProtoBuf.ProtoMember(104)>  Public Resolucion As Integer
                <ProtoBuf.ProtoMember(105)>  Public RetrasoEntrada As Integer
                <ProtoBuf.ProtoMember(106)>  Public Minutossalida As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Importe = o("Importe").DEC
              Me.Fecha = o("Fecha").ToDate
              Me.Horas = o("Horas").DEC
              Me.Deduccion = o("Deduccion").DEC
              Me.Resolucion = ctype(o("Resolucion").INT(0), EnumTipoDeRealizacionDeTurnoE)
              Me.RetrasoEntrada = o("RetrasoEntrada").INT
              Me.Minutossalida = o("Minutossalida").INT
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of NominasAusenciasYRetrasos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New NominasAusenciasYRetrasos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class