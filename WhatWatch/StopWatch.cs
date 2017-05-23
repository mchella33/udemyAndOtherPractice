using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhatWatch
{
    class StopWatch
    {
        public System.DateTime startTime { get; set; }
        public System.DateTime stopTime { get; set; }
        public TimeSpan ElapsedTime;

        public void Start()
        {
            startTime = DateTime.Now;
            
        }

        public void Stop()
        {
            stopTime = DateTime.Now;
        }

        public void Timer()
        {
            ElapsedTime = stopTime - startTime;
        }

    }
}
