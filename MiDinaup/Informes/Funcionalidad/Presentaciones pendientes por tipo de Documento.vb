Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class PresentacionesPendientesPorTipoDeDocumentoC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of PresentacionesPendientesPorTipoDeDocumento_FilaC)
          Public TokenCambios As Guid
          Sub new(Documento As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("5779f4fd-1f55-4e06-95b5-775508fdd8d6"))
              me.ID = new GUID("5779f4fd-1f55-4e06-95b5-775508fdd8d6")
              me.Titulo  = "Presentaciones pendientes por tipo de Documento"
              Agregar_Respuesta("Documento",Documento)
          End sub
          <ProtoContract>
          Public Class PresentacionesPendientesPorTipoDeDocumento_FilaC
                <ProtoMember(100)>  Public Documento As String
                <ProtoMember(101)>  Public Ejercicio As String
                <ProtoMember(102)>  Public Estado As String
                <ProtoMember(103)>  Public Plazo As String
                <ProtoMember(104)>  Public Estadodetramitacion As Integer
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Documento = o("Documento").STR
              Me.Ejercicio = o("Ejercicio").STR
              Me.Estado = o("Estado").STR
              Me.Plazo = o("Plazo").STR
              Me.Estadodetramitacion = ctype(o("Estadodetramitacion").INT(0), EnumEstadoDeTramiteE)
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of PresentacionesPendientesPorTipoDeDocumento_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New PresentacionesPendientesPorTipoDeDocumento_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class