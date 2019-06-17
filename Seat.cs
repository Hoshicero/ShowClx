using System;
using System.Collections.Generic;
using System.Text;

namespace SC
{
    public class Seat
    {

        public String Id { get; set; }
        public Boolean  Reserved { get; set; }
        public Seat(String str) { Id = str; }
        public Seat() { }

    }
}