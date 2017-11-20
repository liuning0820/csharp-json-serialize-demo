using System;
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

            //Deserializes using JavaScriptSerializer
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            Person person = serializer.Deserialize<Person>(jsonString);
            Console.WriteLine(person.ToString());

            //Deserializes using Newtonsoft.Json.JsonConvert
            Person person2 = JsonConvert.DeserializeObject<Person>(jsonString);
            Console.WriteLine(person2.ToString());

            //output to json string using JavaScriptSerializer
            Person person3 = new Person { Name = "Ben", Age = 5 };
            string outputString = serializer.Serialize(person3);
            Console.WriteLine(outputString);
            File.WriteAllText("output.json", outputString);




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
