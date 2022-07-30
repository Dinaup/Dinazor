Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class APIMisTareasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of APIMisTareas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("402fa3cd-2cfd-4e9d-b7a5-49469ecf638b"))
              me.ID = new GUID("402fa3cd-2cfd-4e9d-b7a5-49469ecf638b")
              me.Titulo  = "API - Mis Tareas"
          End sub
          <ProtoContract>
          Public Class APIMisTareas_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public Estado As String
                <ProtoMember(102)>  Public Empleado As String
                <ProtoMember(103)>  Public EstadoID As Guid
                <ProtoMember(104)>  Public ID As Guid
                <ProtoMember(105)>  Public PosicionOrden As Decimal
                <ProtoMember(106)>  Public Prioridad As Integer
                <ProtoMember(107)>  Public Imagenes As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.Estado = o("Estado").STR
              Me.Empleado = o("Empleado").STR
              Me.EstadoID = o("EstadoID").ToGuid
              Me.ID = o("ID").ToGuid
              Me.PosicionOrden = o("PosicionOrden").DEC
              Me.Prioridad = ctype(o("Prioridad").INT(0), PrioridadE)
              Me.Imagenes = o("Imagenes").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of APIMisTareas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New APIMisTareas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class