﻿using System.Web;
using Bookstore.Web.Initialization;

namespace Bookstore.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            new Bootstrapper().Run();
        }
    }
}