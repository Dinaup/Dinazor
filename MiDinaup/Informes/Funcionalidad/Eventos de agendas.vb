Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EventosDeAgendasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EventosDeAgendas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("6f3d56a0-0a46-422f-b1dc-ee9cd433cc82"))
              me.ID = new GUID("6f3d56a0-0a46-422f-b1dc-ee9cd433cc82")
              me.Titulo  = "Eventos de agendas"
          End sub
          <ProtoBuf.ProtoContract>
          Public Class EventosDeAgendas_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Tipodeevento As String
                <ProtoBuf.ProtoMember(101)>  Public Desde As Date?
                <ProtoBuf.ProtoMember(102)>  Public Hasta As Date?
                <ProtoBuf.ProtoMember(103)>  Public Ocupa As Boolean
                <ProtoBuf.ProtoMember(104)>  Public TipodeAgenda As String
                <ProtoBuf.ProtoMember(105)>  Public Agenda As String
                <ProtoBuf.ProtoMember(106)>  Public EventoseccionID As Guid
                <ProtoBuf.ProtoMember(107)>  Public TipodeAgendaID As Guid
                <ProtoBuf.ProtoMember(108)>  Public Evento As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Tipodeevento = o("Tipodeevento").STR
              Me.Desde = o("Desde").ToDateTime_UTC
              Me.Hasta = o("Hasta").ToDateTime_UTC
              Me.Ocupa = o("Ocupa").BOOL
              Me.TipodeAgenda = o("TipodeAgenda").STR
              Me.Agenda = o("Agenda").STR
              Me.EventoseccionID = o("EventoseccionID").ToGuid
              Me.TipodeAgendaID = o("TipodeAgendaID").ToGuid
              Me.Evento = o("Evento").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EventosDeAgendas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EventosDeAgendas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class