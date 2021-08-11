
namespace Locadora_car.Services
{
    /*
     * Classe para gerar as taxas do brasil
     */
    class BrazilTaxServices : ITaxService //herdando e realizacao da interface.
    {
        public double Tax(double amount)
        {
            if(amount <= 100.0)
            {
                return amount * 0.20;
            }
            else
            {
                return amount * 0.15;
            }
        }
    }
}
