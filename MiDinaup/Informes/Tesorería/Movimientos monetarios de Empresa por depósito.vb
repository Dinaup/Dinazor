Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TesoreriaD
      Public Class MovimientosMonetariosDeEmpresaPorDepositoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MovimientosMonetariosDeEmpresaPorDeposito_FilaC)
          Public TokenCambios As Guid
          Sub new(Deposito As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ef9280a0-ce44-496a-b86f-4a42538e5f13"))
              me.ID = new GUID("ef9280a0-ce44-496a-b86f-4a42538e5f13")
              me.Titulo  = "Movimientos monetarios de Empresa por depósito"
              Agregar_Respuesta("Deposito",Deposito)
          End sub
          <ProtoContract>
          Public Class MovimientosMonetariosDeEmpresaPorDeposito_FilaC
                <ProtoMember(100)>  Public Importe As Decimal
                <ProtoMember(101)>  Public Fecha As Date?
                <ProtoMember(102)>  Public Seccion As String
                <ProtoMember(103)>  Public Empleado As String
                <ProtoMember(104)>  Public Entidadrelacionada As String
                <ProtoMember(105)>  Public Estado As Integer
                <ProtoMember(106)>  Public Conciliadocon As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Importe = o("Importe").DEC
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Seccion = o("Seccion").STR
              Me.Empleado = o("Empleado").STR
              Me.Entidadrelacionada = o("Entidadrelacionada").STR
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              Me.Conciliadocon = o("Conciliadocon").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MovimientosMonetariosDeEmpresaPorDeposito_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New MovimientosMonetariosDeEmpresaPorDeposito_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class