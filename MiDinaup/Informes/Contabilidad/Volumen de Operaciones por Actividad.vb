Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class VolumenDeOperacionesPorActividadC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of VolumenDeOperacionesPorActividad_FilaC)
          Public TokenCambios As Guid
          Sub new(Ejercicio As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e5afd343-a543-4310-89cd-90c2aef8e46b"))
              me.ID = new GUID("e5afd343-a543-4310-89cd-90c2aef8e46b")
              me.Titulo  = "Volumen de Operaciones por Actividad"
              Agregar_Respuesta("Ejercicio",Ejercicio)
          End sub
          <ProtoContract>
          Public Class VolumenDeOperacionesPorActividad_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Inicio As Date?
                <ProtoMember(102)>  Public Fin As Date?
                <ProtoMember(103)>  Public Baja As Boolean
                <ProtoMember(104)>  Public Codigo As String
                <ProtoMember(105)>  Public Epigrafe As String
                <ProtoMember(106)>  Public VolOperaciones As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Inicio = o("Inicio").ToDate
              Me.Fin = o("Fin").ToDate
              Me.Baja = o("Baja").BOOL
              Me.Codigo = o("Codigo").STR
              Me.Epigrafe = o("Epigrafe").STR
              Me.VolOperaciones = o("VolOperaciones").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of VolumenDeOperacionesPorActividad_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New VolumenDeOperacionesPorActividad_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class