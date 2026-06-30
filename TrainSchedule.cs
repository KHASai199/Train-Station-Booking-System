using System;
using System.Collections.Generic;
using System.Text;

namespace Project
{
       internal class TrainSchedule
        {
            public string TrainNumber { get; set; }
            public string From { get; set; }
            public string To { get; set; }
            public string DepartTime { get; set; }
            public string ArriveTime { get; set; }
            public string Status { get; set; }
            public TrainSchedule(string trainNumber, string from, string to,
                                 string departTime, string arriveTime, string status)
            {
                TrainNumber = trainNumber;
                From = from;
                To = to;
                DepartTime = departTime;
                ArriveTime = arriveTime;
                Status = status;
            }
        }
}

