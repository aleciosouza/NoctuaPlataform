using NoctuaCore.Interfaces;
using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.IO;

namespace NoctuaCore.Repositories
{
    public class UserRepositoryFirebase : IUserRepository
    {

        private static readonly HttpClient client = new HttpClient();

        public string Insert(User user)
        {
            string json = Newtonsoft.Json.JsonConvert.SerializeObject(user);
            

            WebRequest request = WebRequest.CreateHttp("https://noctua-plataform.firebaseio.com/.json");
            request.Method = HttpMethod.Post.ToString();
            request.ContentType = "application/json";
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            WebResponse response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();

            return null;
        }

        public string Delete(int id)
        {
            throw new NotImplementedException();
        }

        public string Update(int id, User user)
        {

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(user);

            WebRequest request = WebRequest.CreateHttp("https://noctua-plataform.firebaseio.com/-KyGEOI0_6DAuccDR1uP/.json");
            request.Method = HttpMethod.Put.ToString();
            request.ContentType = "application/json";
            byte[] buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            WebResponse response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();

            return null;
        }

        public User getUser(int id)
        {
            throw new NotImplementedException();
        }

    }
}
