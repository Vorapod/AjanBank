using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.Creator;

namespace Factory
{
    /// <summary>
    /// Creates an instance of several derived classes
    /// 
    /// Define an interface for creating an object, but let subclasses decide which class to instantiate. 
    /// Factory Method lets a class defer instantiation to subclasses.
    /// ==== Participants ====
    /// The classes and objects participating in this pattern are:
    /// Product  (Page)
    ///     defines the interface of objects the factory method creates
    /// ConcreteProduct  (SkillsPage, EducationPage, ExperiencePage)
    ///     implements the Product interface
    /// Creator  (Document)
    ///     declares the factory method, which returns an object of type Product. Creator may also define a default implementation of the factory method that returns a default ConcreteProduct object.
    ///     may call the factory method to create a Product object.
    /// ConcreteCreator  (Report, Resume)
    ///     overrides the factory method to return an instance of a ConcreteProduct.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages
            foreach (Document document in documents)
            {
                Console.WriteLine("\n" + document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    Console.WriteLine(" " + page.GetType().Name);
                }
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
