using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace ExternalApiClient
{
    public class ExternalClient
    {
        public ExternalClient(string apiUrl)
        {
            _apiUrl = apiUrl;
        }

        public string _apiUrl;

        /// <summary>
        /// Получаем результат
        /// Если формат понятен - можно десериализовать в объект
        /// </summary>
        /// <returns></returns>
        public async Task<string> GetSomeOtherData()
        {
            /*{
              "userId": 1,
              "id": 1,
              "title": "delectus aut autem",
              "completed": false
            }*/

            var result = "";

            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_apiUrl);
                HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync();
                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        result = reader.ReadToEnd();
                    }
                }
                response.Close();
            }
            catch (Exception ex)
            {
                //пишем ошибку в лог
                //сообщаем системе-получателю что случилась ошибка

            }

            return result;

        }

    }
}
