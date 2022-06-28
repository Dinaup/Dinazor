Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposAutorrellenadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposAutorrellenado_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposAutorrellenado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New CamposAutorrellenado_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("ec0ea9c2-828c-4c06-bd4a-86616e4350d1"))
              me.ID = new GUID("ec0ea9c2-828c-4c06-bd4a-86616e4350d1")
              me.Titulo  = "Campos > Autorrellenado"
          End sub
          Public Class CamposAutorrellenado_FilaC
              Public Seccion As String
              Public Valor5 As String
              Public FechaUltimaModificacion As Date?
              Public ID As Guid
              Public Valor4 As String
              Public Valor2 As String
              Public FechaAltaSistema As Date?
              Public Valor1 As String
              Public Valor3 As String
              Public Etiqueta As String
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
          End Class
      End Class
  End Class
End Class