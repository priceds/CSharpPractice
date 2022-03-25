using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MultiDemo.Models;
using System.Collections.Generic;
using System.Linq;

namespace MultiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {

        private readonly BikeStoresContext _context;
        public OrderController(BikeStoresContext context)
        {
            this._context = context;
        }
        [HttpGet]
        [Route("api/v1/GetAllOrders")]
        public IActionResult GetAllOrder()
        {
            return new ObjectResult(_context.Orders.ToList());
        }

        [HttpGet]
        [Route("api/v1/GetTopTenOrders")]
        public IActionResult GetTopTenOrders() //IEnumerable Demo
        {
            IEnumerable<Order> allOrders = _context.Orders.ToList();
            IEnumerable<Order> topTenOrders = allOrders.Take(10).ToList();
            return new ObjectResult(topTenOrders);
        }


        [HttpGet]
        [Route("api/v1/GetOrdersWAShipDate")]
        public IActionResult GetOrdersWOShipDate() //IQueryable Demo
        {
            IQueryable<Order> orderWOShipDate = _context.Orders.Where(order => order.ShippedDate == null);
            orderWOShipDate = orderWOShipDate.Take(5);
            return new ObjectResult(orderWOShipDate);
        }

    }
}
