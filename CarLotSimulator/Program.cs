using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car - DONE!
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable - DONE!
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() - DONE!
            //The methods should take one string parameter: the respective noise property - DONE!


            //Now that the Car class is created we can instanciate 3 new cars - DONE!
            //Set the properties for each of the cars - DONE!
            //Call each of the methods for each car - DONE!
            var lot = new CarLot();

            Car challenger = new Car();
            
                challenger.Make = "Dodge";
                challenger.Model = "Challenger";
                challenger.Year = 2018;
                challenger.EngineNoise = "Vroom";
                challenger.HonkNoise = "Train horn";
                challenger.IsDrivable = true;
                challenger.MakeEngineNoise();
                challenger.MakeHonkNoise();
                lot.Cars.Add(challenger);

            Car charger = new Car()
            {
                Make = "Dodge",
                Model = "Charger",
                Year = 2022,
                EngineNoise = "Vroom",
                HonkNoise = "Train horn",
                IsDrivable = true,
            };
            charger.MakeEngineNoise();
            charger.MakeHonkNoise();
            lot.Cars.Add(charger);

            Car trx = new Car("Ram", "Trx", 2022, "Vroom", "Train horn", true);
            lot.Cars.Add(trx);

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
            
            Console.WriteLine($"number of cars created: {CarLot.numberOfCars}");

            foreach (var car in lot.Cars)
            {
                Console.WriteLine($"Year: {car.Year} Make: {car.Make} Model: {car.Model}");
            }

        }
    }
}
