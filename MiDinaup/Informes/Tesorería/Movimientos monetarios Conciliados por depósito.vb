Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TesoreriaD
      Public Class MovimientosMonetariosConciliadosPorDepositoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MovimientosMonetariosConciliadosPorDeposito_FilaC)
          Public TokenCambios As Guid
          Sub new(Deposito As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("33e64468-bb1e-4066-8fc1-ed9039c71203"))
              me.ID = new GUID("33e64468-bb1e-4066-8fc1-ed9039c71203")
              me.Titulo  = "Movimientos monetarios Conciliados por depósito"
              Agregar_Respuesta("Deposito",Deposito)
          End sub
          <ProtoContract>
          Public Class MovimientosMonetariosConciliadosPorDeposito_FilaC
                <ProtoMember(100)>  Public Importe As Decimal
                <ProtoMember(101)>  Public Ubicacion As String
                <ProtoMember(102)>  Public Origen As String
                <ProtoMember(103)>  Public Estado As Integer
                <ProtoMember(104)>  Public Empleado As String
                <ProtoMember(105)>  Public Entidadrelacionada As String
                <ProtoMember(106)>  Public Tramitado As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Importe = o("Importe").DEC
              Me.Ubicacion = o("Ubicacion").STR
              Me.Origen = o("Origen").STR
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              Me.Empleado = o("Empleado").STR
              Me.Entidadrelacionada = o("Entidadrelacionada").STR
              Me.Tramitado = o("Tramitado").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MovimientosMonetariosConciliadosPorDeposito_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New MovimientosMonetariosConciliadosPorDeposito_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class