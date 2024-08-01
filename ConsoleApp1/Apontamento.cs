//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    public class Apontamento
//    {
//        public DateTime Start { get; set; }
//        public string Name { get; set; }

//        public Apontamento(DateTime date, string name)
//        {
//            Start = date;
//            Name = name;
//            Validar();

//        }

//        public bool Validar()
//        {

//            var dateTimeNow = new DateTime(2024, 07, 15);
//            var endWeek = dateTimeNow.AddDays(-7);

//            if(Start > dateTimeNow)
//            {
//                Console.WriteLine("Nao pode apontar playboy" + Start.Day);
//                return false;
//            }

//            if(dateTimeNow.DayOfWeek == DayOfWeek.Wednesday)
//            {
//                var pinto = dateTimeNow.AddDays(-3);
//                if (Start > pinto)
//                {
//                    Console.WriteLine("tamo junto playboy" + Start.Day);
//                    return false;
//                }
//                else
//                {
//                    Console.WriteLine("nao pode apontar playboy" + Start.Day);
//                    return false;
//                }
//            }
//            if (dateTimeNow.DayOfWeek == DayOfWeek.Thursday)
//            {
//                var porra = dateTimeNow.AddDays(-4);
//                if (Start > porra)
//                {
//                    Console.WriteLine("tamo junto playboy" + Start.Day);
//                    return false;
//                }
//                else
//                {
//                    Console.WriteLine("nao pode apontar playboy" + Start.Day);
//                    return false;
//                }
//            }
//            if (dateTimeNow.DayOfWeek == DayOfWeek.Friday)
//            {
//                var caralho = dateTimeNow.AddDays(-5);
//                if (Start > caralho)
//                {
//                    Console.WriteLine("tamo junto playboy" + Start.Day);
//                    return false;
//                }
//                else
//                {
//                    Console.WriteLine("nao pode apontar playboy" + Start.Day);
//                    return false;
//                }
//            }
//            if (dateTimeNow.DayOfWeek == DayOfWeek.Tuesday)
//            {
//                if (Start <= dateTimeNow && (Start >= endWeek || Start.AddDays(1) == endWeek))
//                {
//                    Console.WriteLine("pode apontar" + Start.Day);
//                    return true;
//                }
//                else
//                {
//                    Console.WriteLine("nao pode playboy " + Start.Day);
//                    return false;
//                }
//            }

//            if (dateTimeNow.DayOfWeek == DayOfWeek.Monday)
//            {
//                if (Start <= dateTimeNow && (Start >= endWeek))
//                {
//                    Console.WriteLine("pode apontar" + Start.Day);
//                    return true;
//                }
//                else
//                {
//                    Console.WriteLine("nao pode playboy " + Start.Day);
//                    return false;
//                }
//            }

//            return false;

//        }
//    }
//}
using System;

namespace ConsoleApp1
{
    public class Apontamento
    {
        public DateTime Start { get; set; }
        public string Name { get; set; }

        public Apontamento(DateTime date, string name)
        {
            Start = date;
            Name = name;
            Validar();
        }

        public bool Validar()
        {
            var dateTimeNow = new DateTime(2024, 07, 15);
            var endWeek = dateTimeNow.AddDays(-7);

            if (Start > dateTimeNow)
            {
                Console.WriteLine("Nao pode apontar playboy " + Start.Day);
                return false;
            }

            if (dateTimeNow.DayOfWeek == DayOfWeek.Monday || dateTimeNow.DayOfWeek == DayOfWeek.Tuesday)
            {
                if (Start <= dateTimeNow && (Start >= endWeek || (dateTimeNow.DayOfWeek == DayOfWeek.Tuesday && Start.AddDays(1) == endWeek)))
                {
                    Console.WriteLine("Pode apontar " + Start.Day);
                    return true;
                }
                else
                {
                    Console.WriteLine("Nao pode apontar playboy " + Start.Day);
                    return false;
                }
            }

            int daysToSubtract = 0;
            if (dateTimeNow.DayOfWeek == DayOfWeek.Wednesday)
                daysToSubtract = 3;
            else if (dateTimeNow.DayOfWeek == DayOfWeek.Thursday)
                daysToSubtract = 4;
            else if (dateTimeNow.DayOfWeek == DayOfWeek.Friday)
                daysToSubtract = 5;

            var validDate = dateTimeNow.AddDays(-daysToSubtract);
            if (Start > validDate)
            {
                Console.WriteLine("Tamo junto playboy " + Start.Day);
                return false;
            }
            else
            {
                Console.WriteLine("Nao pode apontar playboy " + Start.Day);
                return false;
            }
        }
    }
}
