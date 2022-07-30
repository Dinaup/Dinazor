Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class PrincipalesD
      Public Class ImpuestosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of Impuestos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("4bb6c67a-c3cd-025e-0589-414ec79c8ca3"))
              me.ID = new GUID("4bb6c67a-c3cd-025e-0589-414ec79c8ca3")
              me.Titulo  = "Impuestos"
          End sub
          <ProtoContract>
          Public Class Impuestos_FilaC
                <ProtoMember(100)>  Public Compras As String
                <ProtoMember(101)>  Public Ventas As String
                <ProtoMember(102)>  Public Valor As Decimal
                <ProtoMember(103)>  Public Etiqueta As String
                <ProtoMember(104)>  Public Activo As Boolean
                <ProtoMember(105)>  Public RecargoEquivalencia As Decimal
                <ProtoMember(106)>  Public TextoPrincipal As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Compras = o("Compras").STR
              Me.Ventas = o("Ventas").STR
              Me.Valor = o("Valor").DEC
              Me.Etiqueta = o("Etiqueta").STR
              Me.Activo = o("Activo").BOOL
              Me.RecargoEquivalencia = o("RecargoEquivalencia").DEC
              Me.TextoPrincipal = o("TextoPrincipal").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of Impuestos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New Impuestos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class