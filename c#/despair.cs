using System;

class HelloWorld {
    
  static void Main() {
    
    int a = 71;
    bool isPrime = true;
    
    for (int i = 2;i<Math.Sqrt(a);i++){
        if(a%i==0)
            isPrime = false;
    }
    
    if(isPrime==true)
        Console.WriteLine("number is prime");
    else Console.WriteLine("number is composite");

    // first time i experienced true despair while trying to understand how this shit works 
    //even Stella understood faster than me
  //what the fuck dude 
    
  }
  
}
