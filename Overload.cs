using System;
using System.Collections;

namespace ConsoleApp2
{
  public  class Program93
    {
      public  int Add(int i, int j, int q=10)
        {
            return 0; 
        }
        public virtual void Display()
        {
            Console.WriteLine("Virtual");
        }
        public int Add(int i, int j,int o,int k)
        {
            return 0;
        }
    public string Add(string i,string k,string e)
        {
             string s = "string>(c);";
            return s;   
        }
        //static void Main9(string[] args)
        //{

        //    A a = new A();
        //    B b = new B();
        //    C c = new C();

        //    a.Test(); // output --> "A::Test()"
        //    b.Test(); // output --> "B::Test()"
        //    c.Test(); // output --> "C::Test()"

        //    a = new B();
        //    a.Test(); // output --> "A::Test()"

        //    b = new C();
        //    b.Test(); // output --> "B::Test()"

        //    Console.ReadKey();
        //}
        public virtual void Display1()
        {
            Console.WriteLine("Overrride");
        }
      
    }
    public class BC:Program93
    {
        public override void Display1()
        {
            Console.WriteLine("Overrride");
        }
    }
    public class BCD 
    {
        Program93 obj = new Program93();
     
        
    }
}
