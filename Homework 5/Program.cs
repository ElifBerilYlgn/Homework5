

    static double Average(double[] t)
    {
        double total = 0;

        foreach (double temperature in t)
        {
            total += temperature;
        }

        return total / t.Length;
    }

   
    
        double[] week = [14.2, 17.5, 19.0, 16.8, 21.3, 22.7, 18.4];

        
        double average = Average(week);
        Console.WriteLine($"Average: {average:F1} °C");

        
        int maxIndex = 0;

        for (int i = 1; i < week.Length; i++)
        {
            if (week[i] > week[maxIndex])
            {
                maxIndex = i;
            }
        }

        Console.WriteLine(
            $"Hottest day: {maxIndex + 1} ({week[maxIndex]:F1} °C)");

        
        Console.WriteLine("Days above average:");

        for (int i = 0; i < week.Length; i++)
        {
            if (week[i] > average)
            {
                Console.WriteLine($"Day {i + 1}: {week[i]:F1} °C");
            }
        }

        
        double[] lastThree = week[^3..];

        Console.WriteLine("Last three days:");
        Console.WriteLine(string.Join(" ", lastThree));
    
