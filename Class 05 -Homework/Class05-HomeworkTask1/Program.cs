using System;



namespace Class05_HomeworkTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Driver[] drivers = new Driver[4];
            drivers[0] = new Driver("Perica", 8);
            drivers[1] = new Driver("Goce", 5);
            drivers[2] = new Driver("Stanko", 4);
            drivers[3] = new Driver("Dojcin", 7);

            Car[] cars = new Car[4];
            cars[0] = new Car("Mazda", 46);
            cars[1] = new Car("Renault", 42);
            cars[2] = new Car("Bmw", 31);
            cars[3] = new Car("Audi", 24);

            
            Car[] raceCar = new Car[1];
            Car[] raceCar1 = new Car[1];

            while (true)
            {

                while (true)
                {
                    Console.WriteLine("Please select a car from the options  below");
                    foreach (Car car in cars)
                    {
                        Console.WriteLine(car.Model);

                    }
                    string inputCar = Console.ReadLine();
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (inputCar.ToLower() == cars[i].Model.ToLower())
                        {
                            raceCar[0] = cars[i];
                            break;
                        }

                    }
                    if (raceCar[0] == null|| raceCar[0].Model.ToLower() != inputCar.ToLower())
                    {
                        Console.WriteLine("U must select only from the options given");
                        Console.WriteLine("=========================================");
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Please select a driver from the options  below");
                    foreach (Driver driver in drivers)
                    {
                        Console.WriteLine(driver.Name);

                    }
                    string inputDriver = Console.ReadLine();
                    for (int i = 0; i < drivers.Length; i++)
                    {
                        if (inputDriver.ToLower() == drivers[i].Name.ToLower())
                        {
                            raceCar[0].Driver = drivers[i];
                            break;
                        }
                    }
                    if (raceCar[0].Driver == null|| raceCar[0].Driver.Name.ToString().ToLower()!=inputDriver.ToLower())
                    {
                        Console.WriteLine("U must select only from the options given");
                        Console.WriteLine("=========================================");
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }

                }
                while (true)
                {
                    Console.WriteLine("Please select a second car from the options  below");
                    foreach (Car car in cars)
                    {
                        Console.WriteLine(car.Model);

                    }
                    string inputCar2 = Console.ReadLine();

                    if (inputCar2.ToLower() == raceCar[0].Model.ToLower())
                    {
                        Console.WriteLine($"The car model {raceCar[0].Model} has already been chosen please select another car");
                        continue;
                    }
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (inputCar2.ToLower() == cars[i].Model.ToLower())
                        {
                            raceCar1[0] = cars[i];
                            break;
                        }
                    }
                    if (raceCar1[0] == null || raceCar1[0].Model.ToLower() != inputCar2.ToLower())
                    {
                        Console.WriteLine("U must select only from the options given");
                        Console.WriteLine("=========================================");
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }
                }

                while (true)
                {

                    Console.WriteLine("Please select a second driver from the options  below");
                    foreach (Driver driver in drivers)
                    {
                        Console.WriteLine(driver.Name);

                    }
                    string inputDriver2 = Console.ReadLine();

                    if (inputDriver2.ToLower() == raceCar[0].Driver.Name.ToLower())
                    {
                        Console.WriteLine($"The driver {raceCar[0].Driver.Name} has already been chosen please select another driver");
                        continue;
                    }
                    for (int i = 0; i < drivers.Length; i++)
                    {
                        if (inputDriver2.ToLower() == drivers[i].Name.ToLower())
                        {
                            raceCar1[0].Driver = drivers[i];
                        }
                    }
                    if (raceCar1[0].Driver == null || raceCar1[0].Driver.Name.ToString().ToLower() != inputDriver2.ToLower())
                    {
                        Console.WriteLine("U must select only from the options given");
                        Console.WriteLine("=========================================");
                        continue;
                    }
                    else
                    {
                        Console.Clear();
                        break;
                    }


                }
                RaceCars(raceCar[0],raceCar1[0]);
                Console.WriteLine("Press any key to race again or press (no) to quit");
                string ans = Console.ReadLine();
                if (ans.ToLower() == "no")
                {
                    Console.Clear();
                    break;
                }
                else
                {
                    Console.Clear();
                    continue;
                }


            }


            static void RaceCars(Car one, Car two)
            {


                if (one.CalcSpeed(one.Driver) > two.CalcSpeed(two.Driver))
                {
                    Console.WriteLine($"The first driver {one.Driver.Name} will win the race with the car {one.Model} going with speed of {one.CalcSpeed(one.Driver)}km/h");
                }
                else if (one.CalcSpeed(one.Driver) < two.CalcSpeed(two.Driver))
                {
                    Console.WriteLine($"The second driver {two.Driver.Name} will win the race with the car {two.Model} going with speed of {two.CalcSpeed(two.Driver)}km/h");
                }
                else
                {
                    Console.WriteLine("Its a tie");
                }
            }



        }
}   }
