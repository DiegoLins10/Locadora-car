using Locadora_car.Entities;


namespace Locadora_car.Services
{
    class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        /*
         * Construtores
         */
        public RentalServices(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }

        /*
         * processa um objeto car rental
         * e gera a nota do alugel
         */
        public void ProcessInvoice(CarRental carRental)
        {

        }
    }
}
