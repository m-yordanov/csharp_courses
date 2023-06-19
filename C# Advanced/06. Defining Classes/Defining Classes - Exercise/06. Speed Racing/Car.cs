namespace SpeedRacing;

public class Car
{
    private string model;
    private double fuelAmount;
    private double fuelConsumptionPerKilometer;
    private double travelledDistance;

    public Car()
    {

    }

    public Car(string model, double fuelAmount, double fuelConsumption)
    {
        this.Model = model;
        this.FuelAmount = fuelAmount;
        this.FuelConsumptionPerKilometer = fuelConsumption;
        this.TravelledDistance = 0;
    }

    public string Model
    {
        get { return this.model; }
        set { this.model = value; }
    }
    public double FuelAmount
    {
        get { return this.fuelAmount; }
        set { this.fuelAmount = value; }
    }
    public double FuelConsumptionPerKilometer
    {
        get { return this.fuelConsumptionPerKilometer; }
        set { this.fuelConsumptionPerKilometer = value; }
    }
    public double TravelledDistance
    {
        get { return this.travelledDistance; }
        set { this.travelledDistance = value; }
    }


    public void CanItMove(string model, double amountKm)
    {
        double neededFuel = amountKm * this.FuelConsumptionPerKilometer;

        if (this.FuelAmount >= neededFuel)
        {
            this.fuelAmount -= neededFuel;
            this.TravelledDistance += amountKm;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
    }
}