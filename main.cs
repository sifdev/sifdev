using System;



class Vehicle  // base class (parent) 
{
  public string brand = "Ford";  // Vehicle field
  public void honk()             // Vehicle method 
  {                    
    Console.WriteLine("Tuut, tuut!");
  }
}

class Car : Vehicle  // derived class (child)
{
  public string modelName = "Mustang";  // Car field
}


class Program {
  public static void Main (string[] args) {

    long a= 92337203685587;

    string s = "fd hd fh huu u dfu ejh dsu edd jv u nferjk iiifghebh hdfhuef u bjjjeufl hfifeuioe hey dfjjj jedfg nqieéab oia ";
float f = 156454;
    Console.WriteLine(s);
    Console.WriteLine(a);
    Console.WriteLine(f);
      Car myCar = new Car();

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
  }
    }
}
