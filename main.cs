using System;


abstract class Animal
{
  // Abstract method (does not have a body)
  public abstract void animalSound();
  // Regular method
  public void sleep()
  {
    Console.WriteLine("Zzz");
  }
}

// Derived class (inherit from Animal)
class Pig : Animal
{
  public override void animalSound()
  {
    // The body of animalSound() is provided here
    Console.WriteLine("The pig says: wee wee");
  }
}
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
  
static void FirstWorker()
{
    //This will run without any rule
    Console.WriteLine("First worker started!");

    //The rule for the following block is: only enter
    //when myLock is not in use, otherwise wait
    lock (myLock)
    {
        Console.WriteLine("First worker entered the critical block!");
        Thread.Sleep(1000);
        Console.WriteLine("First worker left the critical block!");
    }

    //Finally print this
    Console.WriteLine("First worker completed!");
}
  static void SecondWorker()
{
    Console.WriteLine("Second worker started!");

    //The rule for the following block is: only enter
    //when myLock is not in use, otherwise wait
    lock (myLock)
    {
        Console.WriteLine("Second worker entered the critical block!");
        Thread.Sleep(5000);
        Console.WriteLine("Second worker left the critical block!");
    }

    //Finally print this
    Console.WriteLine("Second worker completed!");
}
  public void MyTaskAsync(string[] files)
{
  MyTaskWorkerDelegate worker = new MyTaskWorkerDelegate(MyTaskWorker);
  AsyncCallback completedCallback = new AsyncCallback(MyTaskCompletedCallback);

  lock (_sync)
  {
    if (_myTaskIsRunning)
      throw new InvalidOperationException("The control is currently busy.");

    AsyncOperation async = AsyncOperationManager.CreateOperation(null);
    worker.BeginInvoke(files, completedCallback, async);
    _myTaskIsRunning = true;
  }
}

private readonly object _sync = new object();
  
    public static int Fibonacci(int n) {
    int a = 0;
    int b = 1;
    for (int i = 0; i < n; i++) {
      int temp = a;
      a = b;
      b = temp + b;
    }
    return a;
  }
  public static void Main (string[] args) {

    long m= 92337203685587;

    string s = "fd hd fh huu u dfu ejh dsu edd jv u nferjk iiifghebh hdfhuef u bjjjeufl hfifeuioe hey dfjjj jedfg nqieéab oia ";
float f = 156454;
    Console.WriteLine(s);
    Console.WriteLine(m);
    Console.WriteLine(f);
      Car myCar = new Car();
        Pig myPig = new Pig(); // Create a Pig object
    myPig.animalSound();  // Call the abstract method
    myPig.sleep();  // Call the regular method

    // Call the honk() method (From the Vehicle class) on the myCar object
    myCar.honk();
    string ff= "gbuyirez biurv yiuarbiav baiv abi vr";

    // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
    Console.WriteLine(myCar.brand + " " + myCar.modelName);
    for (int i = 0; i < 15; i++) {
      Console.WriteLine(Fibonacci(i));
    }
  }
    }
}
