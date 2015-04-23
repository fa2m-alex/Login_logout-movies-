using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    public class Movie
    {
        int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        string title;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        int duration;

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }

        public override string ToString()
        {
            return this.Title + " (" + this.Year + ")";
        }

        double kinoPoisk;

        public double KinoPoisk
        {
            get { return kinoPoisk; }
            set { kinoPoisk = value; }
        }

        double imdb;

        public double Imdb
        {
            get { return imdb; }
            set { imdb = value; }
        }
        
        double metacritic;

        public double Metacritic
        {
            get { return metacritic; }
            set { metacritic = value; }
        }
        
        double rottentTomatoes;

        public double RottentTomatoes
        {
            get { return rottentTomatoes; }
            set { rottentTomatoes = value; }
        }
        
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

    }
}
