using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace RC.Infra
{
    public class RCController : Controller
    {
        public RCAlert Alert
        {
            get
            {
                if (TempData["Alert"] != null)
                    if (TempData["Alert"] is RCAlert)
                        return TempData["Alert"] as RCAlert; ;

                return null;
            }
            set
            {
                TempData["Alert"] = value;
            }
        }

    }
}

