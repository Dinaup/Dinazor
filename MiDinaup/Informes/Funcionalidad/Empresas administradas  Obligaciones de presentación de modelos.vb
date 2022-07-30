Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class EmpresasAdministradasObligacionesDePresentacionDeModelosC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of EmpresasAdministradasObligacionesDePresentacionDeModelos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("50adc3db-aedc-4721-9872-95578be97b22"))
              me.ID = new GUID("50adc3db-aedc-4721-9872-95578be97b22")
              me.Titulo  = "Empresas administradas > Obligaciones de presentación de modelos"
          End sub
          <ProtoContract>
          Public Class EmpresasAdministradasObligacionesDePresentacionDeModelos_FilaC
                <ProtoMember(100)>  Public Responsabilidad As String
                <ProtoMember(101)>  Public Inicio As Date?
                <ProtoMember(102)>  Public Vigente As Boolean
                <ProtoMember(103)>  Public Proxima As Date?
                <ProtoMember(104)>  Public Documento As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Responsabilidad = o("Responsabilidad").STR
              Me.Inicio = o("Inicio").ToDate
              Me.Vigente = o("Vigente").BOOL
              Me.Proxima = o("Proxima").ToDate
              Me.Documento = o("Documento").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of EmpresasAdministradasObligacionesDePresentacionDeModelos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New EmpresasAdministradasObligacionesDePresentacionDeModelos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class