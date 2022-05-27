namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Student Name version 0.1
    /// </author>
    public class BMI
    {
     public const string IMPERIAL = "imperail"
     public const string METRIC = "metric"
     
     public const string FEET = "feet"
     public const string INCHES = "inches"
     
     public const int Inches_iN_FEET = 12;
     oublic conmst int POUNDS_IN_STONE =14;

     private double height;
     private double weight;

     private string unitChoice;

     public void Run()
        {
            ConsolettHelper.outputHeading "MI Calculator"
                covertMI();
        }

     public void CovertBMI()
     Console.ForegroundColour = ConsoleColour.white;
     console.WriteLine("\n selecting units)

     string[] choices = new string[]
     {
         IMPERIAL, METRIC
     }
     Console.WriteLines(s"\n please select a unit to convert from\n);
     int choice = ConsolHelper.SelectChoice(choices)
     unitChoices = Choices[choice - 1]

     
           
     String input = Console.ReadLines();

     private void ConvertImperial()
     
            consoleHelper.OutputYellow(s"\n please enter your height" + 
                                        " to the nearest foot & inches);
      height =ConsoleHelper.InputNumbers (s"\ n Enter your height in feet>);
      int inches =(int) ConsoleHelper.inputnumbers (s" Enter your height in inches >", 0, 12);

     weight = ConsoleHelper.inputnumbers (s" Enter your weight in stones >);" 
     int pounds = (int)ConsoleHelper.InputNumbers(s "enter your weight in pounds>",0, 14);
                                      
    }
}
