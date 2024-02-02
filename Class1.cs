using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Classes
{
    internal class Abonent
    {
        // поля (атрибуты)
        private int id;
        private string lastcity;
        private string firstcity;
        private int time;
        private string phone;
        private double date;

        // свойства (для доступа к полям)
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Lastcity
        {
            get { return lastcity; }
            set { lastcity = value; }
        }
        public string Firstcity
        {
            get { return firstcity; }
            set { firstcity = value; }
        }

        public int Time
        {
            get { return time; }
            set { time = value; }
        }
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public double Date
        {
            get { return date; }
            set { date = value; }
        }


        public Abonent()
        {
            id = 1;
            lastcity = string.Empty;
            firstcity = string.Empty;
            time = 0;
            phone = string.Empty;
            date = 0;

        }

        public Abonent(int id, string lastcity, string firstcity, int time, string phone, double date)
        {
            Id = id;
            Lastcity = lastcity;
            Firstcity = firstcity;
            Time = time;
            Phone = phone;
            Date = date;
        }

        public void OutToScreen()
        {
            //
            Console.WriteLine($"город откуда: {lastcity}");
            Console.WriteLine($"город куда: {firstcity}");
            Console.WriteLine($"время: {time}");
            Console.WriteLine($"Телефон: {phone}");
            Console.WriteLine($"Дата : {date}");
        }
    }
}
