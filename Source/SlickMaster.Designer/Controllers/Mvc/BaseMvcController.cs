﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SlickMaster.Designer.Controllers.Mvc
{
    [OutputCache(NoStore = true, Duration = 0, VaryByParam = "*")]
    public abstract class BaseMvcController : Controller
    {
    }
}