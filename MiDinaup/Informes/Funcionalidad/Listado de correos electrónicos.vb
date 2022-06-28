Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class ListadoDeCorreosElectronicosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ListadoDeCorreosElectronicos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ListadoDeCorreosElectronicos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New ListadoDeCorreosElectronicos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d8586be4-74b1-4750-9b5a-ea00079cbc35"))
              me.ID = new GUID("d8586be4-74b1-4750-9b5a-ea00079cbc35")
              me.Titulo  = "Listado de correos electrónicos"
          End sub
          Public Class ListadoDeCorreosElectronicos_FilaC
              Public Asunto As String
              Public Autor As String
              Public Fecha As Date?
              Public De As String
              Public Para As String
              Public Adjuntos As Integer
              Public Estado As String
              Public EstadoIcono As Integer
              Public Tipodeestado As Integer
              Public Buzon As String
              Public Empresa As String
              Public Tipo As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Asunto = o("Asunto").STR
              Me.Autor = o("Autor").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.De = o("De").STR
              Me.Para = o("Para").STR
              Me.Adjuntos = o("Adjuntos").INT
              Me.Estado = o("Estado").STR
              Me.EstadoIcono = o("EstadoIcono").INT
              Me.Tipodeestado = o("Tipodeestado").INT
              Me.Buzon = o("Buzon").STR
              Me.Empresa = o("Empresa").STR
              Me.Tipo = o("Tipo").INT
              End Sub
          End Class
      End Class
  End Class
End Class