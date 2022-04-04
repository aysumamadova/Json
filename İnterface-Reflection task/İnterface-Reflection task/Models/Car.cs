using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface_Reflection_task.Models
{
    class Car : Vehicle, IEngine, ITransmission, IWheel
    {
        private int _doorCount;
        private string _winCode;
        private double _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        private string _transmissionKind;
        private double _wheelThickness;
        private double _drivetime;
        private double _drivepath;

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
        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value >= 1||value<=4)
                {
                    _doorCount = value;
                };

            }
        }
        public string WinCode
        {
            get { return _winCode; }
            set
            {
                if (!string.IsNullOrEmpty(value)||!string.IsNullOrWhiteSpace(value))
                {
                    _winCode = value;
                };

            }
        }

        public double HorsePower
        {
            get { return _horsePower; }
            set
            {
                if (value >= 5||value<=1000)
                {
                    _horsePower = value;
                };

            }
        }
        public double TankSize
        {
            get { return _tankSize; }
            set
            {
                if (value >=10 || value <= 150)
                {
                    _tankSize = value;
                };

            }
        }
        public double CurrentOil
        {
            get { return _currentOil; }
            set
            {
                if (value >= 0 || value <= _tankSize)
                {
                    _currentOil = value;
                };

            }
        }
        public string FuelType
        {
            get { return _fuelType; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _fuelType = value;
                };

            }
        }
        public string TransmissionKind
        {
            get { return _transmissionKind; }
            set
            {
                if (!string.IsNullOrEmpty(value) || !string.IsNullOrWhiteSpace(value))
                {
                    _transmissionKind = value;
                };

            }
        }
        public double WheelThickness
        {
            get { return _wheelThickness; }
            set
            {
                if (value > 0||value<=50)
                {
                    _wheelThickness = value;
                };

            }
        }
        public Car(int doorCount, string winCode, string transmissionKind, double wheelThickness, double horsePower, double tankSize, double currentOil, string fuelType, double driveTime, double drivePath)
        {
            DoorCount = doorCount;
            WinCode = winCode;
            TransmissionKind = transmissionKind;
            WheelThickness = wheelThickness;
            HorsePower = horsePower;
            TankSize = tankSize;
            CurrentOil = currentOil;
            FuelType = fuelType;
            DriveTime = driveTime;
            DrivePath = drivePath;
        }

        public double LeftFuelAmount()
        {
            return TankSize - CurrentOil;
        }

    }
    
}

