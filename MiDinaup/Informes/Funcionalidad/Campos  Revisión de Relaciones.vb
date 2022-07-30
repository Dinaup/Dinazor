Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposRevisionDeRelacionesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposRevisionDeRelaciones_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("9926b248-878c-462e-bfc0-4cd332352c52"))
              me.ID = new GUID("9926b248-878c-462e-bfc0-4cd332352c52")
              me.Titulo  = "Campos > Revisión de Relaciones"
          End sub
          <ProtoContract>
          Public Class CamposRevisionDeRelaciones_FilaC
                <ProtoMember(100)>  Public Funcionalidadnativadecampo As Decimal
                <ProtoMember(101)>  Public Seccion As String
                <ProtoMember(102)>  Public ID As Guid
                <ProtoMember(103)>  Public FechaAltaSistema As DateTime
                <ProtoMember(104)>  Public EsBase As Boolean
                <ProtoMember(105)>  Public Icono As Guid
                <ProtoMember(106)>  Public RelacionID As Guid
                <ProtoMember(107)>  Public Nombre As String
                <ProtoMember(108)>  Public SeccionID As Guid
                <ProtoMember(109)>  Public Formato As Decimal
                <ProtoMember(110)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(111)>  Public Relacion As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Funcionalidadnativadecampo = o("Funcionalidadnativadecampo").DEC
              Me.Seccion = o("Seccion").STR
              Me.ID = o("ID").ToGuid
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.EsBase = o("EsBase").BOOL
              Me.Icono = o("Icono").ToGuid
              Me.RelacionID = o("RelacionID").ToGuid
              Me.Nombre = o("Nombre").STR
              Me.SeccionID = o("SeccionID").ToGuid
              Me.Formato = o("Formato").DEC
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Relacion = o("Relacion").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposRevisionDeRelaciones_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposRevisionDeRelaciones_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class