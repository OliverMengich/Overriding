using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{
    interface IClass
    {
        void PrintStudents();
        int  GetAge(int age);
        string GetName(string name);
    }
     public abstract class Class:IClass
     {
         public abstract string GetName(string Name);
       public void PrintStudents()
       {
           Console.WriteLine("students are 10000");
       }
       public abstract int GetAge(int age);
     }
     public class ClassDetails :Class
     {
         public override int GetAge(int age)
         {
             age=21;
             Console.WriteLine("age is"+age);
             return age;
         }
         public override string GetName(string Name)
         {
             Name="Skinny";
             Console.WriteLine("Name is "+Name);
             return "Hakeem";
         }
     }
     
     
    public static class Program 
    {
        public static void Main() 
        {
         // IClass c = new Class();
         // c.PrintStudents();
          ClassDetails c1= new ClassDetails();
          c1.GetAge(21);
          c1.GetName(null);
        }
        
    }
}