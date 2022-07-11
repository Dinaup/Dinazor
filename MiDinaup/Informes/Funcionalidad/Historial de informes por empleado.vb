Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class HistorialDeInformesPorEmpleadoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of HistorialDeInformesPorEmpleado_FilaC)
          Public TokenCambios As Guid
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("cc351109-7abc-4a97-abda-6b1366914e2c"))
              me.ID = new GUID("cc351109-7abc-4a97-abda-6b1366914e2c")
              me.Titulo  = "Historial de informes por empleado"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class HistorialDeInformesPorEmpleado_FilaC
                <ProtoBuf.ProtoMember(100)>  Public Empleado As String
                <ProtoBuf.ProtoMember(101)>  Public Pagina As Integer
                <ProtoBuf.ProtoMember(102)>  Public Fecha As Date?
                <ProtoBuf.ProtoMember(103)>  Public Informe As String
                <ProtoBuf.ProtoMember(104)>  Public Duracionvisita As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Pagina = o("Pagina").INT
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Informe = o("Informe").STR
              Me.Duracionvisita = o("Duracionvisita").INT
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of HistorialDeInformesPorEmpleado_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New HistorialDeInformesPorEmpleado_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class