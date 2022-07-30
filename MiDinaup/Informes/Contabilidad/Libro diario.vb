Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class ContabilidadD
      Public Class LibroDiarioC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of LibroDiario_FilaC)
          Public TokenCambios As Guid
          Sub new(Ejercicio As Guid)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("0577f728-e85f-47c4-a334-4dece3889bff"))
              me.ID = new GUID("0577f728-e85f-47c4-a334-4dece3889bff")
              me.Titulo  = "Libro diario"
              Agregar_Respuesta("Ejercicio",Ejercicio)
          End sub
          <ProtoContract>
          Public Class LibroDiario_FilaC
                <ProtoMember(100)>  Public Asiento As String
                <ProtoMember(101)>  Public Concepto As String
                <ProtoMember(102)>  Public Debe As Decimal
                <ProtoMember(103)>  Public Haber As Decimal
                <ProtoMember(104)>  Public Subcuenta As String
                <ProtoMember(105)>  Public Fecha As Date?
                <ProtoMember(106)>  Public Titulosubcuenta As String
                <ProtoMember(107)>  Public Ubicacion As String
                <ProtoMember(108)>  Public Asiento2 As String
                <ProtoMember(109)>  Public Saldo As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.Asiento = o("Asiento").STR
              Me.Concepto = o("Concepto").STR
              Me.Debe = o("Debe").DEC
              Me.Haber = o("Haber").DEC
              Me.Subcuenta = o("Subcuenta").STR
              Me.Fecha = o("Fecha").ToDate
              Me.Titulosubcuenta = o("Titulosubcuenta").STR
              Me.Ubicacion = o("Ubicacion").STR
              Me.Asiento2 = o("Asiento2").STR
              Me.Saldo = o("Saldo").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of LibroDiario_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New LibroDiario_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class