using System;

class Program {
 static void Main (string[] args)
{  
   Console.WriteLine(" Table de Multiplication");
for (int i = 0; i <= 10; i++)

{
    Console.Write(i + "\t");
    for (int j = 1; j <= 10; j++)
    {
        if (i>0) Console.Write(i * j + "\t");
        else Console.Write(j + "\t");
    }
    Console.Write("\n");
}
   Console.WriteLine("LES RESULTAT  IMPAIRS:\t");
   
   for ( int i = 0; i <= 10; i++)
{
    if(i%2!=0) Console.Write(i + "\t");
    for (int j = 0; j <= 10; j++)
    {
    if ((i*j)%2!=0)Console.Write(i * j+"\t");
        
    }
    Console.Write("\n");
}
AskUserForParameter();
   
   
   
                     

  
}
  private static int AskUserForParameter(){
    Console.WriteLine("Please  write a number and press enter: ");
    int i;
    int.TryParse(Console.ReadLine(), out var result);
  for ( i = 1; i <= 10; i++){           
  Console.Write("{0} X {1} = {2} \n", result, i, result * i);            
        }

return result;
    
  }
 
}