using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfacess
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfacessIntro();

            // Demoss();

            ICustomerDal[] customerDals = new ICustomerDal[3]
            {
                new SqlServerCustomerDal(),
                new OracleCustomerDal(),
                new MySqlCustomerDal()

            };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();

            }



            Console.ReadLine();
        }

        private static void Demoss()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(new SqlServerCustomerDal());
        }

        private static void InterfacessIntro()
        {
            PersonManager manager = new PersonManager();
            manager.Add(new Customer { Id = 1, FirstName = "Serenay", LastName = "Ekinci", Address = "İzmir" });
            Student student = new Student();
            manager.Add(new Student { Id = 2, FirstName = "Murat", LastName = "Ekinci", Department = "Languages" });
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get ;set; }
        public string LastName { get; set; }
        public string Address { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set ; }
        public string Department { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person) 
        {
            Console.WriteLine(person.FirstName);
            Console.WriteLine(person.LastName);
            Console.WriteLine(person.Id);

        }
    }

}
