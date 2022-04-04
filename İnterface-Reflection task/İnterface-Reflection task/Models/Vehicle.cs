using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface_Reflection_task.Models
{
    abstract class Vehicle
    {
        private double _driveTime;
        private double _drivePath;
        public double DriveTime
        {
         
            get { return _driveTime; }
            set
            {
                if (value>=0)
                {
                    _driveTime = value;
                };
          
            }
        }
        public double DrivePath
        {
            get { return _drivePath; }
            set
            {
                if (value >= 0)
                {
                    _drivePath = value;
                };
            }
        }
        public double AverageSpeed()
        {
            return ( DrivePath/DriveTime) ;
        }



    }
}
