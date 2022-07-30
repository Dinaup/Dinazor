Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class CatalogosD
      Public Class PreciosDeCompraSinImpuestosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PreciosDeCompraSinImpuestos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("85d4f00d-2df9-412b-8070-82d04a634944"))
              me.ID = new GUID("85d4f00d-2df9-412b-8070-82d04a634944")
              me.Titulo  = "Precios de Compra (Sin Impuestos)"
          End sub
          <ProtoContract>
          Public Class PreciosDeCompraSinImpuestos_FilaC
                <ProtoMember(100)>  Public Producto As String
                <ProtoMember(101)>  Public Impuesto As String
                <ProtoMember(102)>  Public Proveedor As String
                <ProtoMember(103)>  Public Catalogo As String
                <ProtoMember(104)>  Public PreciosinDescuentos As Decimal
                <ProtoMember(105)>  Public PrecioconDescuentos As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Producto = o("Producto").STR
              Me.Impuesto = o("Impuesto").STR
              Me.Proveedor = o("Proveedor").STR
              Me.Catalogo = o("Catalogo").STR
              Me.PreciosinDescuentos = o("PreciosinDescuentos").DEC
              Me.PrecioconDescuentos = o("PrecioconDescuentos").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PreciosDeCompraSinImpuestos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PreciosDeCompraSinImpuestos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class