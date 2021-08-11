using Locadora_car.Entities;
using System;

namespace Locadora_car.Services
{
    /*
     * Classe service
     * gerando para cuidar da regra de negocio
     */
    class RentalServices
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }


        //instanciando a interface ITaxService
        private ITaxService _taxService;

        /*
         * Construtores
         */
        public RentalServices(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
        
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
            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax); 
        }
    }
}
