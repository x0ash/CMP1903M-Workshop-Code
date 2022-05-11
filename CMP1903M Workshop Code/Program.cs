using System;

namespace CMP1903MWorkshopCode
{
    class Program
    {
        public delegate void delegateWriter(string message);
        static void Main(string[] args)
        {

            //Week 10
            //Using delegates
            //File is created here in the same dir as the exe
            //Changethe path for somewhere else
            Writer writer = new Writer("log.txt");



        }
    }
}
