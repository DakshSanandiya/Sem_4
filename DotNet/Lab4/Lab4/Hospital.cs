using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("in Class Hospital :)");
        }
    }
    internal class Apollo : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("in Class Apollo :)");
        }
    }
    internal class Wockhardt : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("in Class Wockhardt :)");
        }
    }
    internal class Gokul_Superspeciality : Hospital
    {
        public void HospitalDetails()
        {
            Console.WriteLine("in Class Gokul_Superspeciality :)");
        }
    }
}
