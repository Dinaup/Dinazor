Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class InformeInternoPruebasUnitariasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of InformeInternoPruebasUnitarias_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of InformeInternoPruebasUnitarias_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New InformeInternoPruebasUnitarias_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("f3cfa812-2699-400a-a3ec-347ae7a7b7dc"))
              me.ID = new GUID("f3cfa812-2699-400a-a3ec-347ae7a7b7dc")
              me.Titulo  = "Informe Interno - Pruebas unitarias"
          End sub
          Public Class InformeInternoPruebasUnitarias_FilaC
              Public TextoPrincipal As String
              Public Eliminado As Boolean
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Eliminado = o("Eliminado").BOOL
              End Sub
          End Class
      End Class
  End Class
End Class