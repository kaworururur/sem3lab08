using System.ComponentModel;
using System.Xml.Serialization;
namespace lab08;

class Program
{
    static void Main()
    {
        Animal animal = new Animal
        {
            Country = 123,
            HideFromOtherAnimals = 0,
            Name = "Lion",
            WhatAnimal = 52,
            Classification = eClassificationAnimal.Herbivores
        };
        //serialization
        XmlSerializer serializer = new XmlSerializer(typeof(Animal));
        using (FileStream fileStream = new FileStream("1.xml", FileMode.Create))
        {
            serializer.Serialize(fileStream, animal);
            Console.WriteLine("xml generated");
        }
        XmlSerializer serializer_another = new XmlSerializer(typeof(Animal));
        using (FileStream fileStream = new FileStream("1.xml", FileMode.Open))
        {
            Animal deserializator = (Animal)serializer.Deserialize(fileStream);
            Console.WriteLine(deserializator.ToString());
        }

    }
}













public class Animal
{
    public eClassificationAnimal Classification;
    public int Country { get; set; }
    public int HideFromOtherAnimals { get; set; }
    public string Name { get; set; }
    public int WhatAnimal { get; set; }

    public Animal() { }

    public void Deconstruct()
    {
        throw new System.NotImplementedException();
    }

    public void GetClassificationAnimal()
    {
        throw new System.NotImplementedException();
    }

    public void GetFavouriteFood()
    {
        throw new System.NotImplementedException();
    }

    public void SayHello()
    {
        throw new System.NotImplementedException();
    }

    public override string ToString()
    {
        return $"Name: {Name}, Classification: {Classification}, HideFromOtherAnimals: {HideFromOtherAnimals}, WhatAnimal: {WhatAnimal}";
    }
}

public enum eClassificationAnimal
{
    Herbivores,
    Carnivores,
    Omnivores
}

public enum eFavouriteFood
{
    Meat,
    Plants,
    Everything
}

public class Cow : Animal
{
    public Cow()
    {
        throw new System.NotImplementedException();
    }

    public void GetFavouriteFood()
    {
        throw new System.NotImplementedException();
    }

    public void SayHello()
    {
        throw new System.NotImplementedException();
    }
}
public class Lion : Animal
{
    public Lion()
    {
        throw new System.NotImplementedException();
    }

    public void GetFavouriteFood()
    {
        throw new System.NotImplementedException();
    }

    public void SayHello()
    {
        throw new System.NotImplementedException();
    }
}
public class Pig : Animal
{
    public Pig()
    {
        throw new System.NotImplementedException();
    }

    public void GetFavouriteFood()
    {
        throw new System.NotImplementedException();
    }

    public void SayHello()
    {
        throw new System.NotImplementedException();
    }
}


//using System.IO.Compression;
//class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("введите путь для поиска файла");
//        string searchingPath = Console.ReadLine();
//        Console.WriteLine("введите название файла");
//        string fileName = Console.ReadLine();
//        string[] files = Directory.GetFiles(searchingPath, fileName, SearchOption.AllDirectories);
//        if (files.Length > 0)
//        {
//            Console.WriteLine($"файл найден : {files[0]}");
//            using (FileStream fileStream = new FileStream(files[0], FileMode.Open, FileAccess.Read))
//            {
//                using (StreamReader sr = new StreamReader(fileStream))
//                {
//                    string fileContent = sr.ReadToEnd();
//                    Console.WriteLine($"содержимое файла : \n\t{fileContent}");
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("файл не найден");
//        }
//        Console.WriteLine("хотите сжать найденный файл? (y/n)");
//        string response = Console.ReadLine();
//        if (response == "y")
//        {
//            string compressedPath = $"{files[0]}.zip";
//            using (FileStream fileStream_1 = new FileStream(files[0], FileMode.Open))
//            {
//                using (FileStream fileStream_2 = new FileStream(compressedPath, FileMode.Create))
//                {
//                    using (GZipStream compress_stream = new GZipStream(fileStream_2, CompressionMode.Compress))
//                    {
//                        fileStream_1.CopyTo(compress_stream);
//                        Console.WriteLine("файл сжат и сохранен в ту же директорию");
//                    }
//                }
//            }
//        }
//    }
//}