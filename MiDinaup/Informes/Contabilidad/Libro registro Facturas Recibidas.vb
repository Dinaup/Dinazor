Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class LibroRegistroFacturasRecibidasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of LibroRegistroFacturasRecibidas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("020452eb-5181-46dc-85c0-beed3adbd774"))
              me.ID = new GUID("020452eb-5181-46dc-85c0-beed3adbd774")
              me.Titulo  = "Libro registro Facturas Recibidas"
          End sub
          <ProtoContract>
          Public Class LibroRegistroFacturasRecibidas_FilaC
                <ProtoMember(100)>  Public FechaExpedicion As Date?
                <ProtoMember(101)>  Public NFactura As String
                <ProtoMember(102)>  Public BaseImponibleBI As Decimal
                <ProtoMember(103)>  Public IVAIVA As Decimal
                <ProtoMember(104)>  Public CuotaIVAIVA As Decimal
                <ProtoMember(105)>  Public Proveedor As String
                <ProtoMember(106)>  Public NIF As String
                <ProtoMember(107)>  Public TipodeRecargoEqRE As Decimal
                <ProtoMember(108)>  Public CuotaRecargoEqRE As Decimal
                <ProtoMember(109)>  Public TotalFactura As Decimal
                <ProtoMember(110)>  Public CodigoPais As String
                <ProtoMember(111)>  Public Tipo As String
                <ProtoMember(112)>  Public Tiporetencion As String
                <ProtoMember(113)>  Public Retencion As Decimal
                <ProtoMember(114)>  Public Retencion2 As Decimal
                <ProtoMember(115)>  Public FechaOperacion As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaExpedicion = o("FechaExpedicion").ToDate
              Me.NFactura = o("NFactura").STR
              Me.BaseImponibleBI = o("BaseImponibleBI").DEC
              Me.IVAIVA = o("IVAIVA").DEC
              Me.CuotaIVAIVA = o("CuotaIVAIVA").DEC
              Me.Proveedor = o("Proveedor").STR
              Me.NIF = o("NIF").STR
              Me.TipodeRecargoEqRE = o("TipodeRecargoEqRE").DEC
              Me.CuotaRecargoEqRE = o("CuotaRecargoEqRE").DEC
              Me.TotalFactura = o("TotalFactura").DEC
              Me.CodigoPais = o("CodigoPais").STR
              Me.Tipo = o("Tipo").STR
              Me.Tiporetencion = o("Tiporetencion").STR
              Me.Retencion = o("Retencion").DEC
              Me.Retencion2 = o("Retencion2").DEC
              Me.FechaOperacion = o("FechaOperacion").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of LibroRegistroFacturasRecibidas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New LibroRegistroFacturasRecibidas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class