Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanalComprasComprasOrdinariasEnTramiteC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanalComprasComprasOrdinariasEnTramite_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("2ff864ee-d9b1-4ddb-aa39-61d2af918a89"))
              me.ID = new GUID("2ff864ee-d9b1-4ddb-aa39-61d2af918a89")
              me.Titulo  = "Panal Compras > Compras Ordinarias (En trámite)"
          End sub
          <ProtoContract>
          Public Class PanalComprasComprasOrdinariasEnTramite_FilaC
                <ProtoMember(100)>  Public Proveedor As String
                <ProtoMember(101)>  Public Entrados As Decimal
                <ProtoMember(102)>  Public Total As Decimal
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public Totalapagar As Decimal
                <ProtoMember(105)>  Public Aentrar As Decimal
                <ProtoMember(106)>  Public Pagada As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Proveedor = o("Proveedor").STR
              Me.Entrados = o("Entrados").DEC
              Me.Total = o("Total").DEC
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Totalapagar = o("Totalapagar").DEC
              Me.Aentrar = o("Aentrar").DEC
              Me.Pagada = o("Pagada").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanalComprasComprasOrdinariasEnTramite_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanalComprasComprasOrdinariasEnTramite_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class