

using System.Text.Json;
using System.Text.Json.Serialization;

namespace master_csharp.Assembly.Serialization
{
    public class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
    }

    public class Person
    {
        [JsonPropertyName("full_name")] // Attribute لتغيير اسم الـ JSON key
        public string Name { get; set; }

        public int Age { get; set; }

        public List<string> Hobbies { get; set; }

        public Address HomeAddress { get; set; } // nested object
    }
    class SerializaionExample
    {
        
        public static void Use()
        {
            // === إنشاء object ===
            Person person = new Person
            {
                Name = "Ali",
                Age = 25,
                Hobbies = new List<string> { "Reading", "Coding", "Swimming" },
                HomeAddress = new Address
                {
                    Street = "123 Main St",
                    City = "Cairo"
                }
            };

            // === Serialization (Object → JSON string) ===
            string json = JsonSerializer.Serialize(person, new JsonSerializerOptions { WriteIndented = true });
            Console.WriteLine("=== Serialized JSON ===");
            Console.WriteLine(json);

            // === Deserialization (JSON string → Object) ===
            Person deserializedPerson = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine("\n=== Deserialized Object ===");
            Console.WriteLine($"Name: {deserializedPerson.Name}");
            Console.WriteLine($"Age: {deserializedPerson.Age}");
            Console.WriteLine("Hobbies: " + string.Join(", ", deserializedPerson.Hobbies));
            Console.WriteLine($"Address: {deserializedPerson.HomeAddress.Street}, {deserializedPerson.HomeAddress.City}");
        }
        
    }
}
