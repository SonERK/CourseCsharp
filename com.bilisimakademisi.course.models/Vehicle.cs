using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.bilisimakademisi.course.models
{
    public class Vehicle
    {
        private bool CheckEnergy()
        {
            return true;
        }

        public decimal LuggageSize()
        {
            return 4085.5m;
        }

        public byte GetWheelCount()
        {
            return 4;
        }

        public bool StartEngine()
        {
            bool status = CheckEnergy();
            if (status==true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
