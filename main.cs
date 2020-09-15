using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter temperature in Celsius");
    double temp1 = Convert.ToDouble(Console.ReadLine());
    double temp2 = (temp1 * 9/5) + 32;
    Console.WriteLine(temp2 + " Fairenheit");
     if (temp2 < 32) {
    Console.WriteLine("It is freezing");   

     }
     if (temp2 > 212) {
     Console.WriteLine("It is boiling");  
     }
    







  }
}