Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisarValoresHeredadosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisarValoresHeredados_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("7feedc93-2be4-4c71-92ad-acd074a1e6ec"))
              me.ID = new GUID("7feedc93-2be4-4c71-92ad-acd074a1e6ec")
              me.Titulo  = "Campos > Revisar valores heredados"
          End sub
          <ProtoContract>
          Public Class CamposRevisarValoresHeredados_FilaC
                <ProtoMember(100)>  Public FechaAltaSistema As DateTime
                <ProtoMember(101)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(102)>  Public CampoHerencia As String
                <ProtoMember(103)>  Public ID As Guid
                <ProtoMember(104)>  Public Seccion As String
                <ProtoMember(105)>  Public SeccionHerencia As String
                <ProtoMember(106)>  Public Etiqueta As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.CampoHerencia = o("CampoHerencia").STR
              Me.ID = o("ID").ToGuid
              Me.Seccion = o("Seccion").STR
              Me.SeccionHerencia = o("SeccionHerencia").STR
              Me.Etiqueta = o("Etiqueta").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisarValoresHeredados_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposRevisarValoresHeredados_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class