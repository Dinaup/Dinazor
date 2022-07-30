Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class CatalogosD
      Public Class PreciosDeVentaSinImpuestosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PreciosDeVentaSinImpuestos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e3e60413-446e-485c-a7e7-506cbb8de5dc"))
              me.ID = new GUID("e3e60413-446e-485c-a7e7-506cbb8de5dc")
              me.Titulo  = "Precios de Venta (Sin Impuestos)"
          End Sub
            <ProtoBuf.ProtoContract>
            Public Class PreciosDeVentaSinImpuestos_FilaC
                <ProtoBuf.ProtoMember(100)> Public Producto As String
                <ProtoBuf.ProtoMember(101)> Public Impuesto As String
                <ProtoBuf.ProtoMember(102)> Public PrecioconDescuentos As Decimal
                <ProtoBuf.ProtoMember(103)> Public Catalogo As String
                <ProtoBuf.ProtoMember(104)> Public PreciosinDescuentos As Decimal
                <ProtoBuf.ProtoMember(105)> Public Limitaraubicacion As String
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
                Dim Creando_Filas As New List(Of PreciosDeVentaSinImpuestos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PreciosDeVentaSinImpuestos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class