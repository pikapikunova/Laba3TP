using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class Class1 : IClass
    {

        public double first(Person person)
        {
            Console.WriteLine("Вычисляю функцию 1");
            if (person.gender)
                return (person.weight * 10 + person.growth * 6.25 - person.age * 5 - 161) * 0.5;
            else
                return (person.weight * 10 + person.growth * 6.25 - person.age * 5 + 5) * 0.4;
        }


        public Person GetPerson(int ID)
        {
            
            var context = new PersonContext();

            var query = from c in context.Table_1
                        where c.ID == ID
                        select c;
            List<Table_1> list = query.ToList();

            if (list.Count == 0)
                throw new Exception("Такого ID нет в базе");
            else
            {
                Person person = new Person();

                person.ID = list[0].ID;
                person.growth = list[0].Growth;
                person.age = list[0].Age;
                person.gender = list[0].Gender;
                person.weight = list[0].Weight;

                return person;
            }
            
        }

        public double second(Person person, string str, int time)
        {
            double kkal = helper(str);
            
            Console.WriteLine("Вычисляю функцию 2");
            return person.weight * kkal * time / 60;
        }

        public double third(Person person, string str, int time)
        {
            Console.WriteLine("Вычисляю функцию 3");
            double kkal = helper(str);
            return (first(person) - second(person, str, time))*60 / (person.weight * kkal);
        }

        public void sellInBd(int ID, double one, double two, int three)
        {

            var context = new PersonContext();

            var customer = context.Table_1.Single(c => c.ID == ID);

            customer.HowMuchKkal = one;
            customer.HowMuchKkalToday = two;
            customer.HowMuchMinuteNow = three;


            context.SaveChanges();

        }

        public double helper(string str)
        {
            double kkal = 0.0;

            switch (str)
            {
                case "прогулка пешком":
                    kkal = 4.5;
                    break;

                case "катание на роликах":
                    kkal = 4.4;
                    break;

                case "приседания":
                    kkal = 5.6;
                    break;

                case "футбол":
                    kkal = 6.4;
                    break;

                case "бадминтон":
                    kkal = 6.9;
                    break;

                case "на велотренажере":
                    kkal = 7.4;
                    break;

                case "прыжки на скакалке":
                    kkal = 7.7;
                    break;

                case "при плавании кролем":
                    kkal = 8.1;
                    break;

                case "плавание брасом":
                    kkal = 10.6;
                    break;

                case "кроссфит":
                    kkal = 11.9;
                    break;

                case "подъём по лестнице":
                    kkal = 12.9;
                    break;
            }

            return kkal;

        }

    }
}
