using System;
using System.Collections.Generic;
using System.Text;

namespace ClockDisplay
{
    class ClockDisplay: IUpdateAble
    {
        public Timer timer;
        public NumberDisplay secondsDisplay;
        public NumberDisplay minutesDisplay;
        // hours
        public NumberDisplay hoursDisplay;
        // days
        public NumberDisplay daysDisplay;

        public ClockDisplay()
        {
            // days
             this.daysDisplay = new NumberDisplay(365, this);

            // hours
            this.hoursDisplay = new NumberDisplay(24, this);

            // minutes
            this.minutesDisplay = new NumberDisplay(60, this);

            // seconds
            this.secondsDisplay = new NumberDisplay(60, minutesDisplay);

            // timer geeft de eerste display in de keten een schop
            timer = new Timer(secondsDisplay, this);
        }

        public void Start()
        {
            this.timer.Start();
        }

        public void Update()
        {
            string time = $"Het is vandaag:{daysDisplay} en de tijd is:{hoursDisplay}:{minutesDisplay}:{secondsDisplay}";

            Console.Clear();
            Console.Write(time);
     
        }
    }
}
