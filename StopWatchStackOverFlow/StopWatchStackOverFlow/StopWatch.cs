using System;
using System.Collections.Generic;
using System.Text;

namespace StopWatchStackOverFlowProject
{
    class StopWatch
    {
        public DateTime _StartTime;
        public DateTime _StopTime;
        public Boolean _IsRunning;

        public void Start()
        {
            if (_IsRunning)
            {
                throw new InvalidOperationException("Stop watch is already started");
            }
            _StartTime = DateTime.Now;
            _IsRunning = true;
        }

        public void Stop()
        {
            if (!_IsRunning)
            {
                throw new InvalidOperationException("Stop watch is in stope mode alraedy");
            }
            _StopTime = DateTime.Now;
            _IsRunning = false;
        }

        public TimeSpan Duration()
        {
            if (_IsRunning)
            {
                return (DateTime.Now - _StartTime);
            }
            else
            {
                return _StopTime - _StartTime;
            }
        }
    }
}
