using System;
using System.Collections.Generic;
using System.Text;

namespace İnterface_Reflection_task.Models
{
    class Plane : Vehicle, IWheel, ITransmission, IEngine
    {
        private double _wingLength;
        private double _horsePower;
        private double _tankSize;
        private double _currentOil;
        private string _fuelType;
        private string _transmissionKind;
        private double _wheelThickness;
        private double _driveTime;
        private double _drivePath;
        public double WingLength
        {
            get { return _wingLength; }
            set
            {
                if (value >= 50 || value <= 500)
                {
                    _wingLength = value;
                };

            }
        }
        public double HorsePower
        {
            get { return _horsePower; }
            set
            {
                if (value >= 5 || value <= 1000)
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
                if (value >= 500 || value <= 2000)
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
                if (value > 0 || value <= 100)
                {
                    _wheelThickness = value;
                };

            }
        }
        public double DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if (value > 0)
                {
                    _driveTime = value;
                }
            }
        }
        public double DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                }
            }
        }
        public Plane(double wingLength, string transmissionKind, double wheelThickness, double horsePower, double tankSize, double currentOil, string fuelType, double driveTime, double drivePath)
        {
            WingLength = wingLength;
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


