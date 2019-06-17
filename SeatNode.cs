using System;
using System.Collections.Generic;
using System.Text;

namespace SC
{
    public class SeatNode
    {
        public Seat seat { get; set; }
        public SeatNode Next { get; set; }
        public SeatNode Previous { get; set; }
        public SeatNode(Seat info, SeatNode n, SeatNode p) { seat = info; Next = n; Previous = p;}
        public SeatNode(Seat info) { seat = info;}
        public SeatNode() { }
    }
}
