using Microsoft.JScript;
using Newtonsoft.Json.Linq;
using System;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Train_Program
{

    class Program
    {
        public static Random rand = new Random(Guid.NewGuid().ToByteArray().Sum(x => x));
        static void Main()
        {
            string s = "{" +
                        "\"OrderID\": 12345," +
                        "\"Name\": \"Иван Иванов\"," +
                        "\"Email\": \"ivanov@gmail.com\"," +
                        "\"Contents\": [" +
                        " {" +
                        " \"ProductID\": 34," +
                        " \"ProductName\": \"Sony\"," +
                        " \"Quantity\": 1" +
                        " }," +
                        " {" +
                        " \"ProductID\": 56," +
                        " \"ProductName\": \"Philips\"," +
                        " \"Quantity\": 3" +
                        " }" +
                        "]," +
                        "\"OrderCompleted\": true" +
                        "}";
            Console.WriteLine(Task12(s));
            Console.WriteLine(Task12D(Task12(s)));
        }
        static Cart Task12(string input)
        {
            var serializer = new JavaScriptSerializer();
            var cart = serializer.Deserialize<Cart>(input);
            return cart;
        }
        static string Task12D(Cart cart)
        {
            var serializer = new JavaScriptSerializer();
            string result = serializer.Serialize(cart);
            return result;
        }
    }
}


