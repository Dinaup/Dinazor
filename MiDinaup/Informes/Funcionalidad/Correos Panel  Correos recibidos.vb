Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CorreosPanelCorreosRecibidosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CorreosPanelCorreosRecibidos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("29a7080c-3969-4c53-97f9-6b3782a403ba"))
              me.ID = new GUID("29a7080c-3969-4c53-97f9-6b3782a403ba")
              me.Titulo  = "Correos Panel > Correos recibidos"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class CorreosPanelCorreosRecibidos_FilaC
                <ProtoBuf.ProtoMember(100)>  Public EstadoIcono As Integer
                <ProtoBuf.ProtoMember(101)>  Public Recibido As Date?
                <ProtoBuf.ProtoMember(102)>  Public Asunto As String
                <ProtoBuf.ProtoMember(103)>  Public Estado As String
                <ProtoBuf.ProtoMember(104)>  Public Buzon As String
                <ProtoBuf.ProtoMember(105)>  Public Autor As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.EstadoIcono = ctype(o("EstadoIcono").INT(0), EnumEstadoDeTramiteE)
              Me.Recibido = o("Recibido").ToDateTime_UTC
              Me.Asunto = o("Asunto").STR
              Me.Estado = o("Estado").STR
              Me.Buzon = o("Buzon").STR
              Me.Autor = o("Autor").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CorreosPanelCorreosRecibidos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CorreosPanelCorreosRecibidos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class