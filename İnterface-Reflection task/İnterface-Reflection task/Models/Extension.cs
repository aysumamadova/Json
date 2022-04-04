using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface_Reflection_task.Models
{
   static class Extension
    {
        public static void ShowInfo(this object obj)
        {
            foreach (var prop in obj.GetType().GetProperties())
            {
                Console.WriteLine(prop.Name+":"+prop.GetValue(obj));
            }
        }
    }
}
