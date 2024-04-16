using System;

namespace WpfApp1
{
    public class Car
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Id { get; set; }
        public DateTime Datum { get; set; }

        public override string ToString()
        {
            return $"{Id}\n {Jmeno} \n{Prijmeni}\n {Datum.ToShortDateString()}";
        }
       
    }
}