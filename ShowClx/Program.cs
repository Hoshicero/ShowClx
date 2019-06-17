using System;
namespace ShowClx
{ 
    class MainClass
    {
        public static void Main(string[] args)
        {
            Row row = new Row();

            //row.Start(new Seat("Hi"));
            row.Head = new Seat("God");
            row.HeadAdd(new Seat("Christ"));
            row.RearAdd(new Seat("Good Evening"));
            //Console.WriteLine(row.Head.Id);

            Console.Write(row.Search("God").Id);
            //row.Print();

        }
    }

   
}
