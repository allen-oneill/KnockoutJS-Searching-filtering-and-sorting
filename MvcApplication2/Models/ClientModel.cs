using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MvcApplication2.Models
{
    public class ClientList 
    {
    public List<ClientModel> Clients {get; set;}

    public ClientList()
    {
        Clients = new List<ClientModel>();
    }

    }

    public class ClientModel
    {
        public string ClientName { get; set; }
        public string Address { get; set; }
        public string SortCode { get; set; }
        public string Phone { get; set; }
        public bool Active { get; set; }
        public int Status { get; set; }


        public List<ClientModel> GetClients()
        {
            List<ClientModel> rslt = new List<ClientModel>();
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                int r = rnd.Next(1, 100);
                int z = rnd.Next(1, 5000);
                string rndText = "";
                for (int x = 0; x < 6; x++)
                {
                    char rndChar = (char)rnd.Next(65, 90);
                    rndText += rndChar.ToString();
                }

                ClientModel cm = new ClientModel();
                cm.ClientName = i.ToString() + " Name ";
                cm.Address = rndText + z.ToString() + " Address " + i.ToString();
                cm.Phone = "Phone " + r.ToString();
                int p1 = rnd.Next(0, 2);
                if (p1 == 0)
                    cm.Active = true;
                else cm.Active = false;
                
                cm.Status = rnd.Next(0, 4);

                switch (cm.Status) {

                    case 0:  
                            cm.SortCode = "AAA";
                            break;
                    case 1:  
                            cm.SortCode = "BBB";
                            break;
                    case 2: 
                            cm.SortCode = "CCC";
                            break;
                    case 3: 
                            cm.SortCode = "DDD";
                            break;
                    case 4: 
                            cm.SortCode = "EEE";
                            break;
                    default :
                            break;
                
                }

                rslt.Add(cm);
            }
            return rslt;        
        }

    }

    
}