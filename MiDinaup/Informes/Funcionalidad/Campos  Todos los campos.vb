﻿Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposTodosLosCamposC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposTodosLosCampos_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("3475cb8a-117d-4d10-bd6a-7a66e401000c"))
              me.ID = new GUID("3475cb8a-117d-4d10-bd6a-7a66e401000c")
              me.Titulo  = "Campos > Todos los campos"
          End sub
          <ProtoContract>
          Public Class CamposTodosLosCampos_FilaC
                <ProtoMember(100)>  Public SeccionAgrupada As String
                <ProtoMember(101)>  Public Formato As Decimal
                <ProtoMember(102)>  Public Titulo As String
                <ProtoMember(103)>  Public EtiquetaAbreviada As String
                <ProtoMember(104)>  Public FechaAltaSistema As DateTime
                <ProtoMember(105)>  Public Rolespecialdefuncionalidad As Decimal
                <ProtoMember(106)>  Public Copiarnombrealagregarrelacion As Boolean
                <ProtoMember(107)>  Public SeccionrelacionadaID As Guid
                <ProtoMember(108)>  Public Eliminado As Boolean
                <ProtoMember(109)>  Public Indexado As Boolean
                <ProtoMember(110)>  Public EsBase As Boolean
                <ProtoMember(111)>  Public ID As Guid
                <ProtoMember(112)>  Public Etiqueta As String
                <ProtoMember(113)>  Public VisibleRI As Boolean
                <ProtoMember(114)>  Public Seccion As String
                <ProtoMember(115)>  Public FechaUltimaModificacion As DateTime
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.SeccionAgrupada = o("SeccionAgrupada").STR
              Me.Formato = o("Formato").DEC
              Me.Titulo = o("Titulo").STR
              Me.EtiquetaAbreviada = o("EtiquetaAbreviada").STR
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.Rolespecialdefuncionalidad = o("Rolespecialdefuncionalidad").DEC
              Me.Copiarnombrealagregarrelacion = o("Copiarnombrealagregarrelacion").BOOL
              Me.SeccionrelacionadaID = o("SeccionrelacionadaID").ToGuid
              Me.Eliminado = o("Eliminado").BOOL
              Me.Indexado = o("Indexado").BOOL
              Me.EsBase = o("EsBase").BOOL
              Me.ID = o("ID").ToGuid
              Me.Etiqueta = o("Etiqueta").STR
              Me.VisibleRI = o("VisibleRI").BOOL
              Me.Seccion = o("Seccion").STR
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposTodosLosCampos_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposTodosLosCampos_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class