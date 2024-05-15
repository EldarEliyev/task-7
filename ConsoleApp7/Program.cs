// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

static void Main(string[] args) { }
for (int i = 0; i <=10; i++)
{
    #region
    //   if(i==3)continue;
    //  if(i==9)continue;   
    //  Console.WriteLine(i);
    #endregion
}


int counter = 5;
do
{
    string wantedWord = "magic";
    Console.WriteLine("Please enter a word");
    string userInput = Console.ReadLine();
    if (userInput == wantedWord)
    {
        Console.WriteLine($"Congratulations {wantedWord}  you found that ");
            
    else
        {



        }
        
                
        
        {
            Console.WriteLine("Wrong answer try again");
            counter--;

        }
       
            
} while (counter> 0) ;



