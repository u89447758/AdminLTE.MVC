using Microsoft.AspNetCore.Mvc;
using System;

namespace AdminLTE.MVC.Helpers
{
    public static class NavigationIndicatorHelper
    {
        // Notice the 'string?' return type. This indicates the method can return null.
        public static string? MakeActiveClass(this IUrlHelper urlHelper, string controller, string action)
        {
            try
            {
                // We use ?.ToString() to safely convert to string, which results in null if the value isn't there.
                string? controllerName = urlHelper.ActionContext.RouteData.Values["controller"]?.ToString();
                string? methodName = urlHelper.ActionContext.RouteData.Values["action"]?.ToString();

                // We check if the values are null or empty before comparing them.
                if (string.IsNullOrEmpty(controllerName) || string.IsNullOrEmpty(methodName))
                {
                    return null;
                }

                if (controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
                {
                    if (methodName.Equals(action, StringComparison.OrdinalIgnoreCase))
                    {
                        return "active";
                    }
                }

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}