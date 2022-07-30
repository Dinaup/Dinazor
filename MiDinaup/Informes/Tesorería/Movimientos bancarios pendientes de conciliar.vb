Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TesoreriaD
      Public Class MovimientosBancariosPendientesDeConciliarC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of MovimientosBancariosPendientesDeConciliar_FilaC)
          Public TokenCambios As Guid
          Sub new(Deposito As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2317f12d-b734-40fc-84fb-8b76bd07c26e"))
              me.ID = new GUID("2317f12d-b734-40fc-84fb-8b76bd07c26e")
              me.Titulo  = "Movimientos bancarios pendientes de conciliar"
              Agregar_Respuesta("Deposito",Deposito)
          End sub
          <ProtoContract>
          Public Class MovimientosBancariosPendientesDeConciliar_FilaC
                <ProtoMember(100)>  Public Concepto As String
                <ProtoMember(101)>  Public Fecha As Date?
                <ProtoMember(102)>  Public Importe As Decimal
                <ProtoMember(103)>  Public Pendiente As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Concepto = o("Concepto").STR
              Me.Fecha = o("Fecha").ToDate
              Me.Importe = o("Importe").DEC
              Me.Pendiente = o("Pendiente").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of MovimientosBancariosPendientesDeConciliar_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New MovimientosBancariosPendientesDeConciliar_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class