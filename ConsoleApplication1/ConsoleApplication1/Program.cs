using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
        static void Main(string[] args)
        {

        }
        public static void InutValues(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                Console.Write("A[{0}] = ");
                string str = Console.ReadLine();
                iArr[i] = int.Parse(str);
            }
        }
        //set: Array = iArr
        //criterial: iArr[i] == 5
        //Action: return true 
        public static bool IsConstrain5(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                    return true;
            }
               return false;
        }
        public static bool IsConstrain5Or6(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5 || iArr[i] == 6)
                {
                    return true;
                }
            }
                return false;
        }
        //set:iArr
        //criterial: iArr[i]==5
        //
        public static bool IsConstrain5And6(int[] iArr)
        {
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5 && iArr[i] == 6)
                {
                    return true;
                }
            }
            return false;
        }
        public static int Count5(int[] iArr)
        {
            int c = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                if (iArr[i] == 5)
                {
                    c++;
                }                         
            }
            return c;
        }
        public static int Count5Or6(int[] iArr)
        {
            int c = 0;
            for(int i = 0; i < iArr.Length; i++)
            {
                if(iArr[i] == 5 || iArr[i] ==6 )
                {
                    c++;
                }
            }
            return c;
        }

        public static int Sum(int[] iArr)
        {
            int sum = 0;
            for (int i = 0; i < iArr.Length; i++)
            {
                sum += iArr[i];
            }
        }
        return sum;
    }
}
