Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class BuzonesDeCorreoCorreosRecibidosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of BuzonesDeCorreoCorreosRecibidos_FilaC)
          Public TokenCambios As Guid
          Sub new(Buzon As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("109aa628-e1e3-4640-845a-81aa0e7d9cb9"))
              me.ID = new GUID("109aa628-e1e3-4640-845a-81aa0e7d9cb9")
              me.Titulo  = "Buzones de correo > Correos Recibidos"
              Agregar_Respuesta("Buzon",Buzon)
          End sub
          <ProtoContract>
          Public Class BuzonesDeCorreoCorreosRecibidos_FilaC
                <ProtoMember(100)>  Public Empresa As String
                <ProtoMember(101)>  Public Autor As String
                <ProtoMember(102)>  Public Asunto As String
                <ProtoMember(103)>  Public Fecha As Date?
                <ProtoMember(104)>  Public Archivos As Integer
                <ProtoMember(105)>  Public AsuntoIcono As Integer
                <ProtoMember(106)>  Public Correodeorigen As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Empresa = o("Empresa").STR
              Me.Autor = o("Autor").STR
              Me.Asunto = o("Asunto").STR
              Me.Fecha = o("Fecha").ToDateTime_UTC
              Me.Archivos = o("Archivos").INT
              Me.AsuntoIcono = ctype(o("AsuntoIcono").INT(0), EnumCorreoEntranteSalienteE)
              Me.Correodeorigen = o("Correodeorigen").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of BuzonesDeCorreoCorreosRecibidos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New BuzonesDeCorreoCorreosRecibidos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class