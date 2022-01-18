// See https://aka.ms/new-console-template for more information
using Example3;

Toyota toyota = new Toyota();
toyota.StartHeadLight(100);

IVehicle car = new Toyota();
car.StartHeadLight(100);

IVehicle car2 = new Nissan();
car2.StartHeadLight(100);
