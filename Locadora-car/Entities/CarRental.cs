using System;

namespace Locadora_car.Entities
{
    /*
     * Classe para representar o aluguel de carro
     */
    class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime Finish { get; set; }

        public Invoice Invoice { get; set; } //composicao de objetos
        public Vehicle Vehicle { get; set; }

        /*
         * Construtor
         */
        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }


    }
}
