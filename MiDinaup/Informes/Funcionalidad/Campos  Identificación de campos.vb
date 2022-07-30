Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposIdentificacionDeCamposC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposIdentificacionDeCampos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("da9d6090-5d9d-42a2-a91b-e410e1e0d61a"))
              me.ID = new GUID("da9d6090-5d9d-42a2-a91b-e410e1e0d61a")
              me.Titulo  = "Campos > Identificación de campos"
          End sub
          <ProtoContract>
          Public Class CamposIdentificacionDeCampos_FilaC
                <ProtoMember(100)>  Public Seccion As String
                <ProtoMember(101)>  Public Etiqueta As String
                <ProtoMember(102)>  Public ID As Guid
                <ProtoMember(103)>  Public EtiquetaAbreviada As String
                <ProtoMember(104)>  Public Pestana As String
                <ProtoMember(105)>  Public NombrePR As String
                <ProtoMember(106)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(107)>  Public FechaAltaSistema As DateTime
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Seccion = o("Seccion").STR
              Me.Etiqueta = o("Etiqueta").STR
              Me.ID = o("ID").ToGuid
              Me.EtiquetaAbreviada = o("EtiquetaAbreviada").STR
              Me.Pestana = o("Pestana").STR
              Me.NombrePR = o("NombrePR").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposIdentificacionDeCampos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposIdentificacionDeCampos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class