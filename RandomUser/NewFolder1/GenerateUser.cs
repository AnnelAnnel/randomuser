using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RandomUser.NewFolder1
{
    public class GenerateUser
    {

        public static results GetUser()
        {

           
                ServiceUser sc = new ServiceUser("https://randomuser.me/api?results=1");
                string tmp = sc.GetJsonString();
                var users = JsonConvert.DeserializeObject<Users>(tmp);
            return users.results[0];
        }
    }
}
