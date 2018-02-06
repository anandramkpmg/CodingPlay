using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class CustomerOrder
    {
        public static  void Task()
        {
            List<Order> orders = new List<Order>
            {
                new Order(1,1,1,100),
                new Order(2,2,2,200)
            };


            List<OrderDetail> orderDetail = new List<OrderDetail>()
            {
                new OrderDetail(100, 1, 1, 1, 555, 123),
                new OrderDetail(200, 2, 1, 1, 1555, 123)
            };

            // gets the produxct details
            var q =  from order in orders
                join orderDet in orderDetail on order.OrderId equals orderDet.OrderId
                select new {order.OrderId, orderDet.ProductId};

            // multiple joins
            var q1 = from order in orders
                join orddet in orderDetail on
                new {order.OrderId, order.UserId} equals new {orddet.OrderId, orddet.UserId}
                select new {order.OrderNo};

            //Fetch all unique Order id from orderdetail table with unit price > 1000 
            var q3 = from od in orderDetail
                where od.UnitPrice > 1000
                group od by od.OrderId
                into grp
                orderby grp.Key
                select grp;

            //Fetch all unique ordered &userid from orderdetail table having unitprice > 1000, 
            var q4 = from od in orderDetail
                where od.UnitPrice > 1000
                group od by new {od.OrderId, od.UserId};

            //Fetch Order number & all details under each order in hierarchical result set. 

            var q5 = from order in orders
                join detail in orderDetail on order.OrderId equals detail.OrderId  
                into grp
                select new { OrderId = order.OrderId, OrderDetaila = grp };

            foreach (var a in q5)
            {

            }
        }
    }

    public class Order
    {
        public Order(int orderId, int userId, int orderNo, int totalPrice)
        {
            OrderId = orderId;
            UserId = userId;
            OrderNo = orderNo;
            TotalPrice = totalPrice;
        }

        public int OrderId { get; }

        public int UserId { get; }

        public int OrderNo { get; }

        public int TotalPrice { get; }
    }

    public class OrderDetail
    {
        public OrderDetail(int orderDetailId, int orderId, int userId, int productId, int unitPrice, int qty)
        {
            OrderDetailId = orderDetailId;
            OrderId = orderId;
            UserId = userId;
            ProductId = productId;
            UnitPrice = unitPrice;
            Qty = qty;
        }

        public int OrderDetailId { get; }

        public int OrderId { get; }

        public int UserId { get; }

        public int ProductId { get; }

        public int UnitPrice { get; }

        public int Qty { get; }
    }
}
