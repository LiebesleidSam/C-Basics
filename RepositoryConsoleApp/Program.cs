using Classes;

DeliveryRepository deliveryRepo = new DeliveryRepository();
ProgramUI programInterface = new ProgramUI(deliveryRepo);

while(programInterface.Running)
{
    Console.Clear();
    programInterface.Run();
}