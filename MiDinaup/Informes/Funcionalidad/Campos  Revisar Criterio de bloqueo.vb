Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisarCriterioDeBloqueoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisarCriterioDeBloqueo_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("dddd5afb-ecc2-4dbe-a250-fc130101dd56"))
              me.ID = new GUID("dddd5afb-ecc2-4dbe-a250-fc130101dd56")
              me.Titulo  = "Campos > Revisar Criterio de bloqueo"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class CamposRevisarCriterioDeBloqueo_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Seccion As String
                <ProtoBuf.ProtoMember(101)>  Public BloqueodeServidor As Decimal
                <ProtoBuf.ProtoMember(102)>  Public FechaUltimaModificacion As DateTime
                <ProtoBuf.ProtoMember(103)>  Public Etiqueta As String
                <ProtoBuf.ProtoMember(104)>  Public FechaAltaSistema As DateTime
                <ProtoBuf.ProtoMember(105)>  Public ID As Guid
                <ProtoBuf.ProtoMember(106)>  Public BloquedeTerminal As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.BloqueodeServidor = o("BloqueodeServidor").DEC
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Etiqueta = o("Etiqueta").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.ID = o("ID").ToGuid
              Me.BloquedeTerminal = o("BloquedeTerminal").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisarCriterioDeBloqueo_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposRevisarCriterioDeBloqueo_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class