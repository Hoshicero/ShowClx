using System;
using System.Collections.Generic;
using System.Text;

namespace SC
{
    public class Row
    {

        public SeatNode Head { get; set; }
        public SeatNode Rear { get; set; }
        public Row () { }

        public void Start(Seat seat)
        {

            Head = new SeatNode(seat);
            Head.Next = Rear;
           // Rear.Previous = Head;
        }

        public void RearAdd(Seat In)
        {
            // Console.WriteLine("Here with" + " " + seat.Id);
            SeatNode seat = new SeatNode(In);
            if(Head == null)
            {
                Start(In);
                return;
            }
            if (Rear == null)
            {
                seat.Previous = Head;
                Rear = seat;
                Head.Next = Rear;
                return;
            }

            Rear.Next = seat;
            seat.Previous = Rear;
            Rear = seat;
        }


        public void HeadAdd(Seat In)
        {
            //Console.WriteLine("Here with" + " " + seat.Id);
            SeatNode seat = new SeatNode(In);
         

            if (Head == null)
            {
                Start(In);
                return;
            }

            seat.Next = Head;
            Head.Previous = seat;

            if (Rear == null)
            {
                Rear = Head;
            }

            Head = seat;
            return;

        }

        public void Print()
        {
            SeatNode current = new SeatNode();
            current = Head;

            if (current == null)
            {
                Console.WriteLine("The List is empty");
                return;
            }


            do
            {
                Console.WriteLine(current.seat.Id);
                current = current.Next;

            } while (current != null);

        }


        public SeatNode Search(String ID)
        {
            SeatNode current = new SeatNode();
            current = Head;

            while (current != null)
            {
                if (current.seat.Id == ID)
                {
                    return current;
                }

                current = current.Next;

            }
            return null;
        }

        public Row Search(bool gate)
        {
            Row Llist = new Row();
            SeatNode current = new SeatNode();
            current = Head;
            while (current != null)
            {
                if (current.seat.Reserved)
                {
                   Llist.HeadAdd(current.seat);
                }

                current = current.Next;
            }
            
            return Llist;
        }




    }
}