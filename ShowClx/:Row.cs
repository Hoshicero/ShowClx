using System;
namespace ShowClx
{
	public class Row
	{

		public Seat Head { get; set; }
		public Seat Rear { get; set; }

		public void Start(Seat seat)
		{
			Head = seat;
            Head.Next = Rear; 
			Rear.Previous = Head;
		}

		public void RearAdd(Seat seat)
		{
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


		public void HeadAdd(Seat seat)
		{
            if(Head == null)
			{
				Start(seat);
				return;
			} 

			seat.Next = Head;
			Head.Previous = seat;

            if (Rear == null)
            {
               Rear = Head;
            }

            Head = seat;
          
		}

		public void Print()
		{
			Seat current = new Seat();
			current = Head;

			if (current == null)
			{
				Console.WriteLine("The List is empty");
				return;
			}


            do
            {
                Console.WriteLine(current.Id);
                current = current.Next;

            } while (current != null);

		}

		
        public Seat Search(String ID)
        {
            Seat current = new Seat();
            current = Head;

            while (current != null)
            {
                if (current.Id == ID)
                {
                    return current;
                }

                current = current.Next;
      
            }
                return null;
        }


        
        
    }
}
