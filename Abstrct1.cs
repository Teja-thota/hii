using System;
public abstract class Vehicle{
    public abstract void Des(int a,string b);
}
class Sam:Vehicle{
      public override void Des(int a,string b){
        Console.WriteLine(string.Format("the number of wheels in {0} are {1}",b,a));
      }
      static void Main(string[] args){
        int so=int.Parse(args[0]);// passing command line arguments
        
        string s1=args[1];

        Sam s=new Sam();
        s.Des(so,s1);
      }
}