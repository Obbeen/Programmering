using System;
using System.Collections.Generic;
using System.Text;
using ParkingMachineConsoleTicket;

namespace ParkingMachineConsole
{
    /// <summary>
    /// An sodsffsdfbject of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;


        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;
        public double CostPerHour
        {
            get
            {
                return costPerHour;
            }
        }

        public ParkingMachine(int costPerH)
        {
            total = 0;
            currentTotal = 0;
            costPerHour = costPerH;
        }

        public ParkingMachine()
        {
            total = 0;
            currentTotal = 0;
            costPerHour = 20;
        }

        public int CurrentTotal
        {
            get
            {
                return currentTotal;
            }
        }

        public int Total 
        { 
            get
            {
                return total;
            }
        }

        public void InsertMoney(int value)
        {

            if (value > 0)
            {
                currentTotal = value + currentTotal;
            }
        }
        public int Cancel()
        {
            int temp = currentTotal;
            currentTotal = 0;
            return temp;
        }



        public void BuyTicket2Dar3Hour15Min_TicketText()
        {
            throw new NotImplementedException();
        }
        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes";
        }

        public TimeSpan GetParkingTimeSpan()
        {
            int days = Convert.ToInt32((currentTotal / costPerHour) / 24);
            int hours = Convert.ToInt32((currentTotal / costPerHour) % 24);
            int minutes = Convert.ToInt32((currentTotal * 60 / costPerHour) % 60);
            return new TimeSpan(days: days, hours: hours, minutes: minutes, seconds: 0);
        }
        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;
            date = date.Add(GetParkingTimeSpan());
            return date;
        }
        public Ticket BuyTicket()
        {
            total = currentTotal + total;
            Ticket biljett = new Ticket(currentTotal, costPerHour);
            currentTotal = 0;
            return biljett;
        }

    }

}
