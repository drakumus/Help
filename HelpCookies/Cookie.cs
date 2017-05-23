using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelpCookies
{
    public partial class Cookie : Form
    {
        private int time;

        public Cookie()
        {
            time = 0;

            InitializeComponent();
        }

        private void Cookie_Load(object sender, EventArgs e)
        {

            #region TimeUntilReset
            DateTime currentTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(
    DateTime.UtcNow, "Eastern Standard Time");

            double currentDay = 0;
            double currentSeconds = currentTime.Second + (currentTime.Minute * 60) + (currentTime.Hour * 3600);
            double progressToReset;

            switch (currentTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    currentDay = 0;
                    break;
                case DayOfWeek.Tuesday:
                    currentDay = 1;
                    break;
                case DayOfWeek.Wednesday:
                    currentDay = 2;
                    break;
                case DayOfWeek.Thursday:
                    currentDay = 3;
                    break;
                case DayOfWeek.Friday:
                    currentDay = 4;
                    break;
                case DayOfWeek.Saturday:
                    currentDay = 5;
                    break;
                case DayOfWeek.Sunday:
                    currentDay = 6;
                    break;
            }

            double percentOfDay = currentSeconds/86400;
            progressToReset = 100 * (currentDay + percentOfDay) /7;

            timeBar.Step = (int)progressToReset;
            
            //initialize values here
            //this.timeBar.Step = 100;
            this.timeBar.PerformStep();
            #endregion

            Timer timer = new Timer();
            timer.Interval = 100;

            timer.Tick += new EventHandler(OnTimedEvent);
            timer.Start();
        }

        private void OnTimedEvent(Object source, EventArgs e)
        {
            if(time < 100)
            {
                incBar.Step = 1;
                incBar.PerformStep();
            }
        } 
    }
}
