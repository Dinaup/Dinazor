Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ObligacionesDePresentacionDeModelosHistoricoDePresentacionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ObligacionesDePresentacionDeModelosHistoricoDePresentaciones_FilaC)
          Public TokenCambios As Guid
          Sub new(PlazoDePresentacion As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("4b0affba-2264-44f4-8d27-3cddb9405ad1"))
              me.ID = new GUID("4b0affba-2264-44f4-8d27-3cddb9405ad1")
              me.Titulo  = "Obligaciones de presentación de modelos > Histórico de presentaciones"
              Agregar_Respuesta("PlazoDePresentacion",PlazoDePresentacion)
          End Sub
            <ProtoContract>
            Public Class ObligacionesDePresentacionDeModelosHistoricoDePresentaciones_FilaC
                <ProtoMember(100)>  Public Empleado As String
                <ProtoMember(101)>  Public Estado As String
                <ProtoMember(102)>  Public Modelo As String
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public Estadodetramitacion As Integer
                <ProtoMember(105)>  Public ModeloIcono As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empleado = o("Empleado").STR
              Me.Estado = o("Estado").STR
              Me.Modelo = o("Modelo").STR
              Me.Fecha = o("Fecha").ToDate
              Me.Estadodetramitacion = ctype(o("Estadodetramitacion").INT(0), EnumEstadoDeTramiteE)
              Me.ModeloIcono = o("ModeloIcono").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ObligacionesDePresentacionDeModelosHistoricoDePresentaciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ObligacionesDePresentacionDeModelosHistoricoDePresentaciones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class