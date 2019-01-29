using System;

namespace SCJ.Booking.MVC.ViewModels
{
    public class CaseConfirmViewModel
    {
        //Case number
        public string CaseNumber { get; set; }

        //Conference type
        public string TypeOfConferenceHearing { get; set; }

        //Location for the booking
        public string LocationName { get; set; }

        //Date for the booking
        public string Date { get; set; }

        //Time for booking 
        public string Time { get; set; }

        //indicate if the timeslot was available on the time the user clicked on the confirm button
        public bool IsTimeslotAvailable { get; set; }

        //indicate if the case was booked sucessfully
        public bool IsBooked { get; set; }

        //ContainerId for locations
        public int ContainerId { get; set; }

        //Location id
        public int LocationId { get; set; }

        //Full date for the booking
        public DateTime FullDate { get; set; }

        //User email address
        public string EmailAddress { get; set; }

        //Is user known?
        public bool IsUserKnown { get; set; }

        //Phone number
        public string Phone { get; set; }
    }
}
