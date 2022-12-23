using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FinanceBusiness.ViewModels
{
    public class AddServiceViewModel
    {
        public string ServiceName { get; set; }
        public string ShortServiceDesc { get; set; }
        public string LongServiceDesc { get; set; }
        public HttpPostedFileBase ServiceImg { get; set; }
    }
}