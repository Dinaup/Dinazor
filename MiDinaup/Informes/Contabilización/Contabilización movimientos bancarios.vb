Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilizacionD
      Public Class ContabilizacionMovimientosBancariosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionMovimientosBancarios_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c6ee6511-793e-4564-a6bf-0ba19a062654"))
              me.ID = new GUID("c6ee6511-793e-4564-a6bf-0ba19a062654")
              me.Titulo  = "Contabilización movimientos bancarios"
          End sub
          <ProtoContract>
          Public Class ContabilizacionMovimientosBancarios_FilaC
                <ProtoMember(100)>  Public Subcuenta As String
                <ProtoMember(101)>  Public Importe As Decimal
                <ProtoMember(102)>  Public Asiento As String
                <ProtoMember(103)>  Public Origen As String
                <ProtoMember(104)>  Public Concepto As String
                <ProtoMember(105)>  Public Fecha As Date?
                <ProtoMember(106)>  Public AsientoImporte As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Subcuenta = o("Subcuenta").STR
              Me.Importe = o("Importe").DEC
              Me.Asiento = o("Asiento").STR
              Me.Origen = o("Origen").STR
              Me.Concepto = o("Concepto").STR
              Me.Fecha = o("Fecha").ToDate
              Me.AsientoImporte = o("AsientoImporte").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionMovimientosBancarios_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionMovimientosBancarios_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class