Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class LibroDeBienesDeInversionC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of LibroDeBienesDeInversion_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("987526da-6197-4c6f-bb2c-c84f16582ab1"))
              me.ID = new GUID("987526da-6197-4c6f-bb2c-c84f16582ab1")
              me.Titulo  = "Libro de Bienes de Inversión"
          End sub
          <ProtoContract>
          Public Class LibroDeBienesDeInversion_FilaC
                <ProtoMember(100)>  Public Baja As Boolean
                <ProtoMember(101)>  Public Amortizacion As String
                <ProtoMember(102)>  Public TextoPrincipal As String
                <ProtoMember(103)>  Public Actividad As String
                <ProtoMember(104)>  Public Coste As Decimal
                <ProtoMember(105)>  Public Facturadecompra As String
                <ProtoMember(106)>  Public Proveedor As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Baja = o("Baja").BOOL
              Me.Amortizacion = o("Amortizacion").STR
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Actividad = o("Actividad").STR
              Me.Coste = o("Coste").DEC
              Me.Facturadecompra = o("Facturadecompra").STR
              Me.Proveedor = o("Proveedor").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of LibroDeBienesDeInversion_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New LibroDeBienesDeInversion_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class