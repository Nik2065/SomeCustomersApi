using Common;
using DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace SomeCustomersApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    //[Authorize]
    public class CustomerController : ControllerBase
    {
        public CustomerController(ScDataContext context)
        {
            _db = context;
            _logger = NLog.LogManager.GetCurrentClassLogger();
        }

        private ScDataContext _db { get; set; }
        public NLog.Logger _logger { get; set; }


        /// <summary>
        /// 1. Получение списка клиентов для текущего пользователя (последние просмотренные). 
        /// По каждому клиенту, передается краткая информация, достаточная для отображения списка.
        /// </summary>
        [HttpGet]
        [Route("[action]")]
        public void GetCurrentCustomerClients()
        {
            //из авторизации берем клиента
            //var id = User.Identity.Name;


        }

        /// <summary>
        /// 2. Получение списка клиентов для взаимосвязанной группы, по коду группы. 
        /// Аналогично, краткая информация по каждому клиенту.
        /// </summary>
        [HttpGet]
        [Route("[action]")]
        public void GetClientsByCode(string code)
        {

        }

        /// <summary>
        /// 3. Получение информации по клиенту, необходимой для отображения карточки клиента. 
        /// Помимо подробных данных, включает метаданные карточки, необходимые для ее динамической отрисовки.
        /// </summary>
        /// <param name="id"></param>
        [HttpGet]
        [Route("[action]")]
        public void GetClient(Guid id)
        {
            //TODO: проверяем что данный customer имеет доступ к этому клиенту
            //через глобальный фильтр запросов
        }


        /// <summary>
        /// 4. Изменение параметров клиента.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<ActionResult> SaveClient(ClientDto client)
        {
            var result = new BaseResponse { Success = true, Message = "Данные сохранены" };

            try
            {
                //TODO: проверяем что данный customer имеет доступ к этому клиенту
                //через глобальный фильтр запросов


                //
                //если нет доступов или не найден то
                //result.Success = false;
                //result.Message = Клиент не найден;
                //NotFound(result);


            }
            catch (Exception ex)
            {
                _logger.Error(ex);
                result.Success = false;
                result.Message = "Ошибка при сохранении данных клиента";
            }

            return Ok(result);
        }

    }
}
