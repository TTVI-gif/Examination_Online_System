using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace ExaminationOnlineSystem.Filter
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class AuthorizeFilterAttribute : Attribute, IAuthorizationFilter
    {
        private string _role;

        public AuthorizeFilterAttribute(string role)
        {
            _role = role;
        }

        public void OnAuthorization(AuthorizationFilterContext context)
        {
            var user = context.HttpContext.Items["Role"].ToString();
            if (user == null || _role != user)
            {
                context.Result = new JsonResult(new { message = "UnAthorization" }) { StatusCode = StatusCodes.Status401Unauthorized };
            }
        }
    }
}
