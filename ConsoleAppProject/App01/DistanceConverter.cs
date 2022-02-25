using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Bilal Khan version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double Miles;
        private double feet;
        /// <summary>
        /// 
        /// </summary>
        private void  Run()
        {
            InputMiles();
            CalculateFeet();
            Outputfeet();
        }
        /// <summary>
        /// promt the user to enter the distance in miles 
        /// input the miles as a double number
        /// </summary>
        private void InputMiles()
        {
            Console.Write("please enter the number of miles");
            string value = Console.ReadLine();
            Miles = Convert.ToDouble(value);
        }
        private void CalculateFeet()
        {

        }
        private void  Outputfeet()
        { 
        
        }

    }

}
