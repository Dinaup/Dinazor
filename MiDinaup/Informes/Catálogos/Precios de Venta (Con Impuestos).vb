Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class CatalogosD
      Public Class PreciosDeVentaConImpuestosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PreciosDeVentaConImpuestos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("17aa73f5-d172-42fa-9cb1-95cc504eb2ae"))
              me.ID = new GUID("17aa73f5-d172-42fa-9cb1-95cc504eb2ae")
              me.Titulo  = "Precios de Venta (Con Impuestos)"
          End Sub
            <ProtoContract>
            Public Class PreciosDeVentaConImpuestos_FilaC
                <ProtoMember(100)> Public Producto As String
                <ProtoMember(101)> Public Impuesto As String
                <ProtoMember(102)> Public PrecioconDescuentos As Decimal
                <ProtoMember(103)> Public Catalogo As String
                <ProtoMember(104)> Public PreciosinDescuentos As Decimal
                <ProtoMember(105)> Public Limitaraubicacion As String
                Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Producto = o("Producto").STR
              Me.Impuesto = o("Impuesto").STR
              Me.PrecioconDescuentos = o("PrecioconDescuentos").DEC
              Me.Catalogo = o("Catalogo").STR
              Me.PreciosinDescuentos = o("PreciosinDescuentos").DEC
              Me.Limitaraubicacion = o("Limitaraubicacion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PreciosDeVentaConImpuestos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PreciosDeVentaConImpuestos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class