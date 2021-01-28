using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WorkSpaceApplication2.Repositories;

namespace WorkSpaceApplication2.MiddelWares
{
    public class LoggerMiddelWare
    {
        private RequestDelegate nextDelegate;
        public LoggerMiddelWare(RequestDelegate next)
        {
            this.nextDelegate = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {

            if (httpContext.Request.Path.ToString()=="/")
            {
                await nextDelegate.Invoke(httpContext);
            }
            var controllerName = httpContext.Request.Path.ToString().Split("/".ToCharArray())[1];
            var actionName = httpContext.Request.Path.ToString().Split("/".ToCharArray())[2]; 

            var username = httpContext.Request.Query["username"].ToString();

            MyLoggerRepository myLogger = new MyLoggerRepository();
            myLogger.Add(controllerName, actionName, username);
            await nextDelegate.Invoke(httpContext);

            //bool isActiveTime = new ActiveTimeData().IsNowInActiveTime();
            //if (isActiveTime)
            //{
            //    await nextDelegate.Invoke(httpContext);
            //}
            //else
            //{
            //    httpContext.Response.StatusCode = 403;
            //}
        }
    }
}
