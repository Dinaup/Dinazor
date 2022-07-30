Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ImportacionDePagosDeFRecibidasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ImportacionDePagosDeFRecibidas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("36a2e519-566a-407e-94d1-edd17d81a739"))
              me.ID = new GUID("36a2e519-566a-407e-94d1-edd17d81a739")
              me.Titulo  = "Importación de Pagos de F. Recibidas"
          End sub
          <ProtoContract>
          Public Class ImportacionDePagosDeFRecibidas_FilaC
                <ProtoMember(100)>  Public Proveedor As String
                <ProtoMember(101)>  Public Importe As Decimal
                <ProtoMember(102)>  Public FRecibida As String
                <ProtoMember(103)>  Public Metododepago As String
                <ProtoMember(104)>  Public Estado As Integer
                <ProtoMember(105)>  Public Destinador As String
                <ProtoMember(106)>  Public Deposito As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Proveedor = o("Proveedor").STR
              Me.Importe = o("Importe").DEC
              Me.FRecibida = o("FRecibida").STR
              Me.Metododepago = o("Metododepago").STR
              Me.Estado = ctype(o("Estado").INT(0), EnumTramitacionE)
              Me.Destinador = o("Destinador").STR
              Me.Deposito = o("Deposito").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ImportacionDePagosDeFRecibidas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ImportacionDePagosDeFRecibidas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class