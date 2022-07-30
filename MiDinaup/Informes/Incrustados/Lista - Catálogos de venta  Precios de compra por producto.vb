Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class IncrustadosD
      Public Class ListaCatalogosDeVentaPreciosDeCompraPorProductoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ListaCatalogosDeVentaPreciosDeCompraPorProducto_FilaC)
          Public TokenCambios As Guid
          Sub new(Producto As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("8402dcc7-a0a5-4273-be98-6e8aac40a52d"))
              me.ID = new GUID("8402dcc7-a0a5-4273-be98-6e8aac40a52d")
              me.Titulo  = "Lista - Catálogos de venta > Precios de compra por producto"
              Agregar_Respuesta("Producto",Producto)
          End sub
          <ProtoContract>
          Public Class ListaCatalogosDeVentaPreciosDeCompraPorProducto_FilaC
                <ProtoMember(100)>  Public Pedidominimo As Decimal
                <ProtoMember(101)>  Public Proveedor As String
                <ProtoMember(102)>  Public PrecioUnd As Decimal
                <ProtoMember(103)>  Public Catalogo As String
                <ProtoMember(104)>  Public Pedidomaximo As Decimal
                <ProtoMember(105)>  Public Advertencia As String
                <ProtoMember(106)>  Public PrecioUnd2 As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Pedidominimo = o("Pedidominimo").DEC
              Me.Proveedor = o("Proveedor").STR
              Me.PrecioUnd = o("PrecioUnd").DEC
              Me.Catalogo = o("Catalogo").STR
              Me.Pedidomaximo = o("Pedidomaximo").DEC
              Me.Advertencia = o("Advertencia").STR
              Me.PrecioUnd2 = o("PrecioUnd2").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ListaCatalogosDeVentaPreciosDeCompraPorProducto_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ListaCatalogosDeVentaPreciosDeCompraPorProducto_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class