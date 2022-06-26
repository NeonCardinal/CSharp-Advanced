using System;
using System.Collections.Generic;

public class ParkingLot
{
    static void Main()
    {
        HashSet<string> parking = new HashSet<string>();

        string command = Console.ReadLine();

        while(command != "END")
        {
            string[] tokens = command.Split(", ");
            string cmd = tokens[0];
            string carNumber = tokens[1];

            if(cmd == "IN")
            {
                parking.Add(carNumber);
            }
            else if(cmd == "OUT")
            {
                parking.Remove(carNumber);
            }

            command = Console.ReadLine();
        }

        if(parking.Count != 0)
        {
            foreach (var item in parking)
            {
                Console.WriteLine(item);
            }
        }
        else
        {
            Console.WriteLine("Parking Lot is Empty");
        }
    }
}
