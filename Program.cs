using System;
//Comment Latest Name and Date
namespace assignment_four
{
    
    class Program
    {
        
            public int computeRate(int numDays)
            {
                 //prompting user to enter the number of days for cares
                Console.WriteLine("please enter the number of days to stay");
                numDays= Convert.ToInt32(Console.ReadLine());

                int total;
                int rate= 75;

                total= numDays * rate;
                
                return total;

            }//End of computeRate with one parameter



           
        public void computeRate(int numDays, string code)
            {
                //prompting user to enter the number of days for cares and  code choice
                Console.WriteLine("please enter the number of days to stay");
                numDays= Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("please enter your code choice");
                code= Console.ReadLine();

                switch(code)
                {
                    case "A":
                    {
                        Console.WriteLine($"You selected" + "A" +"Your price is ");
                        break;


                    }
                    default:
                    {break;}
                }
                

            }// end of computeRate with two parameters

       public  static void Main(string[] args)
       {
           
            //Global Declarations
            int numDays;
            

            string code;
            Console.WriteLine("Enter the number of days");
            int numDays=Convert.ToInt32(Console.ReadLine());

            int code=Convert.ToInt32(Console.ReadLine());
            
            comp.computeRate(numDays);
            comp.computeRate(numDays,code);

            Console.ReadKey();



             


        }//End of main
            

        //Overloaded method with one argument
       




        //Overloaded method with two arguments
       


    }//End of Class
}
