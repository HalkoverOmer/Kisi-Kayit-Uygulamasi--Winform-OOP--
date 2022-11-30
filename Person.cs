using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kisi_Kayit_Uygulamasi
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateOnly Birthdate { get; set; }
        public int Age { get; set; }
        public bool Gender { get; set; }

        public override string ToString()
        {
            return $"{Name} {Surname} ({Age}) - {(Gender ? "Male" : "Female")}";
        }
    }
}
