﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RunHuaAdmin.Services;

namespace RunHuaAdmin.Controllers
{
    public class OrdersController : Controller
    {
        OrderService _service = new OrderService();
        // GET: Orders
        public ActionResult OrderIndex()
        {
            
            return View(_service.GetOrderService());
        }
    }
}