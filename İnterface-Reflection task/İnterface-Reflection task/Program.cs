using İnterface_Reflection_task.Models;
using System;
using static İnterface_Reflection_task.Exceptions.Ex;

namespace İnterface_Reflection_task
{
    class Program
    {
        static void Main(string[] args)
        {

            int doorCount = 0;
            string winCode = "";
            double horsePower = 0;
            double tankSize = 0;
            double currentOil = 0;
            string fuelType = "";
            string transmissionKind = "";
            double wheelThickness = 0;
            double wingLength = 0;
            double drivetime = 0;
            double drivepath = 0;
            string pedalkind = "";

            int key;
            do
            {
            Start:
                try
                {
                    Console.WriteLine("Reqem daxil edin\n1.Masin\n2.Velosiped\n3.Teyyare\n4.Son");
                    key = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Yalniz reqem daxil etmelisiniz");
                    goto Start;
                }
                switch (key)
                {
                    case 1:
                        ChekCar(ref doorCount, ref winCode, ref horsePower, ref tankSize, ref currentOil, ref fuelType, ref transmissionKind, ref wheelThickness, ref drivetime, ref drivepath);
                        Car car = new Car(doorCount,winCode,transmissionKind, wheelThickness,horsePower,tankSize,currentOil,fuelType, drivetime, drivepath);
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        car.ShowInfo();
                        break;
                    case 2:
                        InputBicycle(ref pedalkind, ref wheelThickness, ref drivetime, ref drivepath);
                        Bicycle bicycle = new Bicycle( wheelThickness,pedalkind, drivetime, drivepath);
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        bicycle.ShowInfo();
                        break;
                    case 3:
                        InputPlane(ref wingLength, ref horsePower, ref tankSize, ref currentOil, ref fuelType, ref transmissionKind, ref wheelThickness, ref drivetime, ref drivepath);
                        Plane plane = new Plane(wingLength, transmissionKind, wheelThickness, horsePower, tankSize, currentOil, fuelType, drivetime, drivepath);
                        Console.WriteLine("-------------------------------------------------------------------------------------------");
                        plane.ShowInfo();
                        break;
                    default:
                    case 4:
                        Console.WriteLine("End");
                        break;
                }

            } while (key != 4);



        }

        static void ChekCar(ref int doorCount,ref string winCode, ref double horsePower,ref double tankSize,ref double currentOil,ref string fuelType,ref string transmissionKind,ref double wheelThickness, ref double drivetime, ref double drivepath)
        {
            ChekDoorCount(ref doorCount);
            ChekWinCode(ref winCode);
            ChekHorsePower(ref horsePower);
            ChekTankSize(ref tankSize);
            ChekCurrentOil(ref currentOil);
            ChekFuelType(ref fuelType);
            ChekTransmissionKind(ref transmissionKind);
            ChekWheelThickness(ref wheelThickness);
            ChekDrivetime(ref drivetime);
            ChekDrivepath(ref drivepath);


        }

