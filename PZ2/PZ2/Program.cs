using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 Персона (фамилия, адрес, номер телефона), 
 Организация (название, адрес, телефон, факс, контактное лицо), 
 Друг (фамилия, адрес, номер телефона, дата рождения) 
*/
namespace PZ2
{
    abstract class phoneBook
    {
        protected string Name;
        protected string Address;
        protected string PhoneNumber;
        public abstract void printInfo();
        public abstract string findName();
    }

    class Person : phoneBook
    {
        public Person(string surname, string address, string phonenumber) {
            Name = surname;
            Address = address;
            PhoneNumber = phonenumber;
        }
        public override void printInfo()
        {
            Console.WriteLine("Фамилия:{0}",Name);
            Console.WriteLine("Адрес:{0}", Address);
            Console.WriteLine("Телефон:{0}", PhoneNumber);
        }
        public override string findName()
        {
            return Name;
        }
    }

    class Organisation : phoneBook 
    {
        string Fax;
        string Contact;

        public Organisation(string name, string address, string phonenumber, string fax, string contact)
        {
            Name = name;
            Address = address;
            PhoneNumber = phonenumber;
            Fax = fax;
            Contact = contact;
        }
        public override void printInfo()
        {
            Console.WriteLine("Название:{0}", Name);
            Console.WriteLine("Адрес:{0}", Address);
            Console.WriteLine("Телефон:{0}", PhoneNumber);
            Console.WriteLine("Факс:{0}", Fax);
            Console.WriteLine("Контактное лицо:{0}", Contact);
        }
        public override string findName()
        {
            return Name;
        }
    }
    class Friend : phoneBook 
    {
        DateTime Birthday;

        public Friend(string surname, string address, string phonenumber, DateTime birthday)
        {
            Name = surname;
            Address = address;
            PhoneNumber = phonenumber;
            Birthday = birthday;
        }
        public override void printInfo()
        {
            Console.WriteLine("Фамилия:{0}",Name);
            Console.WriteLine("Адрес:{0}", Address);
            Console.WriteLine("Телефон:{0}", PhoneNumber);
            Console.WriteLine("Дата Рождения:{0}", Birthday.ToShortDateString());
        }
        public override string findName()
        {
            return Name;
        }
    }

    class Program
    {
        static void printInfoFromDataBase(phoneBook[] pb)
        {
            for(int i = 0; i < pb.Length; i++)
            {
                pb[i].printInfo();
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~");
            }
        }

        public static phoneBook getRecordType(string recordingLine) 
        {
            var vals = recordingLine.Split('|');
            switch (vals[0])
            {
                case "Person":
                    return new Person(vals[1], vals[2], vals[3]);
                case "Friend":
                    return new Friend(vals[1], vals[2], vals[3], new DateTime(int.Parse(vals[4]), int.Parse(vals[5]), int.Parse(vals[6])));
                case "Organisation":
                    return new Organisation(vals[1], vals[2], vals[3], vals[4], vals[5]);
                default:
                    throw new Exception();
            }
        }
        public static void searchForName(phoneBook[] pb, string name) {
            for (int i = 0; i < pb.Length; i++)
            {
                if (pb[i].findName() == name) {
                    pb[i].printInfo();
                    Console.WriteLine("_______________________________"); 
                }
            }
        }

        static void Main(string[] args)
        {
            using (var inputStream = new FileStream("input.txt", FileMode.Open))
            using (var streamReader = new StreamReader(inputStream)) {
                int n = int.Parse(streamReader.ReadLine());
                phoneBook[] phoneBooksDataBase = new phoneBook[n];

                for (int i = 0; i < n; i++)
                {
                    string recordingLine = streamReader.ReadLine();
                    phoneBook record = getRecordType(recordingLine);
                    phoneBooksDataBase[i] = record;
                }
                searchForName(phoneBooksDataBase, "Чебурек");
               // printInfoFromDataBase(phoneBooksDataBase); 
            }
        }
    }
}
