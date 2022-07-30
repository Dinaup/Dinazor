Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanalPresentacionDeDocumentosObligacionesDePresentacionDeModelosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanalPresentacionDeDocumentosObligacionesDePresentacionDeModelos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("8ad9b448-fb24-40de-afdc-5497c6855b12"))
              me.ID = new GUID("8ad9b448-fb24-40de-afdc-5497c6855b12")
              me.Titulo  = "Panal Presentación de Documentos > Obligaciones de presentación de modelos"
          End sub
          <ProtoContract>
          Public Class PanalPresentacionDeDocumentosObligacionesDePresentacionDeModelos_FilaC
                <ProtoMember(100)>  Public Proximapresentacion As Date?
                <ProtoMember(101)>  Public Plazo As String
                <ProtoMember(102)>  Public Documento As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Proximapresentacion = o("Proximapresentacion").ToDate
              Me.Plazo = o("Plazo").STR
              Me.Documento = o("Documento").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanalPresentacionDeDocumentosObligacionesDePresentacionDeModelos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanalPresentacionDeDocumentosObligacionesDePresentacionDeModelos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class