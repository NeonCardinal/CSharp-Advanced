using System;
using System.Collections.Generic;

public class TruckTour
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<Pump> pumps = new Queue<Pump>();

        for(int i = 0; i < n; i++)
        {
            string[] pumpInfo = Console.ReadLine().Split();
            int amountOfGas = int.Parse(pumpInfo[0]);
            int distanceToNextPump = int.Parse(pumpInfo[1]);
            Pump pump = new Pump(distanceToNextPump, amountOfGas, i);
            pumps.Enqueue(pump);
        }

        Pump starterPump = null;
        bool isComplete = false;

        while(true)
        {
            Pump currentPump = pumps.Dequeue();
            pumps.Enqueue(currentPump);
            starterPump = currentPump;
            int gasInTank = currentPump.gas;

            while(gasInTank >= currentPump.distance)
            {
                gasInTank -= currentPump.distance;
                currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);

                if(currentPump == starterPump)
                {
                    isComplete = true;
                    break;
                }

                gasInTank += currentPump.gas;
            }

            if(isComplete)
            {
                Console.WriteLine(currentPump.index);
                break;
            }
        }
    }
}

public class Pump
{
    public int distance;
    public int gas;
    public int index;

    public Pump(int distance, int gas, int index)
    {
        this.distance = distance;
        this.gas = gas;
        this.index = index;
    }
}