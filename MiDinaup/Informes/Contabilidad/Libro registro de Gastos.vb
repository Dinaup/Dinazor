Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class LibroRegistroDeGastosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of LibroRegistroDeGastos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2733cb17-6fca-4f48-9b83-a4f06c741ead"))
              me.ID = new GUID("2733cb17-6fca-4f48-9b83-a4f06c741ead")
              me.Titulo  = "Libro registro de Gastos"
          End sub
          <ProtoContract>
          Public Class LibroRegistroDeGastos_FilaC
                <ProtoMember(100)>  Public FechaExpedicion As Date?
                <ProtoMember(101)>  Public NFactura As String
                <ProtoMember(102)>  Public NIF As String
                <ProtoMember(103)>  Public Tipo As String
                <ProtoMember(104)>  Public CodigoPais As String
                <ProtoMember(105)>  Public Proveedor As String
                <ProtoMember(106)>  Public FechaOperacion As Date?
                <ProtoMember(107)>  Public IVA As Decimal
                <ProtoMember(108)>  Public BaseImponibleBI As Decimal
                <ProtoMember(109)>  Public CuotaIVAIVA As Decimal
                <ProtoMember(110)>  Public RE As Decimal
                <ProtoMember(111)>  Public RE2 As Decimal
                <ProtoMember(112)>  Public Total As Decimal
                <ProtoMember(113)>  Public Tiporetencion As String
                <ProtoMember(114)>  Public Retencion As Decimal
                <ProtoMember(115)>  Public Retencion2 As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaExpedicion = o("FechaExpedicion").ToDate
              Me.NFactura = o("NFactura").STR
              Me.NIF = o("NIF").STR
              Me.Tipo = o("Tipo").STR
              Me.CodigoPais = o("CodigoPais").STR
              Me.Proveedor = o("Proveedor").STR
              Me.FechaOperacion = o("FechaOperacion").ToDateTime_UTC
              Me.IVA = o("IVA").DEC
              Me.BaseImponibleBI = o("BaseImponibleBI").DEC
              Me.CuotaIVAIVA = o("CuotaIVAIVA").DEC
              Me.RE = o("RE").DEC
              Me.RE2 = o("RE2").DEC
              Me.Total = o("Total").DEC
              Me.Tiporetencion = o("Tiporetencion").STR
              Me.Retencion = o("Retencion").DEC
              Me.Retencion2 = o("Retencion2").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of LibroRegistroDeGastos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New LibroRegistroDeGastos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class