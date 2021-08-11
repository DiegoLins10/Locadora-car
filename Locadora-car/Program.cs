﻿using Locadora_car.Entities;
using Locadora_car.Services;
using System;
using System.Globalization;

namespace Locadora_car
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            Console.Write("Return (dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Enter price per hour: ");
            double priceHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter price per day: ");
            double priceDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalServices rentalServices = new RentalServices(priceHour, priceDay, new BrazilTaxServices());

            rentalServices.ProcessInvoice(carRental); //pegando o metodo com a regra de negocio do service

            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
