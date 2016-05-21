using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services.Description;

namespace TutorialMVC70486.Models
{
    public class EscuelaInterceptor :DbCommandInterceptor
    {
        public override void ReaderExecuting(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            Trace.TraceInformation(command.CommandText);
            base.ReaderExecuting(command, interceptionContext);
        }

        public override void ReaderExecuted(DbCommand command, DbCommandInterceptionContext<DbDataReader> interceptionContext)
        {
            Trace.TraceInformation(command.CommandText);
            base.ReaderExecuted(command, interceptionContext);
        }
    }
}