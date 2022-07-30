Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposAutorrellenadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposAutorrellenado_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ec0ea9c2-828c-4c06-bd4a-86616e4350d1"))
              me.ID = new GUID("ec0ea9c2-828c-4c06-bd4a-86616e4350d1")
              me.Titulo  = "Campos > Autorrellenado"
          End sub
          <ProtoContract>
          Public Class CamposAutorrellenado_FilaC
                <ProtoMember(100)>  Public Seccion As String
                <ProtoMember(101)>  Public Valor5 As String
                <ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(103)>  Public ID As Guid
                <ProtoMember(104)>  Public Valor4 As String
                <ProtoMember(105)>  Public Valor2 As String
                <ProtoMember(106)>  Public FechaAltaSistema As DateTime
                <ProtoMember(107)>  Public Valor1 As String
                <ProtoMember(108)>  Public Valor3 As String
                <ProtoMember(109)>  Public Etiqueta As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.Valor5 = o("Valor5").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.Valor4 = o("Valor4").STR
              Me.Valor2 = o("Valor2").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Valor1 = o("Valor1").STR
              Me.Valor3 = o("Valor3").STR
              Me.Etiqueta = o("Etiqueta").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposAutorrellenado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposAutorrellenado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class