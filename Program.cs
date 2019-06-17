using System;
using System.Text.RegularExpressions;

namespace SC
{    class MainClass
    {
        public static void Main(string[] args)
        {
            Theatre test = new Theatre(3, 11);
            String here = "R1C1 R1C2 R1C3 1 2 3 4 5 6 7";
            // test.rows.Print();
            //Console.WriteLine(test.IsReserved("R1C3"));
            //Console.WriteLine(test.MarkReserved("R1C3").seat.Id);
            //Console.WriteLine(test.IsReserved("R1C3"));
            String SeatArr = @"(\w\d\w\d)";
            String Party = @"(\b\d\b)" ;
            MatchCollection matches = Regex.Matches(here, SeatArr);
            MatchCollection matcher = Regex.Matches(here, Party);
            foreach(Match match in matches)
            {
                //Console.WriteLine(test.MarkReserved(match.Value).seat.Id);
            }
            
            foreach(Match match in matcher)
            {
                Console.WriteLine(match.Value);
            }



            Console.Read();
        }
    }
}
