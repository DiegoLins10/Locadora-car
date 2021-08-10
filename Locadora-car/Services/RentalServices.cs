using Locadora_car.Entities;
using System;

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

        private BrazilTaxServices _brazilTaxServices = new BrazilTaxServices();

        /*
         * processa um objeto car rental
         * e gera a nota do alugel
         * fazendo a soma do valor a ser pago
         */
        public void ProcessInvoice(CarRental carRental)
        {
            // fazendo a subtracao da hora de saida e entrada
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            if(duration.TotalHours <= 12.0)
            {
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); //ceiling arredonda pra cima
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }
            double tax = _brazilTaxServices.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 
        }
    }
}
