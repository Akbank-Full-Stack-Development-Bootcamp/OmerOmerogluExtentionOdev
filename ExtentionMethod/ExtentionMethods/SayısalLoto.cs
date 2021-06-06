using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExtentionMethod.ExtentionMethods
{
    public static class SayısalLoto
    {
        public static int PlayLoto(this int num)
        {
            Random num1 = new Random(); return num1.Next(1, 10);


        }

       
    }
}
