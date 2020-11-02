namespace Interfaces
{
    interface IVehicle
    {
        string Manufactuer { get; set; }
        int NoOfPassengers { get; set; }
        int VehicleState { get; set; }
        int Wheels { get; set; }
        UsageType Usage { get; set; }

        void Accelerate();
        void Brake();
    }
}