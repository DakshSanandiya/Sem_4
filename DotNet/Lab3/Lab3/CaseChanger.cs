using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    internal class CaseChanger
    {

        public string Change(string x)
        {
            char[] arr = x.ToCharArray();

            for (int i = 0; i < arr.Length; i++) 
            {
                if (char.IsLower(arr[i]))
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
                else if (char.IsUpper(arr[i]))
                {
                    arr[i] = char.ToLower(arr[i]);  
                }
            } 


            return new string(arr);
        }

    }
}
