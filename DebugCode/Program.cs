using System;

namespace DebugCode
{
   
    public class Program
    {
        static void Main(string[] args)
        {

            LinkedList newList = new LinkedList();
            newList.AddElementToFirst(4);
            newList.AddElementToFirst(5);
            newList.AddElementToFirst(6);
            newList.PrintList();
            newList.DeleteElementFromFirst();




        }
    }
}