         static void ChekDrivepath(ref double drivepath)
        {
        Start:
            try
            {
                Console.WriteLine("Gedilen yolu daxil edin");
                drivepath = Convert.ToDouble(Console.ReadLine());
                if (drivepath < 0)
                {
                    throw new NotAvailableException("Duzgun daxil edilmiyib");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

    

     static void ChekDrivetime(ref double drivetime)
        {
        Start:
            try
            {
                Console.WriteLine("Gedilen vaxti qeyd edin ");
                drivetime = Convert.ToDouble(Console.ReadLine());
                if (drivetime < 0)
                {
                    throw new NotAvailableException("Duzgun daxil edilmedi");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        static void ChekHorsePower(ref double horsePower)
        {
        Start:
            try
            {
                Console.WriteLine("At gucunu daxil edin");
                horsePower = Convert.ToDouble(Console.ReadLine());
                if (horsePower < 5 || horsePower > 2000)
                    throw new NotAvailableException("5den kicik 1000den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }

        static void ChekWinCode( ref string winCode)
        {
        Start:
            try
            {
                Console.WriteLine("Win kodi qeyd edin");
                winCode = Convert.ToString(Console.ReadLine());
                if (string.IsNullOrEmpty(winCode) || string.IsNullOrWhiteSpace(winCode))
                {
                    throw new NullEmptyWhiteSpaceException("Mutleq daxil etmelisiniz");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

       static void ChekDoorCount(ref int doorCount)
        {
        Start:
            try
            {
                Console.WriteLine("Qapi sayini daxil edin");
                doorCount = Convert.ToInt32(Console.ReadLine());
                if (doorCount < 1 || doorCount > 4)
                    throw new NotAvailableException("Qapi sayi 1den az 4den cox ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }

        static void ChekWheelThickness(ref double wheelThickness)
        {
        Start:
            try
            {
                Console.WriteLine("Tekerin qalinligini qeyd edin");
                wheelThickness = Convert.ToDouble(Console.ReadLine());
                if (wheelThickness < 0 || wheelThickness > 50)
                    throw new NotAvailableException("Tekerin qalinligi 0dan kicik 50den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        static void ChekFuelType(ref string fuelType)
        {
        Start:
            try
            {
                Console.WriteLine("Yanacagin novunu qeyd edin");
                fuelType = Convert.ToString(Console.ReadLine());
                if (string.IsNullOrEmpty(fuelType) || string.IsNullOrWhiteSpace(fuelType))
                {
                    throw new NullEmptyWhiteSpaceException("Mutleq daxil etmelisiniz");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }

        static void ChekTransmissionKind(ref string transmissionKind)
        {
        Start:
            try
            {
                Console.WriteLine("Transmissiyani qeyd edin");
                transmissionKind = Convert.ToString(Console.ReadLine());
                if (string.IsNullOrEmpty(transmissionKind) || string.IsNullOrWhiteSpace(transmissionKind))
                {
                    throw new NullEmptyWhiteSpaceException("Mutleq daxil etmelisiniz");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        static void ChekCurrentOil(ref double currentOil)
        {
        Start:
            try
            {
                Console.WriteLine("Qaliq nefti qeyd edin");
                currentOil = Convert.ToDouble(Console.ReadLine());
                if (currentOil < 0 || currentOil > 150)
                    throw new NotAvailableException("0dan kicik 150den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        static void ChekTankSize(ref double tankSize)
        {
        Start:
            try
            {
                Console.WriteLine("Tank olcusunu qeyd edin");
                tankSize = Convert.ToDouble(Console.ReadLine());
                if (tankSize < 0 || tankSize > 150)
                    throw new NotAvailableException("0dan kicik 150den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        static void InputPlane(ref double wingLength, ref double horsePower, ref double tankSize, ref double currentOil, ref string fuelType, ref string transmissionKind, ref double wheelThickness, ref double drivetime, ref double drivepath)
        {
            InputWingLength(ref wingLength);
            InputHorsePower(ref horsePower);
            InpuTankSize(ref tankSize);
            InpuCurrentOil(ref currentOil);
            InpuFuelType(ref fuelType);
            InpuTransmissionKind(ref transmissionKind);
            InpuWheelThickness(ref wheelThickness);
            InputDrivePath(ref drivepath);
            InputDriveTime(ref drivetime);
        }

        private static void InputDriveTime(ref double drivetime)
        {
        Start:
            try
            {
                Console.WriteLine("Gedilen vaxti qeyd edin ");
                drivetime = Convert.ToDouble(Console.ReadLine());
                if (drivetime < 0)
                {
                    throw new NotAvailableException("Duzgun daxil edilmedi");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        private static void InputDrivePath(ref double drivepath)
        {
        Start:
            try
            {
                Console.WriteLine("Gedilen yolu daxil edin");
                drivepath = Convert.ToDouble(Console.ReadLine());
                if (drivepath < 0)
                {
                    throw new NotAvailableException("Duzgun daxil edilmiyib");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        static void InpuWheelThickness(ref double wheelThickness)
        {
        Start:
            try
            {
                Console.WriteLine("Tekerin qalinligini qeyd edin");
                wheelThickness = Convert.ToDouble(Console.ReadLine());
                if (wheelThickness < 0 || wheelThickness > 50)
                    throw new NotAvailableException("Tekerin qalinligi 0dan kicik 50den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }

         static void InpuTransmissionKind(ref string transmissionKind)
        {
        Start:
            try
            {
                Console.WriteLine("Transmissiyani qeyd edin");
                transmissionKind = Convert.ToString(Console.ReadLine());
                if (string.IsNullOrEmpty(transmissionKind) || string.IsNullOrWhiteSpace(transmissionKind))
                {
                    throw new NullEmptyWhiteSpaceException("Mutleq daxil etmelisiniz");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }

        private static void InpuFuelType(ref string fuelType)
        {
        Start:
            try
            {
                Console.WriteLine("Yanacagin novunu qeyd edin");
                fuelType = Convert.ToString(Console.ReadLine());
                if (string.IsNullOrEmpty(fuelType) || string.IsNullOrWhiteSpace(fuelType))
                {
                    throw new NullEmptyWhiteSpaceException("Mutleq daxil etmelisiniz");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }



        private static void InpuCurrentOil(ref double currentOil)
        {
        Start:
            try
            {
                Console.WriteLine("Qaliq nefti qeyd edin");
                currentOil = Convert.ToDouble(Console.ReadLine());
                if (currentOil < 0 || currentOil > 150)
                    throw new NotAvailableException("0dan kicik 150den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        private static void InpuTankSize(ref double tankSize)
        {
        Start:
            try
            {
                Console.WriteLine("Tank olcusunu qeyd edin");
                tankSize = Convert.ToDouble(Console.ReadLine());
                if (tankSize < 0 || tankSize > 150)
                    throw new NotAvailableException("0dan kicik 150den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }

        private static void InputHorsePower(ref double horsePower)
        {
        Start:
            try
            {
                Console.WriteLine("At gucunu daxil edin");
                horsePower = Convert.ToDouble(Console.ReadLine());
                if (horsePower < 5 || horsePower > 2000)
                    throw new NotAvailableException("5den kicik 1000den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }

        private static void InputWingLength(ref double wingLength)
        {
        Start:
            try
            {
                Console.WriteLine("Tank olcusunu qeyd edin");
                wingLength = Convert.ToDouble(Console.ReadLine());
                if (wingLength < 50 || wingLength > 500)
                    throw new NotAvailableException("50den kicik 500den boyuk ola bilmez");
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }


        static void InputBicycle(ref string pedalkind, ref double whellthickness, ref double drivetime, ref double drivepath)
        {
            InputBPedalKind(ref pedalkind);
            InputBWhellThickness(ref whellthickness);
            InputBDriveTime(ref drivetime);
            InputBDrivePath(ref drivepath);
        }
        static void InputBPedalKind(ref string pedalkind)
        {
        Start:
            try
            {
                Console.WriteLine("Pedalin novunu qeyd edin ");
                pedalkind = Console.ReadLine();
                if (string.IsNullOrEmpty(pedalkind) || string.IsNullOrWhiteSpace(pedalkind))
                {
                    throw new NullEmptyWhiteSpaceException("Mutleq daxil etmelisiniz");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }

        }
        static void InputBWhellThickness(ref double whellthickness)
        {
        Start:
            try
            {
                Console.WriteLine("Tekerin qalinligini qeyd edin");
                whellthickness = Convert.ToDouble(Console.ReadLine());
                if (whellthickness < 0)
                {
                    throw new NotAvailableException("Duzgun daxil edilmiyib");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem olmalidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputBDriveTime(ref double drivetime)
        {
        Start:
            try
            {
                Console.WriteLine("Gedilen vaxti qeyd edin ");
                drivetime = Convert.ToDouble(Console.ReadLine());
                if (drivetime < 0)
                {
                    throw new NotAvailableException("Duzgun daxil edilmedi");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }
        static void InputBDrivePath(ref double drivepath)
        {
        Start:
            try
            {
                Console.WriteLine("Gedilen yolu daxil edin");
                drivepath = Convert.ToDouble(Console.ReadLine());
                if (drivepath < 0)
                {
                    throw new NotAvailableException("Duzgun daxil edilmiyib");
                }

            }
            catch (FormatException)
            {
                Console.WriteLine("Yalniz reqem daxil edilmelidir");
                goto Start;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                goto Start;
            }
        }


}   }

    


