Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionMovimientosEntreDepositosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionMovimientosEntreDepositos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ae796243-f0c4-426f-be43-1cc3fea6b9dd"))
              me.ID = new GUID("ae796243-f0c4-426f-be43-1cc3fea6b9dd")
              me.Titulo  = "Contabilización movimientos entre depósitos"
          End sub
          <ProtoContract>
          Public Class ContabilizacionMovimientosEntreDepositos_FilaC
                <ProtoMember(100)>  Public Origen As String
                <ProtoMember(101)>  Public Destino As String
                <ProtoMember(102)>  Public Empleado As String
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public Importe As Decimal
                <ProtoMember(105)>  Public Asiento As String
                <ProtoMember(106)>  Public AsientoImporte As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Origen = o("Origen").STR
              Me.Destino = o("Destino").STR
              Me.Empleado = o("Empleado").STR
              Me.Fecha = o("Fecha").ToDate
              Me.Importe = o("Importe").DEC
              Me.Asiento = o("Asiento").STR
              Me.AsientoImporte = o("AsientoImporte").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionMovimientosEntreDepositos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionMovimientosEntreDepositos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class