// See https://aka.ms/new-console-template for more information
using App1;
using System.Diagnostics;
using System.Formats.Asn1;
    string firstname;
    string lastname;
    int age;
    string name;
    int topSpeed;
    int horsepower;
    double acceleration;
    IVehicle vehicle; 
    int vehicleType;
    Driver secondaryDriver = new Driver("","",0);
    IList<IVehicle> vehicles= new List<IVehicle>();
    do
    {

        Console.WriteLine("Do you want formula or car race ? (0 or 1)");
        vehicleType = Int32.Parse(Console.ReadLine());

    } while (vehicleType != 0 && vehicleType != 1);
    int raceType;
    do
    {

        Console.WriteLine("Do you want circuit or sprint race ? (0 or 1)");
        raceType = Int32.Parse(Console.ReadLine());

    } while (raceType != 0 && raceType != 1);

    Console.WriteLine("How many veichles do you want?");
    int numberOfVehicles = Int32.Parse(Console.ReadLine());
    for (int i = 0; i < numberOfVehicles; i++)
    {
        Console.WriteLine("Enter main driver's firstname:");
        firstname = Console.ReadLine();
        Console.WriteLine("Enter main driver's lastame:");
        lastname = Console.ReadLine();
        Console.WriteLine("Enter main driver's age");
        age=Int32.Parse(Console.ReadLine());
        Driver driver= new Driver(firstname, lastname, age);

        if (vehicleType==1)
        {
            Console.WriteLine("Enter secondary driver's firstname:");
            firstname = Console.ReadLine();
            Console.WriteLine("Enter secondarydriver's lastame:");
            lastname = Console.ReadLine();
            Console.WriteLine("Enter secondary driver's age");
            age = Int32.Parse(Console.ReadLine());
            secondaryDriver = new Driver(firstname, lastname, age);
        }
        Console.WriteLine("Enter vehicle name");
        name= Console.ReadLine();
        Console.WriteLine("Enter veichle acceleration (just number");
        acceleration = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter veihcle Top speed (just number");
        topSpeed = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Enter veihcle Horsepower (just number");
        horsepower= Int32.Parse(Console.ReadLine());
        if (vehicleType == 0)
            vehicle = new Formula(name, horsepower, topSpeed, acceleration, driver);
        else
            vehicle = new Car(name, horsepower, topSpeed, acceleration, driver, secondaryDriver);
                vehicles.Add(vehicle);
}
        Race race;
        RaceService raceService= new RaceService();
        if (raceType == 0)
            race = new CircuitRace(vehicles, raceService);
        else
            race = new SprintRace(vehicles, raceService);
        Console.WriteLine(race.StartRace().ToString());
        vehicles[0].IncraseTopSpeed(10);
        Console.WriteLine("Race started again, but this time 1st veichle has 10 km/h higher topspeed");
        Console.WriteLine(race.StartRace().ToString());

        





