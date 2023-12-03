public interface Builder
{
    void reset();
    void setSeats(int number);
    void setEngine(float engine);
    void setTripComputer();
    void setGPS();
}

public class Director
{
    public void MakeSUV(Builder builder)
    {
        Console.WriteLine("SUV Vehicle Was Made");


        // Normalda SUV custom car yaradilir
    }
    public void MakeSportsCar(Builder builder)
    {
        Console.WriteLine("Sports Car Was Made");

        // Normalda Sports Car custom car yaradilir
    }
}

public abstract class AbstractVehicle // ozumden elave
{
    public float Engine { get; set; }
    public bool GPS { get; set; }
    public int SeatsNumber { get; set; }
    public bool TripComputer { get; set; }
}

public class Car : AbstractVehicle
{

}

public class ManualCar : AbstractVehicle
{

}

public class CarBuilder : Builder
{
    private Car car;

    public void reset()
    {
        this.car = new Car();
    }

    public void setEngine(float engine)
    {
        this.car.Engine = engine;
    }

    public void setGPS()
    {
        this.car.GPS = true;
    }

    public void setSeats(int number)
    {
        this.car.SeatsNumber = number;
    }

    public void setTripComputer()
    {
        this.car.TripComputer = true;
    }

    public Car getResult() => this.car;
}

public class ManualCarBuilder : Builder
{
    private ManualCar car;

    public void reset()
    {
        this.car = new ManualCar();
    }

    public void setEngine(float engine)
    {
        this.car.Engine = engine;
    }

    public void setGPS()
    {
        this.car.GPS = true;
    }

    public void setSeats(int number)
    {
        this.car.SeatsNumber = number;
    }

    public void setTripComputer()
    {
        this.car.TripComputer = true;
    }

    public ManualCar getResult() => this.car;
}