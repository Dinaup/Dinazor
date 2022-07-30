Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TesoreriaD
      Public Class MovimientosMonetariosDeBancosPorDepositosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MovimientosMonetariosDeBancosPorDepositos_FilaC)
          Public TokenCambios As Guid
          Sub new(Cuenta As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("f724ae52-1a3a-46ff-b1b6-5f2e6ba5f90e"))
              me.ID = new GUID("f724ae52-1a3a-46ff-b1b6-5f2e6ba5f90e")
              me.Titulo  = "Movimientos monetarios de Bancos por depósitos"
              Agregar_Respuesta("Cuenta",Cuenta)
          End sub
          <ProtoContract>
          Public Class MovimientosMonetariosDeBancosPorDepositos_FilaC
                <ProtoMember(100)>  Public Fecha As Date?
                <ProtoMember(101)>  Public Importe As Decimal
                <ProtoMember(102)>  Public Concepto As String
                <ProtoMember(103)>  Public Sinconciliar As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDate
              Me.Importe = o("Importe").DEC
              Me.Concepto = o("Concepto").STR
              Me.Sinconciliar = o("Sinconciliar").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MovimientosMonetariosDeBancosPorDepositos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New MovimientosMonetariosDeBancosPorDepositos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class