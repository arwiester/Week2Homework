using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //****Ex.1 - Farenheit to Celsius****
            //Exercise explaination 
            Console.WriteLine($"In this exercise the application will ask for degrees in Farenheit and will convert it to Celsius.\n");
            
            //Asks user to enter the degress in F to convert to degrees in C
            Console.WriteLine($"Please enter the degrees in Farenheit to convert to Celsius");
            //Takes the F input and converts it to a double variable
            double degreesInF = Convert.ToDouble(Console.ReadLine());

            //F -> C conversion formula = C = (F-32)*5/9
            double degreesInC = (degreesInF - 32) * 5 / 9;

            //Displays the conversion to the user.
            Console.WriteLine($"{degreesInF} F = {degreesInC} C");

            //Press enter to continue
            Console.WriteLine("Press the enter key to continue to exercise 2");
            Console.ReadLine();

           
            //****Ex.2 - Sales Tax****
            //Exercise explaination 
            Console.WriteLine($"In this exercise the application will calculate sales tax for a item you might want to purchase.\n");

            //Ask user to enter the price of their product before sales tax is applies
            Console.WriteLine($"Enter the price of the item you want to purchase: ");

            //Take the price input and and converts it to a double variable
            double itemPrice = Convert.ToDouble(Console.ReadLine());

            //Ask the user to enter the sales tax
            Console.WriteLine($"Enter the sales tax percentage");

            //Take the sales tax input and and converts it to a double variable
            double salesTax = Convert.ToDouble(Console.ReadLine());

            //Converts the sales tax input into a decimal form
            double convertedSalesTax = salesTax * .01;

            //Takes the converted sales tax amount and adds it to the purchase price
            double totalPrice = Math.Round(convertedSalesTax * itemPrice + itemPrice, 2);

            //provides the final price to the user by
            Console.WriteLine($"The price of the item you want to purchase is ${itemPrice}");
            Console.WriteLine($"The sales tax you entered is {convertedSalesTax}% or ${Math.Round(convertedSalesTax * itemPrice, 2)} ");
            Console.WriteLine($"The total price you would pay is ${totalPrice} \n");

            //Press enter to continue
            Console.WriteLine("Press the enter key to continue to exercise #3");
            Console.ReadLine();

           
            //****Ex.3 - Sales Tax****
            //Exercise Explaination
            Console.WriteLine($"In this exercise the applicaiton will help you calculate the tip for a meal at a restaurant.\n");

            //Ask user for the amount of the total bill
            Console.WriteLine($"Enter the total amount of the bill");
            double billAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"What percentage (%) would you like to tip?");
            double tipPercentage = Convert.ToDouble(Console.ReadLine());

            ////Converts the tip percentage to a decimal
            double totalTipAmount = tipPercentage / 100 * billAmount;
            //Calculates the total amount due
            double totalBillDue = billAmount + totalTipAmount;

            Console.WriteLine($"Total Bill: ${billAmount} \nTip: ${totalTipAmount:0.00}\n---------------------------------------- \nTotal Amount (including tip): ${totalBillDue:0.00}\n");
            Console.WriteLine("Press the enter key to continue to exercise #4");
            Console.ReadLine();

            
            //****Ex.4 - Bill Dividends****
            //Exercise explaination 
            Console.WriteLine($"In this exercise pretend you just got done eating with a group of people at your favorite restaruant. " +
                                $"This application will divide the total amount of the bill by the total amount of people in your group.\n");
            
            //Prompt the user to give you the total bill
            Console.WriteLine($"Please enter the total amount of the bill \n");
            double dividendsTotalBill = Convert.ToDouble(Console.ReadLine());
            
            //Prompt the user to give you how many people are contributing
            Console.WriteLine($"Plese enter how many people are in your group to divide the bill up.");
            double dividendsGroupCount = Convert.ToDouble(Console.ReadLine());
            
            //Calculates the amount owed per person
            double dividendsTotalAmountPerPerson= dividendsTotalBill / dividendsGroupCount;

            //Display to the user the amount each contribution would need to pay
            Console.WriteLine($"The total bill is: ${dividendsTotalBill}\n The total head count in your group is: {dividendsGroupCount} \n------------------------------ \n Each person will pay: ${dividendsTotalAmountPerPerson:0.00}\n");

            Console.WriteLine("Thank you for participating in this week's execises. \nPress the enter key to view the 'Formatting Chalenge'.");
            Console.ReadLine();
                        
            //Chalenge
            double chalengeFormat = 1000;
            Console.WriteLine(chalengeFormat.ToString("C"),"{0:0,0.00}", chalengeFormat);

            Console.ReadLine();
        }
    }
}
