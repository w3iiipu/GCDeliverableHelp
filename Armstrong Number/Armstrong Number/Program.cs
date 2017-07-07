using System;

namespace Armstrong_Number
{
    class Program
    {
        //main program
        static void Main(string[] args)
        {
            //declare variable for user input 
            int input;

            //write to console to prompt user for input
            Console.WriteLine("Please enter an integer: ");
            //read user input and assign to variable
            input = Convert.ToInt32(Console.ReadLine());

            //call the method to run it using user input as parameter
            ArmstrongNumber(input);

            //method to evaluate number
            void ArmstrongNumber(int userinput)
            {
                //declare variables 
                int temp = userinput;
                int remainder;
                int sum = 0;

                //while loop to loop thru the numbers and break it down to individual digit. 
                while (userinput > 0)
                {
                    //this breaks down the digit to the last digit. 
                    //For example 153. 153% will become 3. So now remainder is 3. 
                    //second loop this will become 15%10 which is 5.
                    remainder = userinput % 10;

                    //this will remove the last digit from the number so on the next loop the next digit is evaluated.
                    //For example 153. Now 153/10 will become 15. So on the next loop 15 will be evaluated for the last digit. 
                    userinput = userinput / 10;

                    //this is used to add up all the cubes of individual digits on each passing loop.
                    //For example on the first loop sum=0 as declared.We have remainder from previous function which is 3. So sum=0+(3*3*3)
                    //On the second loop over the remainder is now 5. But since sum was alrdy calculated from the first loop iteration, it will still get added on.
                    //Which makes it become Sum=27+(5*5*5)
                    sum = sum + (remainder * remainder * remainder);


                }

                //this if else statement will compare sum to the temp number which is the same as user input
                //if true print statement.
                if (temp == sum)
                {
                    Console.WriteLine(temp + " adds up!");
                }
                //if false print statement.
                else
                {
                    Console.WriteLine(temp + " does not add up =(");
                }

            }
        }
    }
}
