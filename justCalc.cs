/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

*******************************************************************************/
using System;
class Calculate {
  static void Main() {
     double num1;
    double num2;
    double total;
    char oper;
    
    Console.WriteLine("num1");
    num1=Convert.ToDouble(Console.ReadLine());
    
    Console.WriteLine("operator");
    oper=Convert.ToChar(Console.ReadLine());
    
    Console.WriteLine("num2");
    num2=Convert.ToDouble(Console.ReadLine());
    
    if(oper=='+'){
        total=num1+num2;
        Console.WriteLine(total);
    }
    else if (oper=='-'){
        total=num1-num2;
        Console.WriteLine(total);
    }
    else if (oper=='*'){
        total =num1*num2;
        Console.WriteLine(total);
    }
    else if(oper =='/'){
        total=num1/num2;
        Console.WriteLine(total);
        
    }
    else{
        Console.WriteLine("Failed");
    }
    
    
}
  }

