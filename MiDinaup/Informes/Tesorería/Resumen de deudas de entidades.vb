Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class TesoreriaD
      Public Class ResumenDeDeudasDeEntidadesC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of ResumenDeDeudasDeEntidades_FilaC)
          Public TokenCambios As Guid
          Sub new()
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("6ee559e5-c1af-49a1-8065-929100faee8f"))
              me.ID = new GUID("6ee559e5-c1af-49a1-8065-929100faee8f")
              me.Titulo  = "Resumen de deudas de entidades"
          End sub
          <ProtoContract>
          Public Class ResumenDeDeudasDeEntidades_FilaC
                <ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoMember(101)>  Public DebeaEmpresa As Decimal
                <ProtoMember(102)>  Public Empresaledebe As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.DebeaEmpresa = o("DebeaEmpresa").DEC
              Me.Empresaledebe = o("Empresaledebe").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of ResumenDeDeudasDeEntidades_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New ResumenDeDeudasDeEntidades_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class