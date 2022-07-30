Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class VentasD
      Public Class ListadoDeImporteTotalDeVentasPorEmpleadoFiltradoPorFechaC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ListadoDeImporteTotalDeVentasPorEmpleadoFiltradoPorFecha_FilaC)
          Public TokenCambios As Guid
          Sub new(Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("0a94b55d-b262-4c15-86f0-2407503c2f2b"))
              me.ID = new GUID("0a94b55d-b262-4c15-86f0-2407503c2f2b")
              me.Titulo  = "Listado de Importe total de ventas por empleado | Filtrado por fecha"
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class ListadoDeImporteTotalDeVentasPorEmpleadoFiltradoPorFecha_FilaC
                <ProtoMember(100)>  Public Empleado As String
                <ProtoMember(101)>  Public Total As Decimal
                <ProtoMember(102)>  Public Foto As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Total = o("Total").DEC
              Me.Foto = o("Foto").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ListadoDeImporteTotalDeVentasPorEmpleadoFiltradoPorFecha_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ListadoDeImporteTotalDeVentasPorEmpleadoFiltradoPorFecha_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class