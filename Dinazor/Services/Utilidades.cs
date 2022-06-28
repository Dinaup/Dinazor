using Radzen;

namespace Dinazor.Services
{
    public class Utilidades
    {




        public  static  void AplicarConfiguracionDeCargaAInforme(LoadDataArgs RadZen_Args, DinaNETCore.APID.APID_InformeC Dinaup_Informe)
        {



            if (Dinaup_Informe.Parametros_Predeterminados == null)
            {
                Dinaup_Informe.GuardarConfiguracionActualComoPredeterminada();
            }
            Dinaup_Informe.CargarConfiguracionPredeterminada();


            var Top = 20;
            var Pagina = 1;


            if (RadZen_Args.Top != null)
            {
                Top = RadZen_Args.Top.Value;
            }
            if (RadZen_Args.Skip != null && RadZen_Args.Skip > 0)
            {
                Pagina = (int)(RadZen_Args.Skip / RadZen_Args.Top) + 1;
            }



            if (RadZen_Args.Filters != null)
            {
                foreach (var filtroactual in RadZen_Args.Filters)
                {


                    if (filtroactual.FilterOperator == FilterOperator.Equals)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "=", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.NotEquals)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "<>", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.LessThan)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "<", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.LessThanOrEquals)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "<=", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.GreaterThan)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, ">", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.GreaterThanOrEquals)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, ">=", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.Contains)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "contiene", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.StartsWith)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "empiezapor", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.EndsWith)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "terminapor", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.DoesNotContain)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "nocontiene", filtroactual.FilterValue.ToString());

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.IsNull)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "=", "''");

                    }
                    else if (filtroactual.FilterOperator == FilterOperator.IsNotNull)
                    {
                        Dinaup_Informe.Agregar_Filtro(filtroactual.Property, "<>", "''");

                    }



                }


            }



            if (RadZen_Args.Sorts != null)
            {
                foreach (var orden in RadZen_Args.Sorts)
                {
                    Dinaup_Informe.Agregar_Ordenar(orden.Property, orden.SortOrder == SortOrder.Descending);
                }
            }


            Dinaup_Informe.Parametros.PaginaActual = Pagina;
            Dinaup_Informe.Parametros.ResultadosPorPagina = Top;


        }









    }
}
