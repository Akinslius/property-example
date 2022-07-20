using System;
using System.Collections.Generic;
using System.Text;

namespace property_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double UserAge;
            human Akin = new human();

            Console.WriteLine("Enter your Age");
            UserAge = Convert.ToDouble(Console.ReadLine());
            // The property assignment causes the 'set' accessor to be called.
            Akin.Age = UserAge;

            // Retrieving the property causes the 'get' accessor to be called.

            Console.WriteLine($"\tYou are born in {Akin.Age}");


            // TimePeriod t = new TimePeriod();
            // The property assignment causes the 'set' accessor to be called.
            // t.Hours = 24;

            // Retrieving the property causes the 'get' accessor to be called.
            // Console.WriteLine($"Time in hours: {t.Hours}");
        }
    }
}



class human
{
    //field
    public double Dob;

    //property
    public double Age
    {
        get { return Dob; }

        set
        {


            if (value >= 60)
            {
                Console.WriteLine("You are an old\n");
            }
            else if (value < 59 & value >= 25)
            {
                Console.WriteLine("Your are an Adult\n");
            }
            else
            {
                Console.WriteLine("You are still a Child\n");
            }
            Dob = 2022 - value;
        }

    }
}


class TimePeriod
{
    //field
    private double _seconds;

    //property
    public double Hours
    {
        get { return _seconds / 3600; }
        set
        {
            if (value < 0 || value > 24)
                throw new ArgumentOutOfRangeException(
                      $"{nameof(value)} must be between 0 and 24.");

            _seconds = value * 3600;
        }
    }
}



