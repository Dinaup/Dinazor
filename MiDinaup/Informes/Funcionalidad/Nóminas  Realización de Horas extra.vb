Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class NominasRealizacionDeHorasExtraC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of NominasRealizacionDeHorasExtra_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of NominasRealizacionDeHorasExtra_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New NominasRealizacionDeHorasExtra_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("0baa399b-e54f-456b-a3d9-eab77884204c"))
              me.ID = new GUID("0baa399b-e54f-456b-a3d9-eab77884204c")
              me.Titulo  = "Nóminas > Realización de Horas extra"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          Public Class NominasRealizacionDeHorasExtra_FilaC
              Public Fecha As Date?
              Public Fuerzamayor As Boolean
              Public Importe As Decimal
              Public Horas As Decimal
              Public RetHora As Decimal
              Public RetTotal As Decimal
              Public Estado As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Fecha = o("Fecha").ToDate
              Me.Fuerzamayor = o("Fuerzamayor").BOOL
              Me.Importe = o("Importe").DEC
              Me.Horas = o("Horas").DEC
              Me.RetHora = o("RetHora").DEC
              Me.RetTotal = o("RetTotal").DEC
              Me.Estado = o("Estado").INT
              End Sub
          End Class
      End Class
  End Class
End Class