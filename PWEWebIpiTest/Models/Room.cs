using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PWEWebIpiTest.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RoomNo { get; set; }
        public bool Occupied { get; set; }
    }
}