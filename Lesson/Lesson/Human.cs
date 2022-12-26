using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson
{
    internal class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
        protected string Test;


        public virtual string GetInfo()
        {
            return $"Fullname: {Name} {Surname} - Age: {Age}";
        }
    }
}
