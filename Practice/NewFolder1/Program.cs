using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practice.NewFolder1;

namespace Practice
{

    //public enum RequestType { SALES, SALESIMS, STORED, MOVING, GOODS_RECEIPT};

    //public class Request
    //{
    //    public Request()
    //    {

    //    }
    //    public Request(DateTime DATA_1, DateTime DATA_2)
    //    {
    //        DATA1 = DATA_1;
    //        DATA2 = DATA_2;
    //    }
    //    public RequestType RequestType {get;set;}
    //    /// <summary>
    //    /// Код поставщика из системы SAP ERP(или BIN).
    //    /// </summary>
    //    public int KUNNR { get; set; }
    //    /// <summary>
    //    /// Код БЕ в SAP ERP. Код БЕ может быть заполнен, а может и не заполнен. 
    //    /// </summary>
    //    public int BUKRS { get; set; }
    //    /// <summary>
    //    /// Завод, в рамках которого необходимо передать данные по продажам из системы SAP ERP. 
    //    /// </summary>
    //    public int WERKS { get; set; }
    //    /// <summary>
    //    /// Дата с начало периода
    //    /// </summary>
    //    public DateTime DATA1 { get; set; }
    //    /// <summary>
    //    /// Дата конец периода
    //    /// </summary>
    //    public DateTime DATA2 { get; set; }
        
    //}

    class Program
    {
        static void Main(string[] args)
        {
            ServiceUser sc = new ServiceUser("https://randomuser.me/api?results=1");
            string tmp= sc.GetJsonString();
            Console.Write("{0}",  tmp  );
        }
    }
}
