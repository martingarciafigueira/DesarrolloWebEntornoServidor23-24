namespace Ejemplo.Controllers
{
    public class EvenNumberConstraint : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            int result;
            return (values.ContainsKey(routeKey) && (int.TryParse(values[routeKey] as string, out result)) && result % 2 == 0);
        }
    }

}
