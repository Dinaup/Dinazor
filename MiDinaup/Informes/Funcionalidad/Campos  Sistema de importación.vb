﻿Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class CamposSistemaDeImportacionC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of CamposSistemaDeImportacion_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("48ba9aac-c44b-463d-a513-024f046f4c3a"))
              me.ID = new GUID("48ba9aac-c44b-463d-a513-024f046f4c3a")
              me.Titulo  = "Campos > Sistema de importación"
          End sub
          <ProtoContract>
          Public Class CamposSistemaDeImportacion_FilaC
                <ProtoMember(100)>  Public Etiqueta As String
                <ProtoMember(101)>  Public Formato As Decimal
                <ProtoMember(102)>  Public ID As Guid
                <ProtoMember(103)>  Public FechaUltimaModificacion As DateTime
                <ProtoMember(104)>  Public Obligatorio As Boolean
                <ProtoMember(105)>  Public FechaAltaSistema As DateTime
                <ProtoMember(106)>  Public IconoID As Guid
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Etiqueta = o("Etiqueta").STR
              Me.Formato = o("Formato").DEC
              Me.ID = o("ID").ToGuid
              Me.FechaUltimaModificacion = o("FechaUltimaModificacion").ToDateTime_UTC
              Me.Obligatorio = o("Obligatorio").BOOL
              Me.FechaAltaSistema = o("FechaAltaSistema").ToDateTime_UTC
              Me.IconoID = o("IconoID").ToGuid
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of CamposSistemaDeImportacion_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New CamposSistemaDeImportacion_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class