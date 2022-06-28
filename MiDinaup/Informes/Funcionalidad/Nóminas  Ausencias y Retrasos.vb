Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class NominasAusenciasYRetrasosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of NominasAusenciasYRetrasos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of NominasAusenciasYRetrasos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New NominasAusenciasYRetrasos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Empleado As Guid, Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("7c79a937-bca1-4c26-b343-7375ebdebebf"))
              me.ID = new GUID("7c79a937-bca1-4c26-b343-7375ebdebebf")
              me.Titulo  = "Nóminas > Ausencias y Retrasos"
              Agregar_Respuesta("Empleado",Empleado)
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          Public Class NominasAusenciasYRetrasos_FilaC
              Public Importe As Decimal
              Public Fecha As Date?
              Public Horas As Decimal
              Public Deduccion As Decimal
              Public Resolucion As Integer
              Public RetrasoEntrada As Integer
              Public Minutossalida As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Importe = o("Importe").DEC
              Me.Fecha = o("Fecha").ToDate
              Me.Horas = o("Horas").DEC
              Me.Deduccion = o("Deduccion").DEC
              Me.Resolucion = o("Resolucion").INT
              Me.RetrasoEntrada = o("RetrasoEntrada").INT
              Me.Minutossalida = o("Minutossalida").INT
              End Sub
          End Class
      End Class
  End Class
End Class