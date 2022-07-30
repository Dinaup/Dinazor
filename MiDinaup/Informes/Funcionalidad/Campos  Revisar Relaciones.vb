Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisarRelacionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisarRelaciones_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("c822a1d0-f17f-48f6-adc3-62c4ca619720"))
              me.ID = new GUID("c822a1d0-f17f-48f6-adc3-62c4ca619720")
              me.Titulo  = "Campos > Revisar Relaciones"
          End sub
          <ProtoContract>
          Public Class CamposRevisarRelaciones_FilaC
                <ProtoMember(100)>  Public Relacionesbase As Boolean
                <ProtoMember(101)>  Public FechaAltaSistema As DateTime
                <ProtoMember(102)>  Public Seccionrelacionada As String
                <ProtoMember(103)>  Public Seccion As String
                <ProtoMember(104)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(105)>  Public ID As Guid
                <ProtoMember(106)>  Public Etiqueta As String
                <ProtoMember(107)>  Public CampoPR As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Relacionesbase = o("Relacionesbase").BOOL
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Seccionrelacionada = o("Seccionrelacionada").STR
              Me.Seccion = o("Seccion").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.Etiqueta = o("Etiqueta").STR
              Me.CampoPR = o("CampoPR").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisarRelaciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposRevisarRelaciones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class