Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanalComprasPresupuestosDeCompraEnTramiteC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanalComprasPresupuestosDeCompraEnTramite_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2f39714c-f134-4bcf-a58a-46cdc4aa761e"))
              me.ID = new GUID("2f39714c-f134-4bcf-a58a-46cdc4aa761e")
              me.Titulo  = "Panal Compras > Presupuestos de Compra (En trámite)"
          End sub
          <ProtoContract>
          Public Class PanalComprasPresupuestosDeCompraEnTramite_FilaC
                <ProtoMember(100)>  Public Proveedor As String
                <ProtoMember(101)>  Public Total As Decimal
                <ProtoMember(102)>  Public Fecha As Date?
                <ProtoMember(103)>  Public Comprables As Decimal
                <ProtoMember(104)>  Public Comprados As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Proveedor = o("Proveedor").STR
              Me.Total = o("Total").DEC
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Comprables = o("Comprables").DEC
              Me.Comprados = o("Comprados").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanalComprasPresupuestosDeCompraEnTramite_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanalComprasPresupuestosDeCompraEnTramite_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class