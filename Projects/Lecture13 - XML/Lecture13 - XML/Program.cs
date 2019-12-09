using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lecture13___XML {
    class Program {
        static void Main(string[] args) {

            XDocument doc = new XDocument();

           
            XElement root = new XElement("Phonebook");      //root tag, 
                                                            //without defining the root tag, 
                                                            //an exception would be thrown

            

            doc.Add(root);

            XElement contact = new XElement("Contact");

            root.Add(contact);

            contact.Add(new XElement("Name", "Mahad"), 
                        new XElement("Address", "Ciit"));

            for (int i = 0; i < 4; i++)
                root.Add(new XElement("Contact", new XElement("Name", "Mahad"),
                            new XElement("Address", "Ciit")));


            List<Person> pList = new List<Person>(){
                new Person{Name = "LT", Address = "NUST"},
                new Person{Name = "LT1", Address = "NUST"}
            };

            foreach(Person p in pList)
                root.Add(new XElement("Contact", new XElement("Name", p.Name), 
                    new XElement("Address", p.Address)));

            doc.Save("data.xml");

            doc = XDocument.Load("data.xml");     //load existing document

            root = doc.Root;

            var res = from q in doc.Descendants("Contact") //q => anon object
                      select q;

          //  foreach (var r in res)
          //      Console.WriteLine(r);

            var res1 = from q in doc.Descendants("Contact") //q => anon object
                       where q.Element("Address").Value == "NUST"
                       select q;

            foreach (var r in res1)
                   Console.WriteLine(r.Element("Name"));    

            Console.ReadKey();
            
            
            
        }
    }

    public class Person {
        public String Name;
        public String Address;
    }
}
