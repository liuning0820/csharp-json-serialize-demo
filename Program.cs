using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

//Need to add reference to System.Web.Extension.dll
using System.Web.Script.Serialization;

//Another way to serialize json into C# using newtonsoft.Json
using Newtonsoft.Json;

namespace csharp_json_serialize_demo
{
    class Program
    {
        static void Main(string[] args)
        {

            String jsonString = File.ReadAllText("demo.json");

            ////Serializes using JavaScriptSerializer
            JavaScriptSerializer serializer = new JavaScriptSerializer();

            Person person = serializer.Deserialize<Person>(jsonString);

            Console.WriteLine(person.ToString());

            //Serializes using Newtonsoft.Json.JsonConvert
            Person person2 = JsonConvert.DeserializeObject<Person>(jsonString);

            Console.WriteLine(person2.ToString());

        }
    }


    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \n Age: {1}",Name,Age);
        }
    }
}
