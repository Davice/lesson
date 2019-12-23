using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lesson2.service
{
    /// <summary>
    /// Summary description for DataHandler
    /// </summary>
    public class DataHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            string data = "{'Results': [{'ID': '1','Project': 'Microsoft','Task': '小冰标注','DeadLine': '2019/12/13','QA': 'QA1'},{'ID': '2','Project': 'Microsoft','Task': '小冰标注','DeadLine': '2019/12/13','QA': 'QA1'}]}";

            context.Response.Write(data);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}