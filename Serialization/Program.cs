using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Serialization
{
    //#region XML

    //class Car
    //{

    //    public int Year { get; set; }
    //    public string Model { get; set; }

    //    public string Vendor { get; set; }

    //    public override string ToString()
    //    {
    //        return $"{Model} - {Vendor} - {Year}";
    //    }
    //}

    //class Program
    //{
    //    static void Write()
    //    {
    //        List<Car> cars = new List<Car>
    //        {
    //            new Car
    //            {
    //                Model="Mustang",
    //                Vendor="Ford",
    //                Year=1964
    //            },
    //             new Car
    //            {
    //                Model="Charger",
    //                Vendor="Dodge",
    //                Year=2000
    //            },
    //              new Car
    //            {
    //                Model="Chiron",
    //                Vendor="Bugatti",
    //                Year=2021
    //            },
    //               new Car
    //            {
    //                Model="La Ferrari",
    //                Vendor="Ferrari",
    //                Year=2016
    //            }
    //        };


    //        using (var writer = new XmlTextWriter("car.xml", Encoding.UTF8))
    //        {
    //            writer.Formatting = Formatting.Indented;
    //            writer.WriteStartDocument();

    //            writer.WriteStartElement("Cars");

    //            foreach (var car in cars)
    //            {
    //                writer.WriteStartElement("Car");

    //                writer.WriteAttributeString(nameof(car.Vendor), car.Vendor);
    //                writer.WriteAttributeString(nameof(car.Vendor), car.Model);
    //                writer.WriteAttributeString(nameof(car.Year), car.Year.ToString());

    //                writer.WriteEndElement();
    //            }


    //            writer.WriteEndElement();

    //            writer.WriteEndDocument();
    //        }


    //    }


    //    static void Read()
    //    {
    //        XmlDocument doc = new XmlDocument();
    //        doc.Load("car.xml");

    //        var root = doc.DocumentElement;

    //        if (root.HasChildNodes)
    //        {
    //            foreach (XmlNode car_node in root.ChildNodes)
    //            {
    //                var c = new Car
    //                {
    //                    Vendor = car_node.Attributes[0].Value,
    //                    Model = car_node.Attributes[1].Value,
    //                    Year = int.Parse(car_node.Attributes[2].Value)
    //                };
    //                Console.WriteLine(c);
    //            }
    //        }

    //    }

    //    static void Main(string[] args)
    //    {

    //        //  Write();
    //        Read();



    //    }
    //    #endregion


    #region XMLSerialization

    //class Program
    //{

    //    static void XmlSerialize()
    //    {
    //        var army = new TranslatorArmy
    //        {
    //            Name="Step IT Academy",
    //            Location="Koroglu Rehimov 71",
    //            Translators=new List<Translator>
    //            {
    //                new Translator("Togrul", "Eliyev", 1)
    //                {
    //                    Subjects=new List<Subject>
    //                    {
    //                        new Subject
    //                        {
    //                            Name="C++",
    //                            Degree=42,
    //                            Lessons=30
    //                        },
    //                        new Subject
    //                        {
    //                            Name="C#",
    //                            Degree=30,
    //                            Lessons=50
    //                        }
    //                    }
    //                },
    //                new Translator("Ehmed", "Eliyev", 50)
    //                {
    //                    Subjects=new List<Subject>
    //                    {
    //                        new Subject
    //                        {
    //                            Name="Asp.Net",
    //                            Degree=42,
    //                            Lessons=30
    //                        },
    //                        new Subject
    //                        {
    //                            Name="HTML/CSS",
    //                            Degree=30,
    //                            Lessons=50
    //                        }
    //                    }
    //                },
    //                new Translator("Leyla", "Mammadova", 100)
    //                {
    //                    Subjects=new List<Subject>
    //                    {
    //                        new Subject
    //                        {
    //                            Name="Web Design",
    //                            Degree=42,
    //                            Lessons=30
    //                        },
    //                        new Subject
    //                        {
    //                            Name="Photoshop",
    //                            Degree=30,
    //                            Lessons=50
    //                        }
    //                    }
    //                }
    //            }
    //        };


    //        var xml = new XmlSerializer(typeof(TranslatorArmy));
    //        using(var fs=new FileStream("Translator.xml", FileMode.OpenOrCreate))
    //        {
    //            xml.Serialize(fs, army);
    //        }
    //        Console.WriteLine("Ready");
    //    }

    //    static void XmlDeserizalize()
    //    {
    //        TranslatorArmy army = null;
    //        var xml = new XmlSerializer(typeof(TranslatorArmy));
    //        using (var fs=new FileStream("Translator.xml",FileMode.OpenOrCreate))
    //        {
    //            army = xml.Deserialize(fs) as TranslatorArmy;
    //            Console.WriteLine("Deserialized");
    //        }
    //        Console.WriteLine(army);
    //    }

    //    static void Main(string[] args)
    //    {
    //        // XmlSerialize();
    //        //XmlDeserizalize();

    //    }
    //}

    #endregion


    #region BinarySerialization


    //class Program
    //{
    //    static void BinarySerialize()
    //    {
    //        var database = new Translator[]
    //        {
    //            new Translator("Akif","Akifli",1),
    //            new Translator("Leyla","Mammadova",2),
    //            new Translator("Tural","Eliyev",3),
    //            new Translator("Nergiz","Nergizli",4)
    //        };

    //        var bf = new BinaryFormatter();
    //        using (var fs=new FileStream("file.bin",FileMode.OpenOrCreate))
    //        {
    //            bf.Serialize(fs, database);
    //        }
    //        Console.WriteLine("Ready");
    //    }

    //    static void BinaryDeserialize()
    //    {
    //        Translator[] db = null;

    //        var bf = new BinaryFormatter();
    //        using (var fs=new FileStream("file.bin",FileMode.OpenOrCreate))
    //        {
    //            db = bf.Deserialize(fs) as Translator[];
    //        }
    //        foreach (var item in db)
    //        {
    //            Console.WriteLine(item);
    //        }
    //    }

    //    static void Main(string[] args)
    //    {
    //        //BinarySerialize();
    //       // BinaryDeserialize();
    //    }
    //}



    #endregion


    #region JsonSerialization

    [Serializable]
    class Car
    {
        //[JsonIgnore]
        public int Year { get; set; }
        [JsonProperty("ModelOfCar")]
        public string Model { get; set; }

        [JsonRequired]
        public string Vendor { get; set; }

        public override string ToString()
        {
            return $"{Model} - {Vendor} - {Year}";
        }
    }
    class Program
    {

        static void JsonSerialize()
        {
            List<Car> cars = new List<Car>
            {
                new Car
                {
                    Model="Mustang",
                    Vendor="Ford",
                    Year=1964
                },
                 new Car
                {
                    Model="Charger",
                    Vendor="Dodge",
                    Year=2000
                },
                  new Car
                {
                    Model="Chiron",
                    Vendor="Bugatti",
                    Year=2021
                },
                   new Car
                {
                    Model="La Ferrari",
                    Vendor="Ferrari",
                    Year=2016
                }
            };


            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter("cars.json"))
            {
                using (var jw=new JsonTextWriter(sw))
                {
                    jw.Formatting = Newtonsoft.Json.Formatting.Indented;
                    serializer.Serialize(jw, cars);
                }
            }

        }

        static void JsonDeserialize()
        {
            Car[] cars = null;
            var serializer = new JsonSerializer();
            using (var sr=new StreamReader("cars.json"))
            {
                using (var jr=new JsonTextReader(sr))
                {
                    cars = serializer.Deserialize<Car[]>(jr);
                }
                foreach (var item in cars)
                {
                    Console.WriteLine(item);
                }
            }
        }

        static void Main(string[] args)
        {
            JsonSerialize();
            JsonDeserialize();
        }
    }

    #endregion


}
