using System;

namespace Exercise_6
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();
        }

        private static void MainMenu()
        {
            Console.WriteLine("Welcome, prepare yourself to go on a mission...\n");
            Console.WriteLine("First, select your weapon");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Weapons: ");
            Console.WriteLine("1. M4");
            Console.WriteLine("2. 240L");


            int weapon = Convert.ToInt32(Console.ReadLine());


            if (weapon == 1)
            {
                M4 newM4 = new M4();
                newM4.LoadWeapon();
                SelectVehicle();

            }
            else if (weapon == 2)
            {
                _240L new240 = new _240L();
                new240.LoadWeapon();
                SelectVehicle();
            }
            else
                Console.WriteLine("Invalid Input");
        }

        private static void SelectVehicle()
        {
            Console.WriteLine("Great! Now prepare for infil..");
            Console.WriteLine("Enter a vehicle of your choosing to travel to the objective");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Vehicles: ");
            Console.WriteLine("1. GMV");
            Console.WriteLine("2. Stryker");
            Console.WriteLine("3. CH47");


            int vehicle = Convert.ToInt32(Console.ReadLine());

            if (vehicle == 1)
            {
                GMV myGMV = new GMV();
                myGMV.ConductPMCS();
                Console.WriteLine("Mount your machineguns by pressing enter");
                Console.ReadLine();
                myGMV.Mountmachineguns();
                Console.WriteLine("Press enter to turn on your lights and disengage the handbrake");
                Console.ReadLine();
                myGMV.TurnonLights();
                myGMV.DisengageHandbrake();
                Console.WriteLine("Press enter to start your engine");
                Console.ReadLine();
                myGMV.StartEngine("CRRAAANNNK");
                Console.WriteLine("When you are ready, press any key to drive to your target object");
                Console.ReadLine();
                myGMV.Drive();
                Console.WriteLine("Press enter when you to complete your trip");
                Console.ReadLine();
                myGMV.StopEngine("VDO!!");
                TakeContact();



            }

            else if (vehicle == 2)
            {
                Stryker myStryker = new Stryker();
                myStryker.ConductPMCS();
                Console.WriteLine("Inspect your CROW system by pressing any key");
                Console.ReadLine();
                myStryker.InspectCrowSystem();
                Console.WriteLine("Now load the stryker and lift the ramp");
                Console.ReadLine();
                myStryker.LiftRamp();
                Console.WriteLine("When you are ready, press any key to drive to your target object");
                Console.ReadLine();
                myStryker.Drive();
                Console.WriteLine("Press enter when you to complete your trip");
                Console.ReadLine();
                myStryker.StopEngine("VDO!!");
                TakeContact();

            }

            else if (vehicle == 3)
            {
                CH47 myCH47 = new CH47();
                myCH47.ConductPMCS();
                Console.WriteLine("Enter the bird and lift the ramp");
                Console.ReadLine();
                myCH47.RaiseRamp();
                myCH47.GainLift();
                Console.WriteLine("When you are ready, press any key to fly to your target object");
                Console.ReadLine();
                myCH47.Drive();
                Console.WriteLine("Press enter when you to complete your trip");
                Console.ReadLine();
                myCH47.StopEngine("Get out in half moon");
                TakeContact();

            }
            else
                Console.WriteLine("Invalid Input");
                SelectVehicle();
            
        }

        private static void TakeContact()
        {
            Console.WriteLine("You have successfully infiled on your target objective...");
            Console.WriteLine("<2 minutes later>");
            Console.WriteLine("CONTACT! 12 O'CLOCK, 200M! RETURN FIRE");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Press enter to return fire with your selected weapon");

            Weapon myweapon = new Weapon();
            Console.ReadLine();
            myweapon.FireWeapon("Bang bang bang");

            Console.WriteLine();
            Console.WriteLine("Small arms fire isn't going to be enough");
            Console.WriteLine("We need to call for fire \n");
            Callff();

        }

        private static void Callff()
        {
            Console.WriteLine("What should we call in?");
            Console.WriteLine("1. Mortars");
            Console.WriteLine("2. Apache");

            int callff = Convert.ToInt32(Console.ReadLine());

            if(callff == 1)
            {
                Mortar newMortar = new Mortar();
                Console.WriteLine("Mortars are being loaded");
                newMortar.Load();
                Console.ReadLine();
                Console.WriteLine("Firing...");
                newMortar.Fire();
                Console.WriteLine("Shots missed...\n");
                newMortar.ReLoad();
                Console.WriteLine("Target hit, press enter to fire for effect\n");
                Console.ReadLine();
                newMortar.Fireforeffect();
                Console.ReadLine();
                ReturntoBase();
            }

            else if (callff == 2)
            {
                Apache newApache = new Apache();
                Console.WriteLine("Apache inbound\n");
                Console.ReadLine();
                newApache.Load();
                Console.WriteLine("Rounds incoming\n");
                newApache.Fire();
                Console.WriteLine("Target almost destroyed, need to do another pass\n");
                Console.WriteLine("Press enter to have the apache re-engage and destroy the target");
                Console.ReadLine();
                newApache.ReLoad();
                newApache.Fireforeffect();
                Console.ReadLine();
                ReturntoBase();

            }
            else
                Console.WriteLine("Mission Complete");
            


        }

        private static void ReturntoBase()
        {
            Console.WriteLine("Mission complete. Let's head back to base");
            Console.WriteLine("........<returning to base>...............");
            Console.WriteLine("........<returning to base>...............");
            Console.WriteLine("........<returning to base>...............");
            Console.WriteLine("Welcome back, job well done.");
            Console.WriteLine("Now back, get your weapon cleaned, and get ready for the next mission");
            Weapon newweapon = new Weapon();
            newweapon.Clean();
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadLine();
            MainMenu();
        }
       
    }
          
                    
}
