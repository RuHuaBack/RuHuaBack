using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RunHuaAdmin.Models;
using RunHuaAdmin.Repository;

namespace RunHuaAdmin.Services
{
    public class OrderService
    {
        OrderRepository _repo = new OrderRepository();
        public List<OrderViewModel> GetOrderService()
        {
            var tempList = _repo.GetAllOrder();
            List<OrderViewModel> newResult = new List<OrderViewModel>();
            int o = 0;
            foreach (var i in tempList)
            {
                newResult.Add(new OrderViewModel(){CompanyName = i.CompanyName, StudentName = tempList[o].StudentName, Color = i.Color});
            }

            return null;
        }
    }
}