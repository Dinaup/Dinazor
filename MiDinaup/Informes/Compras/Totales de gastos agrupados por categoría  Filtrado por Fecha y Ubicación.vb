Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ComprasD
      Public Class TotalesDeGastosAgrupadosPorCategoriaFiltradoPorFechaYUbicacionC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of TotalesDeGastosAgrupadosPorCategoriaFiltradoPorFechaYUbicacion_FilaC)
          Public TokenCambios As Guid
          Sub new(Fecha_Desde As Date, Fecha_Hasta As Date, Ubicacion As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("e9a7d3c3-9d10-403a-822c-1baaa4755ded"))
              me.ID = new GUID("e9a7d3c3-9d10-403a-822c-1baaa4755ded")
              me.Titulo  = "Totales de gastos agrupados por categoría | Filtrado por Fecha y Ubicación"
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
              Agregar_Respuesta("Ubicacion",Ubicacion)
          End sub
          <ProtoContract>
          Public Class TotalesDeGastosAgrupadosPorCategoriaFiltradoPorFechaYUbicacion_FilaC
                <ProtoMember(100)>  Public Totalgastado As Decimal
                <ProtoMember(101)>  Public TotalImpuestos As Decimal
                <ProtoMember(102)>  Public Categoria As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Totalgastado = o("Totalgastado").DEC
              Me.TotalImpuestos = o("TotalImpuestos").DEC
              Me.Categoria = o("Categoria").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of TotalesDeGastosAgrupadosPorCategoriaFiltradoPorFechaYUbicacion_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New TotalesDeGastosAgrupadosPorCategoriaFiltradoPorFechaYUbicacion_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class