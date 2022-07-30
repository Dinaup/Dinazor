Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PanalPresentacionDeDocumentosHistorialDeDocumentosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PanalPresentacionDeDocumentosHistorialDeDocumentos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e671bb87-e7d4-4557-858e-849a148aa854"))
              me.ID = new GUID("e671bb87-e7d4-4557-858e-849a148aa854")
              me.Titulo  = "Panal Presentación de Documentos > Historial de documentos"
          End sub
          <ProtoContract>
          Public Class PanalPresentacionDeDocumentosHistorialDeDocumentos_FilaC
                <ProtoMember(100)>  Public Modelo As String
                <ProtoMember(101)>  Public Estado As String
                <ProtoMember(102)>  Public Plazo As String
                <ProtoMember(103)>  Public Presentacion As Date?
                <ProtoMember(104)>  Public EstadoIcono As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Modelo = o("Modelo").STR
              Me.Estado = o("Estado").STR
              Me.Plazo = o("Plazo").STR
              Me.Presentacion = o("Presentacion").ToDate
              Me.EstadoIcono = ctype(o("EstadoIcono").INT(0), EnumEstadoDeTramiteE)
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PanalPresentacionDeDocumentosHistorialDeDocumentos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PanalPresentacionDeDocumentosHistorialDeDocumentos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class