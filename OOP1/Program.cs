using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPLib1;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Airplane plane1 = new Airplane();
            PrintAirplane(plane1);
            Airplane[] planes1 = ReadAirplaneArray();
            int largestTravel, leastTravel;
            GetAirplaneInfo(planes1, out largestTravel, out leastTravel);
            PrintAirplanes(planes1);
            SortAirplanesByDate(ref planes1);
            PrintAirplanes(planes1);
            SortAirplanesByTotalTime(ref planes1);
            PrintAirplanes(planes1);
            Console.ReadKey();
        }
        static Airplane[] ReadAirplaneArray()
        {
            bool check = false;
            int CountOfElements;
            do
            {
                Console.Write("Введите количество рейсов: ");
                check = int.TryParse(Console.ReadLine(), out CountOfElements);
                if (!check) Console.WriteLine("Данные введено неверно!");
            }
            while (!check);
            Airplane[] airplanes = new Airplane[CountOfElements];
            string startCity, finishCity;
            Date startDate, finishDate;
            int Year, Month, Day, Hours, Minutes;
            for(int i = 0; i < airplanes.Length; i++)
            {
                Console.WriteLine("--------------------------------|");
                Console.WriteLine($"Введите данные рейса номер {i,3}! |");
                Console.WriteLine( "Примечание: при ошибке ввода    |\n" +
                                   "данных, поле получит стандартное|\n" +
                                   "значение!                       |");
                Console.Write("Введите город отправления       |  ");
                startCity = Console.ReadLine();
                Console.Write("Введите город прибытия          |  ");
                finishCity = Console.ReadLine();
                Console.WriteLine( "Введите дату отправления!       |");
                Console.WriteLine("Примечание: вводить все числом! |");
                Console.Write("Введите год                     |  ");
                int.TryParse(Console.ReadLine(), out Year);
                Console.Write("Введите месяц                   |  ");
                int.TryParse(Console.ReadLine(), out Month);
                Console.Write("Введите день месяца             |  ");
                int.TryParse(Console.ReadLine(), out Day);
                Console.Write("Введите час                     |  ");
                int.TryParse(Console.ReadLine(), out Hours);
                Console.Write("Введите минуты                  |  ");
                int.TryParse(Console.ReadLine(), out Minutes);
                startDate = new Date(Year, Month, Day, Hours, Minutes);
                Console.WriteLine( "Введите дату прыбитыя!          |");
                Console.WriteLine("Примечание: вводить все числом! |");
                Console.Write("Введите год                     |  ");
                int.TryParse(Console.ReadLine(), out Year);
                Console.Write("Введите месяц                   |  ");
                int.TryParse(Console.ReadLine(), out Month);
                Console.Write("Введите день месяца             |  ");
                int.TryParse(Console.ReadLine(), out Day);
                Console.Write("Введите час                     |  ");
                int.TryParse(Console.ReadLine(), out Hours);
                Console.Write("Введите минуты                  |  ");
                int.TryParse(Console.ReadLine(), out Minutes);
                finishDate = new Date(Year, Month, Day, Hours, Minutes);
                Console.WriteLine("--------------------------------|");
                airplanes[i] = new Airplane(startCity, finishCity, startDate, finishDate);
            }
            return airplanes;
        }
        static void PrintAirplane(Airplane airplane)
        {
            string startCity = airplane.GetStartCity();
            string finishCity = airplane.GetFinishCity();
            string startDate = airplane.GetStartDate().GetYear()+"."+ airplane.GetStartDate().GetMonth() + "."+ airplane.GetStartDate().GetDay() + " "+ airplane.GetStartDate().GetHours() + ":"+ airplane.GetStartDate().GetMinutes();
            string finishDate = airplane.GetFinishDate().GetYear()+"."+ airplane.GetFinishDate().GetMonth() + "."+ airplane.GetFinishDate().GetDay() + " "+ airplane.GetFinishDate().GetHours() + ":"+ airplane.GetFinishDate().GetMinutes();
            string arrivingToday = "";
            if (airplane.IsArrivingToday()) arrivingToday = "Да"; else arrivingToday = "Нет";
            string totalTime = airplane.GetTotalTime().ToString();
            Console.WriteLine("--------------------------------|");
            Console.WriteLine($"Стартовый город                 |  {startCity}");
            Console.WriteLine($"Конечный город                  |  {finishCity}");
            Console.WriteLine($"Дата вылета                     |  {startDate}");
            Console.WriteLine($"Дата прибытия                   |  {finishDate}");
            Console.WriteLine($"Прибытие в день когда и вылет   |  {arrivingToday}");
            Console.WriteLine($"Общее время полёта              |  {totalTime}");
            Console.WriteLine("--------------------------------|");
        }

        static void PrintAirplanes(Airplane[] airplanes)
        {
            string startCity, finishCity, startDate, finishDate, arrivingToday, totalTime;
            for (int i = 0; i < airplanes.Length; i++)
            {
                startCity = airplanes[i].GetStartCity();
                finishCity = airplanes[i].GetFinishCity();
                startDate = airplanes[i].GetStartDate().GetYear() + "." + airplanes[i].GetStartDate().GetMonth() + "." + airplanes[i].GetStartDate().GetDay() + " " + airplanes[i].GetStartDate().GetHours() + ":" + airplanes[i].GetStartDate().GetMinutes();
                finishDate = airplanes[i].GetFinishDate().GetYear() + "." + airplanes[i].GetFinishDate().GetMonth() + "." + airplanes[i].GetFinishDate().GetDay() + " " + airplanes[i].GetFinishDate().GetHours() + ":" + airplanes[i].GetFinishDate().GetMinutes();
                if (airplanes[i].IsArrivingToday()) arrivingToday = "Да"; else arrivingToday = "Нет";
                totalTime = airplanes[i].GetTotalTime().ToString();
                Console.WriteLine("--------------------------------|");
                Console.WriteLine($"Номер самолёта                  |  {i}");
                Console.WriteLine($"Стартовый город                 |  {startCity}");
                Console.WriteLine($"Конечный город                  |  {finishCity}");
                Console.WriteLine($"Дата вылета                     |  {startDate}");
                Console.WriteLine($"Дата прибытия                   |  {finishDate}");
                Console.WriteLine($"Прибытие в день когда и вылет   |  {arrivingToday}");
                Console.WriteLine($"Общее время полёта              |  {totalTime}");
                Console.WriteLine("--------------------------------|");
            } 
        }

        static void GetAirplaneInfo(Airplane[] airplanes, out int largestTravel, out int leastTravel)
        {
            largestTravel = int.MinValue;
            leastTravel = int.MinValue;
            for (int i = 0; i < airplanes.Length; i++)
            {
                if (airplanes[i].GetTotalTime() > largestTravel) largestTravel = airplanes[i].GetTotalTime();
                if (airplanes[i].GetTotalTime() < leastTravel) leastTravel = airplanes[i].GetTotalTime();
            }
        }
        
        static void tmpTime(Date date, out int Year, out int Month, out int Day, out int Hours, out int Minutes)
        {
            Year = date.GetYear();
            Month = date.GetMonth();
            Day = date.GetDay();
            Hours = date.GetHours();
            Minutes = date.GetMinutes();
        }
        static void SortAirplanesByDate(ref Airplane[] airplanes)
        {
            Date tmpDate;
            DateTime airplaneTime_1, airplaneTime_2;
            int tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes;
            string tmpStartCity, tmpFinishCity;
            for (int i = 0; i < airplanes.Length - 1; i++)
            {
                tmpTime(airplanes[i].GetStartDate(), out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                airplaneTime_1 = new DateTime(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes, 0);
                for (int j = i + 1; j < airplanes.Length; j++)
                {
                    tmpTime(airplanes[j].GetStartDate(), out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                    airplaneTime_2 = new DateTime(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes, 0);
                    if (airplaneTime_1 < airplaneTime_2)
                    {
                        tmpStartCity = airplanes[i].GetStartCity();
                        airplanes[i].SetStartCity(airplanes[j].GetStartCity());
                        airplanes[j].SetStartCity(tmpStartCity);

                        tmpFinishCity = airplanes[i].GetFinishCity();
                        airplanes[i].SetFinishCity(airplanes[j].GetFinishCity());
                        airplanes[j].SetFinishCity(tmpFinishCity);

                        tmpDate = airplanes[i].GetStartDate();
                        tmpTime(airplanes[j].GetStartDate(), out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[i].SetStartDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);
                        tmpTime(tmpDate, out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[j].SetStartDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);

                        tmpDate = airplanes[i].GetFinishDate();
                        tmpTime(airplanes[j].GetFinishDate(), out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[i].SetFinishDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);
                        tmpTime(tmpDate, out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[j].SetFinishDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);
                    }
                }
            }
        }

        static void SortAirplanesByTotalTime(ref Airplane[] airplanes)
        {
            Date tmpDate;
            int travelTime_1, travelTime_2;
            int tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes;
            string tmpStartCity, tmpFinishCity;
            for (int i = 0; i < airplanes.Length - 1; i++)
            {
                travelTime_1 = airplanes[i].GetTotalTime();
                for (int j = i + 1; j < airplanes.Length; j++)
                {
                    travelTime_2 = airplanes[j].GetTotalTime();
                    if (travelTime_1 > travelTime_2)
                    {
                        tmpStartCity = airplanes[i].GetStartCity();
                        airplanes[i].SetStartCity(airplanes[j].GetStartCity());
                        airplanes[j].SetStartCity(tmpStartCity);

                        tmpFinishCity = airplanes[i].GetFinishCity();
                        airplanes[i].SetFinishCity(airplanes[j].GetFinishCity());
                        airplanes[j].SetFinishCity(tmpFinishCity);

                        tmpDate = airplanes[i].GetStartDate();
                        tmpTime(airplanes[j].GetStartDate(), out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[i].SetStartDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);
                        tmpTime(tmpDate, out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[j].SetStartDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);

                        tmpDate = airplanes[i].GetFinishDate();
                        tmpTime(airplanes[j].GetFinishDate(), out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[i].SetFinishDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);
                        tmpTime(tmpDate, out tmpYear, out tmpMonth, out tmpDay, out tmpHours, out tmpMinutes);
                        airplanes[j].SetFinishDate(tmpYear, tmpMonth, tmpDay, tmpHours, tmpMinutes);
                    }
                }
            }
        }
    }
}
