using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPLib1
{
    public class Airplane
    {
        protected string StartCity;
        protected string FinishCity;
        protected Date StartDate;
        protected Date FinishDate;

        /// Стартовый город по умолчанию - Киев, Украина
        /// Конечный город по умолчанию - Оттава, Канада
        /// Время полёта ~9 часов
        /// Источник: http://time-fly.ru/skolko-letet-do-kanady-iz-kieva

        public Airplane()
        {
            StartCity = "Киев";
            FinishCity = "Оттава";
            StartDate = new Date();
            FinishDate = new Date(StartDate);
            FinishDate.SetHours(FinishDate.GetHours() + 9);
        }
        public Airplane(string startcity, string finishcity, Date startdate, Date finishdate)
        {
            StartCity = SetStartCity(startcity);
            FinishCity = SetFinishCity(finishcity);
            StartDate = new Date(startdate);
            FinishDate = new Date(finishdate);
        }
        public Airplane(string startcity, Date startdate, Date finishdate)
        {
            StartCity = startcity;
            FinishCity = "Оттава";
            StartDate = new Date(startdate);
            FinishDate = new Date(finishdate);
        }
        public Airplane(string finishcity, Date startdate)
        {
            StartCity = "Киев";
            FinishCity = finishcity;
            StartDate = new Date(startdate);
            FinishDate = new Date(startdate);
            FinishDate.SetHours(FinishDate.GetHours() + 9);
        }
        public Airplane(Airplane airplane)
        {
            StartCity = airplane.StartCity;
            FinishCity = airplane.FinishCity;
            StartDate = new Date(airplane.StartDate);
            FinishDate = new Date(airplane.FinishDate);
        }
        public string SetStartCity(string startcity)
        {
            if (startcity.Length > 0) StartCity = startcity;
            else
                StartCity = "Киев";
            return StartCity;
        }

        public string GetStartCity()
        {
            return StartCity;
        }
        public string SetFinishCity(string finishcity)
        {
            if (finishcity.Length > 0 && finishcity != StartCity) FinishCity = finishcity;
            else
                FinishCity = "Оттава";
            return FinishCity;
        }
        public string GetFinishCity()
        {
            return FinishCity;
        }

        public void SetStartDate(int year, int month, int day, int hours, int minutes)
        {
            StartDate.SetYear(year);
            StartDate.SetMonth(month);
            StartDate.SetDay(day);
            StartDate.SetHours(hours);
            StartDate.SetMinutes(minutes);
        }

        public Date GetStartDate()
        {
            return new Date(StartDate);
        }
        public void SetFinishDate(int year, int month, int day, int hours, int minutes)
        {
            FinishDate.SetYear(year);
            FinishDate.SetMonth(month);
            FinishDate.SetDay(day);
            FinishDate.SetHours(hours);
            FinishDate.SetMinutes(minutes);
        }

        public Date GetFinishDate()
        {
            return new Date(FinishDate);
        }

        public int GetTotalTime()
        {
            int TimeInMinutes;
            DateTime startDate = new DateTime(StartDate.GetYear(), StartDate.GetMonth(), StartDate.GetDay(), StartDate.GetHours(), StartDate.GetMinutes(), 0);
            DateTime finishDate = new DateTime(FinishDate.GetYear(), FinishDate.GetMonth(), FinishDate.GetDay(), FinishDate.GetHours(), FinishDate.GetMinutes(), 0);
            if (startDate > finishDate) return 0;
            TimeSpan totalTime = finishDate - startDate;
            TimeInMinutes = (int)totalTime.TotalMinutes;
            return TimeInMinutes;
        }

        public bool IsArrivingToday()
        {
            if (StartDate.GetYear() == FinishDate.GetYear() && StartDate.GetMonth() == FinishDate.GetMonth() && StartDate.GetDay() == FinishDate.GetDay())
            {
                return true;
            }
            else
                return false;
        }
    }

    public class Date
    {
        protected int Year;
        protected int Month;
        protected int Day;
        protected int Hours;
        protected int Minutes;

        public Date()
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = DateTime.Now.Hour;
            Minutes = DateTime.Now.Minute;
        }

        public Date(int year, int month, int day, int hours, int minutes)
        {
            Year = SetYear(year);
            Month = SetMonth(month);
            Day = SetDay(day);
            Hours = SetHours(hours);
            Minutes = SetMinutes(minutes);
        }

        public Date(int year, int month, int day, int hours)
        {
            Year = SetYear(year);
            Month = SetMonth(month);
            Day = SetDay(day);
            Hours = SetHours(hours);
            Minutes = 0;
        }

        public Date(int month, int day, int hours)
        {
            Year = DateTime.Now.Year;
            Month = SetMonth(month);
            Day = SetDay(day);
            Hours = SetHours(hours);
            Minutes = 0;
        }

        public Date(int day, int hours)
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = SetDay(day);
            Hours = SetHours(hours);
            Minutes = 0;
        }

        public Date(int hours)
        {
            Year = DateTime.Now.Year;
            Month = DateTime.Now.Month;
            Day = DateTime.Now.Day;
            Hours = SetHours(hours);
            Minutes = 0;
        }

        public Date(Date date)
        {
            Year = date.Year;
            Month = date.Month;
            Day = date.Day;
            Hours = date.Hours;
            Minutes = date.Minutes;
        }

        public int SetYear(int year)
        {
            if (1900 <= year && year < 3000) Year = year;
            else Year = DateTime.Now.Year;
            return Year;
        }

        public int GetYear()
        {
            return Year;
        }

        public int SetMonth(int month)
        {
            if (1 <= month && month <= 12) Month = month;
            else Month = DateTime.Now.Month;
            while (Month > 12) { Month -= 12; Year++; }
            return Month;
        }

        public int GetMonth()
        {
            return Month;
        }

        public int SetDay(int day)
        {
            if (1 <= Day && Day <= DateTime.DaysInMonth(Year, Month)) Day = day;
            else Day = DateTime.Now.Day;
            while (Day > DateTime.DaysInMonth(Year, Month)) { Day -= DateTime.DaysInMonth(Year, Month); SetMonth(Month + 1); }
            return Day;
        }

        public int GetDay()
        {
            return Day;
        }

        public int SetHours(int hours)
        {
            if (0 <= Hours && Hours <= 23) Hours = hours;
            else Hours = DateTime.Now.Hour;
            while (Hours > 23) { Hours -= 24; SetDay(Day + 1); }
            return Hours;
        }

        public int GetHours()
        {
            return Hours;
        }

        public int SetMinutes(int minutes)
        {
            if (0 <= Minutes && Minutes <= 59) Minutes = minutes;
            else Minutes = DateTime.Now.Minute;
            while (Minutes > 59) { Minutes -= 60; SetHours(Hours + 1); }
            return Minutes;
        }

        public int GetMinutes()
        {
            return Minutes;
        }
    }
}
