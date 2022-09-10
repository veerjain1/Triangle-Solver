using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello! To find all information about your triangle, answer the following questions to the best of your ability. Press Enter to Begin");
    Console.ReadLine();

    Console.WriteLine("Please enter one of your angles");
    string sa1 = Console.ReadLine();
    double a1 = double.Parse(sa1);
    Console.WriteLine("Please enter your second one of your angles");
    string sa2 = Console.ReadLine();
    double a2 = double.Parse(sa2);
    Console.WriteLine("Your 3 angles are "+a1+" "+a2+" "+TriangleSum(a1,a2) );


    Console.WriteLine("Please enter your one of your side lengths. If you do not know, input 0");
    string sl1 = Console.ReadLine();
    double s1 = double.Parse(sl1);
    Console.WriteLine("Please enter your one of your side lengths. If you do not know, input 0");
    string sl2 = Console.ReadLine();
    double s2 = double.Parse(sl2);
    Console.WriteLine("Please enter your your hypotenuse. If you do not know, input 0");
    string hl = Console.ReadLine();
    double h = double.Parse(hl);
    
    Console.WriteLine("Your missing side is "+ PythagoreanTheorem(s1,s2,h));

    
    Console.WriteLine("Please enter your perimeter. If you do not know, input 0");
    string pl = Console.ReadLine();
    double p = double.Parse(pl);
    
    Console.WriteLine("Your missing component is "+ Perimeter(s1,s2,PythagoreanTheorem(s1,s2,h), p));

  



    

  }
  
static double TriangleSum(double a1, double a2)
{
  double a3 = 180 - (a1+a2);
  return a3; 
}

static double PythagoreanTheorem(double s1, double s2, double h)
{
  double t =0;
      if(s1 == 0)
      {
            t = Math.Sqrt(h*h-s2*s2);
           
 
      }
     else if(s2 == 0)
      {
            t = Math.Sqrt(h*h-s1*s1);
           
      }
     else if(h == 0)
      {
        t = Math.Sqrt(s1*s1+s2*s2);
       
      }
      return t;
     
}
static double Perimeter(double a,double b,double c, double p)
{
  double z=0 ;
      if(a == 0)
      {
            z= -b-c+p;
           
 
      }
     else if(b == 0)
      {
            z = -a+p-c;
           
      }
     else if(c == 0)
      {
            z = -a-b+p ;
           
      }
      else if(p == 0)
      {
       z = a+b+c;
           
      }
      return z;
 
     
}
 

 






}
