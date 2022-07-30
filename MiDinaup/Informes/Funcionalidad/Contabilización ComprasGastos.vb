Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ContabilizacionComprasGastosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ContabilizacionComprasGastos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("72bb780b-95a6-44b0-8947-7b6d2e247969"))
              me.ID = new GUID("72bb780b-95a6-44b0-8947-7b6d2e247969")
              me.Titulo  = "Contabilización Compras/Gastos"
          End sub
          <ProtoContract>
          Public Class ContabilizacionComprasGastos_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Proveedor As String
                <ProtoMember(102)>  Public Total As Decimal
                <ProtoMember(103)>  Public Asiento As String
                <ProtoMember(104)>  Public Fecha As Date?
                <ProtoMember(105)>  Public AsientoImporte As Decimal
                <ProtoMember(106)>  Public UbicacionPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Proveedor = o("Proveedor").STR
              Me.Total = o("Total").DEC
              Me.Asiento = o("Asiento").STR
              Me.Fecha = o("Fecha").ToDate
              Me.AsientoImporte = o("AsientoImporte").DEC
              Me.UbicacionPrincipal = o("UbicacionPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ContabilizacionComprasGastos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ContabilizacionComprasGastos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class