Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EmpleadosConMayorImporteDeVentasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EmpleadosConMayorImporteDeVentas_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("1210a6b5-0622-4109-9b21-f1c3248b8b79"))
              me.ID = new GUID("1210a6b5-0622-4109-9b21-f1c3248b8b79")
              me.Titulo  = "Empleados con mayor importe de ventas"
          End sub
          <ProtoContract>
          Public Class EmpleadosConMayorImporteDeVentas_FilaC
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
                Dim Creando_Filas As New List(Of EmpleadosConMayorImporteDeVentas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EmpleadosConMayorImporteDeVentas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class