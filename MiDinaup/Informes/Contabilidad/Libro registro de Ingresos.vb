Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class LibroRegistroDeIngresosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of LibroRegistroDeIngresos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("234b85fd-bfbf-41c4-ae9a-7a4b8d10fcb2"))
              me.ID = new GUID("234b85fd-bfbf-41c4-ae9a-7a4b8d10fcb2")
              me.Titulo  = "Libro registro de Ingresos"
          End sub
          <ProtoContract>
          Public Class LibroRegistroDeIngresos_FilaC
                <ProtoMember(100)>  Public FechaExpedicion As Date?
                <ProtoMember(101)>  Public NFactura As String
                <ProtoMember(102)>  Public NIF As String
                <ProtoMember(103)>  Public Retencion As Decimal
                <ProtoMember(104)>  Public Retencion2 As Decimal
                <ProtoMember(105)>  Public IVA As Decimal
                <ProtoMember(106)>  Public BaseImponibleBI As Decimal
                <ProtoMember(107)>  Public Nombre As String
                <ProtoMember(108)>  Public CodigoPais As String
                <ProtoMember(109)>  Public Tipo As String
                <ProtoMember(110)>  Public Serie As String
                <ProtoMember(111)>  Public TotalFactura As Decimal
                <ProtoMember(112)>  Public Tiporetencion As String
                <ProtoMember(113)>  Public CuotaIVA As Decimal
                <ProtoMember(114)>  Public FechaOperacion As Date?
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaExpedicion = o("FechaExpedicion").ToDate
              Me.NFactura = o("NFactura").STR
              Me.NIF = o("NIF").STR
              Me.Retencion = o("Retencion").DEC
              Me.Retencion2 = o("Retencion2").DEC
              Me.IVA = o("IVA").DEC
              Me.BaseImponibleBI = o("BaseImponibleBI").DEC
              Me.Nombre = o("Nombre").STR
              Me.CodigoPais = o("CodigoPais").STR
              Me.Tipo = o("Tipo").STR
              Me.Serie = o("Serie").STR
              Me.TotalFactura = o("TotalFactura").DEC
              Me.Tiporetencion = o("Tiporetencion").STR
              Me.CuotaIVA = o("CuotaIVA").DEC
              Me.FechaOperacion = o("FechaOperacion").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of LibroRegistroDeIngresos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New LibroRegistroDeIngresos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class