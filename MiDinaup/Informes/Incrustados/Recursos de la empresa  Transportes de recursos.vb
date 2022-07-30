Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class IncrustadosD
      Public Class RecursosDeLaEmpresaTransportesDeRecursosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of RecursosDeLaEmpresaTransportesDeRecursos_FilaC)
          Public TokenCambios As Guid
          Sub new(Recurso As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("28d9bd0e-2062-4028-9bed-0ebf3fdecc08"))
              me.ID = new GUID("28d9bd0e-2062-4028-9bed-0ebf3fdecc08")
              me.Titulo  = "Recursos de la empresa > Transportes de recursos"
              Agregar_Respuesta("Recurso",Recurso)
          End sub
          <ProtoContract>
          Public Class RecursosDeLaEmpresaTransportesDeRecursos_FilaC
                <ProtoMember(100)>  Public Conductor As String
                <ProtoMember(101)>  Public Destino As String
                <ProtoMember(102)>  Public Inicio As Date?
                <ProtoMember(103)>  Public Fin As Date?
                <ProtoMember(104)>  Public Estado As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Conductor = o("Conductor").STR
              Me.Destino = o("Destino").STR
              Me.Inicio = o("Inicio").ToDateTime_UTC
              Me.Fin = o("Fin").ToDateTime_UTC
              Me.Estado = o("Estado").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of RecursosDeLaEmpresaTransportesDeRecursos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New RecursosDeLaEmpresaTransportesDeRecursos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class