using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1103
{
    enum Gender { male, women }
    class PerData
    {
        static int counter = 0;
        public static List<PerData> people = new List<PerData>();
        public int id { get; private set; }
        public string name { get; private set; }
        public string surname { get; private set; }
        public DateTime birthday { get; private set; }
        public Gender gen { get; private set; }
        public string image { get; private set; }
        public string diagnosis { get; private set; }
        public string history { get; private set; }
        public PerData() { }
        public PerData(string surname, string name, DateTime date, Gender gen, string image, string diagnosis)
        {
            id = counter++;
            this.surname = surname;
            this.name = name;
            this.birthday = date;
            this.gen = gen;
            this.image = image;
            this.diagnosis = diagnosis;
        }
        public void EditInfo(string surname, string name, DateTime date, Gender gen, string image, string diagnosis, string history)
        {
            this.surname = surname;
            this.name = name;
            this.birthday = date;
            this.gen = gen;
            this.image = image;
            this.diagnosis = diagnosis;
            this.history = history;
        }
    } }
