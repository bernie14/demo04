using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo04
{
    class Teacher : Person
    {
        public string Room { get; set; }

        public Teacher()
        {

        }
        public Teacher(string firstname, string lastname, string room)
            : base(firstname,lastname)
        {
            Room = room;
        }

        public void TeacherMethod()
        {
            Console.WriteLine("This method belongs to the museum!");
        }

        public override string ToString()
        {
            // base on nyt Person-luokka
            // kutsutaan siis Person-luokan ToString()
            // FN + " " + ... + Room;
            return base.ToString() + " " + Room;
        }
    }
}
