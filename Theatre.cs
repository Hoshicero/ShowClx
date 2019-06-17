using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace SC
{
    public class Theatre
    {

        public Row rows = new Row();
        public Theatre(int Rows, int Columns)
        {
            for (int i = 1; i <= Rows; i++)
                for (int x = 1; x <= Columns; x++)
                {
                    rows.RearAdd(new Seat(String.Concat("R", i.ToString(), "C", x.ToString())));
                }
        }
        public Theatre() { }

        public SeatNode MarkReserved(String id)
        {
            SeatNode temp = rows.Search(id);
            if (temp != null)
            {
                temp.seat.Reserved = true;
                return temp;
            }
            Console.WriteLine("The Reservation Id is invalid");
            return null;
        }

        public Boolean IsReserved(String id)
        {
            SeatNode temp = rows.Search(id);

            if (temp != null)
            {
                return temp.seat.Reserved;
            }

            return false;
        }

       


       

    }
}