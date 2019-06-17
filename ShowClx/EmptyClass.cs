using System;
namespace ShowClx
{
	public class Seat
	{
		
	    public String Id { get; set; }
		Boolean Reserved { get; set; }
		public Seat Next {get; set;}
        public Seat Previous { get; set; }

		public Seat(String str) {Id = str;}
        public Seat() { }
        
    }
}
