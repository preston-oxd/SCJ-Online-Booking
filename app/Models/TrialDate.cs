using SCJ.Booking.MVC.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCJ.Booking.MVC.Models
{
    public class TrialDate
    {
        public TrialType TrialType { get; set; }
        public int BookingSlotsAvailable { get; set; }
        public DateTime Date { get; set; }
    }
}
