Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EventosDeAgendasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EventosDeAgendas_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EventosDeAgendas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New EventosDeAgendas_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("6f3d56a0-0a46-422f-b1dc-ee9cd433cc82"))
              me.ID = new GUID("6f3d56a0-0a46-422f-b1dc-ee9cd433cc82")
              me.Titulo  = "Eventos de agendas"
          End sub
          Public Class EventosDeAgendas_FilaC
              Public Tipodeevento As String
              Public Desde As Date?
              Public Hasta As Date?
              Public Ocupa As Boolean
              Public TipodeAgenda As String
              Public Agenda As String
              Public EventoseccionID As Guid
              Public TipodeAgendaID As Guid
              Public Evento As String
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
          End Class
      End Class
  End Class
End Class