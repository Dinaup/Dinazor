Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class Modelo193SimplificadoPerceptoresC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of Modelo193SimplificadoPerceptores_FilaC)
          Public TokenCambios As Guid
          Sub new(Fecha_Desde As Date, Fecha_Hasta As Date)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("f7fd0080-1ae3-48b2-9323-694ba0f48176"))
              me.ID = new GUID("f7fd0080-1ae3-48b2-9323-694ba0f48176")
              me.Titulo  = "Modelo 193 Simplificado - Perceptores"
              Agregar_Respuesta("Fecha_Desde",Fecha_Desde)
              Agregar_Respuesta("Fecha_Hasta",Fecha_Hasta)
          End sub
          <ProtoContract>
          Public Class Modelo193SimplificadoPerceptores_FilaC
                <ProtoMember(100)>  Public NIF As String
                <ProtoMember(101)>  Public Provincia As String
                <ProtoMember(102)>  Public Retencion As Decimal
                <ProtoMember(103)>  Public Percepcion As Decimal
                <ProtoMember(104)>  Public RetencionImporte As Decimal
                <ProtoMember(105)>  Public NIFRepLegal As String
                <ProtoMember(106)>  Public Nombre As String
                <ProtoMember(107)>  Public Clave As String
                <ProtoMember(108)>  Public Naturaleza As String
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.NIF = o("NIF").STR
              Me.Provincia = o("Provincia").STR
              Me.Retencion = o("Retencion").DEC
              Me.Percepcion = o("Percepcion").DEC
              Me.RetencionImporte = o("RetencionImporte").DEC
              Me.NIFRepLegal = o("NIFRepLegal").STR
              Me.Nombre = o("Nombre").STR
              Me.Clave = o("Clave").STR
              Me.Naturaleza = o("Naturaleza").STR
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of Modelo193SimplificadoPerceptores_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New Modelo193SimplificadoPerceptores_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class