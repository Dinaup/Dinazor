Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class BuzonesDeCorreoCorreosRecibidosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BuzonesDeCorreoCorreosRecibidos_FilaC)
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BuzonesDeCorreoCorreosRecibidos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Creando_Filas.Add(New BuzonesDeCorreoCorreosRecibidos_FilaC(Actual))
                    Next
                End If
                Me.Filas = Creando_Filas
            End Sub
          Sub new(Buzon As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("109aa628-e1e3-4640-845a-81aa0e7d9cb9"))
              me.ID = new GUID("109aa628-e1e3-4640-845a-81aa0e7d9cb9")
              me.Titulo  = "Buzones de correo > Correos Recibidos"
              Agregar_Respuesta("Buzon",Buzon)
          End sub
          Public Class BuzonesDeCorreoCorreosRecibidos_FilaC
              Public Empresa As String
              Public Autor As String
              Public Asunto As String
              Public Fecha As Date?
              Public Archivos As Integer
              Public AsuntoIcono As Integer
              Public Correodeorigen As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empresa = o("Empresa").STR
              Me.Autor = o("Autor").STR
              Me.Asunto = o("Asunto").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Archivos = o("Archivos").INT
              Me.AsuntoIcono = o("AsuntoIcono").INT
              Me.Correodeorigen = o("Correodeorigen").STR
              End Sub
          End Class
      End Class
  End Class
End Class