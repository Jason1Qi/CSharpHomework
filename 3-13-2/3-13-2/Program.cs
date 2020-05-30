using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alarm_clock
{
    public delegate void ClockAlarm(object sender, ClockEventArgs args);
    public class ClockEventArgs
    {
        public int CurrentHour;
        public int CurrentMinute;
        public int CurrentSecond;
        public int SetHour = 3;
        public int SetMinute = 4;
        public int SetSecond = 5;
    }

    public class Clock
    {
        public event ClockAlarm Tick;
        public event ClockAlarm Alarm;
        private DateTime AlarmTime;
        public void SClick(int Hour, int Minute, int Second)
        {
            Console.Write($"现在是{Hour}时{Minute}分{Second}秒");
            ClockEventArgs args1 = new ClockEventArgs()
            {
                CurrentHour = Hour,
                CurrentMinute = Minute,
                CurrentSecond = Second
            };
            Alarm(this, args1);
        }
        public void Click(int Hour, int Minute, int Second)
        {
            Console.Write($"现在是{Hour}时{Minute}分{Second}秒");
            ClockEventArgs args = new ClockEventArgs()
            {
                CurrentHour = Hour,
                CurrentMinute = Minute,
                CurrentSecond = Second
            };

            while (true)
            {
                Tick(this, args);
                System.Threading.Thread.Sleep(1000);
            }
        }
    }

    public class Form
    {
        public Clock Tick1 = new Clock();
        public Clock Alarm2 = new Clock();
        public Form()
        {
            Tick1.Tick += new ClockAlarm(Clock_Tick);
            Alarm2.Alarm += new ClockAlarm(Clock_Alarm);
        }
        void Clock_Tick(object sender, ClockEventArgs args)
        {
            Console.Write("闹钟正在走");
        }
        void Clock_Alarm(object sender, ClockEventArgs args)
        {
            if (args.CurrentHour == args.SetHour && 
                args.CurrentMinute == args.SetMinute && 
                args.CurrentSecond == args.SetSecond)
            {



                Console.Write("闹钟响铃");

            }

            else Console.Write("闹钟没有响铃");

        }



        public class SForm

        {

            public Clock Tick2 = new Clock();

            public Clock Alarm2 = new Clock();

            public SForm()

            {

                Alarm2.Tick += new ClockAlarm(Clock_Alarm);

            }

            void Clock_Alarm(object sender, ClockEventArgs args)

            {

                if (args.CurrentHour == args.SetHour && args.CurrentMinute == args.SetMinute && args.CurrentSecond == args.SetSecond)

                {



                    Console.Write("闹钟正在响铃！");

                }

                else Console.Write("闹钟未到响铃时刻!");

            }



        }

    }

    class Program

    {

        static void Main(string[] args)

        {







             Form form1 = new Form();

             form1.Tick1.Click(3, 4, 5);

            Form form2 = new Form();

            form2.Alarm2.SClick(4, 4, 5);

        }

    }

}