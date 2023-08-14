using System.Reflection;
using System.Web.Mvc;

namespace WebApplication_DotNet_MVC.Filters
{
    public class CustomActionFilter : ActionMethodSelectorAttribute
    {
        public override bool IsValidForRequest(ControllerContext controllerContext, MethodInfo methodInfo)
        {
            return controllerContext.HttpContext.Request.IsAjaxRequest();
        }
    }
}