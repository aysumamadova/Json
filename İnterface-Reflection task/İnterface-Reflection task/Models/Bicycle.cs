using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface_Reflection_task.Models
{
    class Bicycle:Vehicle,IWheel
    {
        private double _wheelThickness;
        private string _pedalKind;
        private double _drivetime;
        private double _drivepath;
        public string PedalKind 
        {
            get { return _pedalKind; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _pedalKind = value;
                };

            }
        }
        public double WheelThickness
        {
            get { return _wheelThickness; }
            set
            {
                if (value > 0 || value <= 50)
                {
                    _wheelThickness = value;
                };

            }
        }
        public double DriveTime
        {
            get
            {
                return _drivetime;
            }
            set
            {
                if (value > 0)
                {
                    _drivetime = value;
                }
            }
        }
        public double DrivePath
        {
            get
            {
                return _drivepath;
            }
            set
            {
                if (value > 0)
                {
                    _drivepath = value;
                }
            }
        }

    public Bicycle(double wheelThickness,string pedalKind,double drivepath,double drivetime)
        {
            WheelThickness = wheelThickness;
            PedalKind = pedalKind;
            DrivePath = drivepath;
            DriveTime = drivetime;
        }
    }

       
}
