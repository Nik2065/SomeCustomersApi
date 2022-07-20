using DataAccessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeCustomersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Authorize]
    public class CustomerController : ControllerBase
    {
        public CustomerController(ScDataContext context)
        {
            _db = context;
        }

        private ScDataContext _db { get; set; }


        /// <summary>
        /// 1. Получение списка клиентов
        /// </summary>
        [HttpGet]
        [Route("[action]")]
        public void GetCurrentCustomerClients()
        {
            //из авторизации берем клиента

        }
    }
}
