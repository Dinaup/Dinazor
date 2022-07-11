Imports DinaNETCore
Partial Public Class InformesD
  Partial Public Class FuncionalidadD
      Public Class InformeDePruebasJSONConPreguntasC
          Inherits DinaNETCore.APID.APID_InformeC
          Public Filas As New List(Of InformeDePruebasJSONConPreguntas_FilaC)
          Public TokenCambios As Guid
          Sub new(ValorASumar As Decimal)
              Parametros = New APID.Funcion_Informe_Consultar_ParametrosC( ("d7ddd2ae-8aed-4b23-a866-ab310da969f4"))
              me.ID = new GUID("d7ddd2ae-8aed-4b23-a866-ab310da969f4")
              me.Titulo  = "Informe de pruebas JSON Con preguntas"
              Agregar_Respuesta("ValorASumar",ValorASumar)
          End sub
          <ProtoBuf.ProtoContract>
          Public Class InformeDePruebasJSONConPreguntas_FilaC
                <ProtoBuf.ProtoMember(100)>  Public TextoPrincipal As String
                <ProtoBuf.ProtoMember(101)>  Public ValorDecimal As Decimal
                <ProtoBuf.ProtoMember(102)>  Public DecimalConSuma As Decimal
              Sub new(O As Newtonsoft.Json.Linq.JToken)
              Me.TextoPrincipal = o("TextoPrincipal").STR
              Me.ValorDecimal = o("ValorDecimal").DEC
              Me.DecimalConSuma = o("DecimalConSuma").DEC
              End Sub
              Sub new()
              End Sub
          End Class
          Public Overrides Sub CargarRespuesta()
                Dim Creando_Filas As New List(Of InformeDePruebasJSONConPreguntas_FilaC)
                If Respuesta IsNot Nothing AndAlso Respuesta.Listado IsNot Nothing AndAlso Respuesta.Listado.Filas IsNot Nothing Then
                    For Each Actual In Respuesta.Listado.Filas
                        If Actual Is Nothing Then Continue For
                        Dim N = New InformeDePruebasJSONConPreguntas_FilaC(Actual)
                        Creando_Filas.Add(N)
                    Next
                End If
                Me.Filas = Creando_Filas
                TokenCambios = Guid.NewGuid
            End Sub
      End Class
  End Class
End Class