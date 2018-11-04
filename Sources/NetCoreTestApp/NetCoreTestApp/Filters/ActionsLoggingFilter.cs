using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging.Debug;
using System;
using System.Collections.Generic;

namespace NetCoreTestApp.Filters
{
    public class ActionsLoggingFilter : Attribute, IActionFilter
    {
        private readonly ILogger _logger;
        private readonly bool _logParams;

        public ActionsLoggingFilter(ILoggerFactory loggerFactory, bool logParams)
        {
            _logger = loggerFactory.CreateLogger<ActionsLoggingFilter>();
            _logParams = logParams;
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {
            string actionName = context.ActionDescriptor.DisplayName;

            _logger.LogDebug($"Action {actionName} executed at: {DateTime.Now}");
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var strParams = context.ActionDescriptor.Parameters.Count > 0  && _logParams? 
                FormatParams(context.ActionDescriptor.Parameters, context.RouteData) : string.Empty;

            string actionName = context.ActionDescriptor.DisplayName;

            _logger.LogDebug($"Action {actionName} has started execution at: {DateTime.Now} {strParams}");
        }

        private string FormatParams(IList<ParameterDescriptor> parameters, RouteData routeData)
        {
            string formattedStr = "with params: ";

            foreach (var param in parameters)
            {
                formattedStr += $"name[{param.Name}] value[{routeData.Values[param.Name]}]";
            }

            return formattedStr;
        }
    }
}
