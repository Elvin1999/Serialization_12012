using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
namespace Serialization
{
    [Serializable]
   public class Translator
    {
        [XmlArray(ElementName ="TranslatorSubjects")]
        public List<Subject> Subjects { get; set; }

        [XmlAttribute]
        public string Name { get; set; }
        [XmlAttribute]
        public string Surname { get; set; }

        [XmlAttribute(AttributeName ="Identification")]
        public int Id { get; set; }
        public string Fullname => $"{Name} - {Surname}";
        public override string ToString()
        {
            if (Subjects != null)
            {
                foreach (var item in Subjects)
                {
                    Console.WriteLine($"\t\t{item}");
                }
            }
            return $"{Id}  {Fullname}";
        }
        public Translator()
        {
        }
        public Translator(string name,string surname,int id)
        {
            Name = name;
            Surname = surname;
            Id = id;
        }
    }
}
