Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class LibroRegistroFacturasEmitidasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of LibroRegistroFacturasEmitidas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("eadff30e-2db8-45d6-9888-10030fb1cb15"))
              me.ID = new GUID("eadff30e-2db8-45d6-9888-10030fb1cb15")
              me.Titulo  = "Libro registro Facturas Emitidas"
          End sub
          <ProtoContract>
          Public Class LibroRegistroFacturasEmitidas_FilaC
                <ProtoMember(100)>  Public FechaExpedicion As Date?
                <ProtoMember(101)>  Public IVA As Decimal
                <ProtoMember(102)>  Public BaseImponibleBI As Decimal
                <ProtoMember(103)>  Public CuotaIVA As Decimal
                <ProtoMember(104)>  Public TotalFactura As Decimal
                <ProtoMember(105)>  Public Serie As String
                <ProtoMember(106)>  Public NFactura As String
                <ProtoMember(107)>  Public Nombre As String
                <ProtoMember(108)>  Public CodigoPais As String
                <ProtoMember(109)>  Public Tipo As String
                <ProtoMember(110)>  Public NIF As String
                <ProtoMember(111)>  Public Retencion As Decimal
                <ProtoMember(112)>  Public Tiporetencion As String
                <ProtoMember(113)>  Public Retencion2 As Decimal
                <ProtoMember(114)>  Public FechaOperacion As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaExpedicion = o("FechaExpedicion").ToDate
              Me.IVA = o("IVA").DEC
              Me.BaseImponibleBI = o("BaseImponibleBI").DEC
              Me.CuotaIVA = o("CuotaIVA").DEC
              Me.TotalFactura = o("TotalFactura").DEC
              Me.Serie = o("Serie").STR
              Me.NFactura = o("NFactura").STR
              Me.Nombre = o("Nombre").STR
              Me.CodigoPais = o("CodigoPais").STR
              Me.Tipo = o("Tipo").STR
              Me.NIF = o("NIF").STR
              Me.Retencion = o("Retencion").DEC
              Me.Tiporetencion = o("Tiporetencion").STR
              Me.Retencion2 = o("Retencion2").DEC
              Me.FechaOperacion = o("FechaOperacion").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of LibroRegistroFacturasEmitidas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New LibroRegistroFacturasEmitidas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class