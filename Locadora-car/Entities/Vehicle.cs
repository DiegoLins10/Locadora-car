
namespace Locadora_car.Entities
{
    /*
     * Classe para representar um objeto veiculo
     */
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
