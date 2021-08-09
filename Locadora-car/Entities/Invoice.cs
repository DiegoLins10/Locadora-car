using System.Globalization;

namespace Locadora_car.Entities
{
    /*
     * Classe invoice para representar uma fatura com taxas
     * para retornar ao user
     */
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        /*
         * Construtores
         */
        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        /*
         * Properties calculada
         * implementacao de um atributo personalizado
         */
        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        /*
         * toString da minha fatura
         */
        public override string ToString()
        {
            return "Basic payment: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: " + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal Payment: " + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
