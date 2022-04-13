public class Progream
{
    public static bool Loop = true;
    public static void Main()
    {
         
        while(true)
        {
            Console.WriteLine($"Hello Please input your name below:");
                
                string name = Console.ReadLine();
            
            Console.WriteLine("Please input an integer between 0 and 100");
            
                int num = int.Parse(Console.ReadLine());
            if (num > 0 && num <= 100)
            {
                Console.WriteLine("Great Job! Your Number is in the parameters");
            }

            bool even;
            if (num % 2 == 0)
            {
                even = true;
            }
            else
            {
                even = false;
            }
            if(even == true)
            {
                if (num >= 2 && num < 25)
                {
                    Console.WriteLine($"{name} your number is Even and less than 25");
                }
                else if (num < 60)
                {
                    Console.WriteLine($"{name} your number is Even and between 26 and 60 inclusive");
                }
                else
                {
                    Console.WriteLine($"{name} Your number {num} is even and greater than 60");
                }
            }
            if(even == false)
            {
                if(num <=60)
                {
                    Console.WriteLine($"{name} your number {num} is Odd and less than 60");
                }
                else if(num >=60){
                    Console.WriteLine($"{name} your number {num} is odd and greater than 60");
                }
            }
       
           
               
        
            

            
            Console.WriteLine($"Would you like to continue yes or no? ");
            
            string cont = Console.ReadLine().ToLower();
            
            
            if(cont == "yes")
            {
                continue;
            }
            else
            {
               return;
            }
 
            
        }

    }
}
