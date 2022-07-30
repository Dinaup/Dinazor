Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class CatalogosD
      Public Class PreciosDeCompraConImpuestosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PreciosDeCompraConImpuestos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("3408cd9a-d285-49c3-9cf0-ed850c2edc38"))
              me.ID = new GUID("3408cd9a-d285-49c3-9cf0-ed850c2edc38")
              me.Titulo  = "Precios de Compra (Con Impuestos)"
          End Sub
            <ProtoBuf.ProtoContract>
            Public Class PreciosDeCompraConImpuestos_FilaC
                <ProtoMember(100)> Public Producto As String
                <ProtoMember(101)> Public Impuesto As String
                <ProtoMember(102)> Public Imagen As Guid
                <ProtoMember(103)> Public CosteconDescuentos As Decimal
                <ProtoMember(104)> Public CostessinDescuentos As Decimal
                <ProtoMember(105)> Public Proveedor As String
                <ProtoMember(106)> Public Catalogo As String
                Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Producto = o("Producto").STR
              Me.Impuesto = o("Impuesto").STR
              Me.Imagen = o("Imagen").ToGuid
              Me.CosteconDescuentos = o("CosteconDescuentos").DEC
              Me.CostessinDescuentos = o("CostessinDescuentos").DEC
              Me.Proveedor = o("Proveedor").STR
              Me.Catalogo = o("Catalogo").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PreciosDeCompraConImpuestos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PreciosDeCompraConImpuestos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class