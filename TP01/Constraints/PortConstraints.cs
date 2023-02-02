namespace TP01.Constraints
{
    public class PortConstraints : IRouteConstraint
    {
        public bool Match(HttpContext? httpContext, IRouter? route, string routeKey, RouteValueDictionary values, RouteDirection routeDirection)
        {
            return httpContext?.Connection.LocalPort == 44380;
        }
    }
}
