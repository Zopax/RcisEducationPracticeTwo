using System;
using System.Runtime.InteropServices;
using System.Xml;

namespace GarageConsoleApp
{
    /// <summary>
    /// Класс Program 
    /// здесь описываем логику приложения
    /// вызываем нужные методы пишем обработчики и тд
    /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            DatabaseRequests.GetTypeCarQuery();
            Console.WriteLine();

            Console.Write("Введите тип транспорта: ");
            var carQuery = Console.ReadLine();
            Console.WriteLine("Типы машин: ");
            DatabaseRequests.AddTypeCarQuery(carQuery);

            DatabaseRequests.GetTypeCarQuery();
            Console.WriteLine();

            Console.WriteLine("Водители: ");
            DatabaseRequests.GetDriverQuery();
            Console.WriteLine();
            Console.Write("Введите Имя водителя: ");
            var firstName = Console.ReadLine();

            Console.Write("Введите Фамилию водителя: ");
            var lastName = Console.ReadLine();

            Console.Write("Введите дату рождения водителя водителя (d.m.yyyy): ");
            var birth = Convert.ToDateTime(Console.ReadLine());
            DatabaseRequests.AddDriverQuery(firstName, lastName, birth);
            DatabaseRequests.GetDriverQuery();

            Console.Write("Введите название категории: ");
            string rigts = Console.ReadLine();
            DatabaseRequests.AddRightsCategoryQuery(rigts);

            Console.Write("Введите номер водителя которому вы хотите занести права: ");
            int driverNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите номер категории прав: ");
            DatabaseRequests.GetRightsCategoryQuery();
            Console.Write("Введите: ");
            int rightsNum = Convert.ToInt32(Console.ReadLine());
            DatabaseRequests.AddDriverRightsCategoryQuery(driverNum, rightsNum);
            DatabaseRequests.GetDriverRightsCategoryQuery(driverNum);
            Console.WriteLine();

            Console.WriteLine("Автомобили: ");
            DatabaseRequests.GetCar();

            Console.Write("Введите название автомобиля: ");
            string nameCar = Console.ReadLine();

            Console.Write("Введите номер автомобиля: ");
            string numbCar = Console.ReadLine();

            Console.Write("Введите кол-во мест в автомобиле: ");
            int numbPessenger = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите номер типа автомобиля: ");
            int idTypeCar = Convert.ToInt32(Console.ReadLine());

            DatabaseRequests.addCar(nameCar, numbCar, numbPessenger, idTypeCar);
            Console.WriteLine("Автомобили: ");
            DatabaseRequests.GetCar();

            DatabaseRequests.GetItinerary();
            Console.WriteLine();
            Console.Write("Введите название Маршрута: ");
            string nameItinerary = Console.ReadLine();
            DatabaseRequests.AddItinerary(nameItinerary);
            DatabaseRequests.GetItinerary();


            DatabaseRequests.GetRoute(1);
            Console.Write("Введите id водителя: ");
            int idDriver = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите id машины: ");
            int idCar = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите id маршрута: ");
            int idItinerary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите кол-во пассажиров: ");
            int passengerCount = Convert.ToInt32(Console.ReadLine());
            
            DatabaseRequests.AddRoute(idDriver, idCar, idItinerary, passengerCount);
            
        }
    }
}

