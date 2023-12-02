

namespace task_02
{
    public static class Program
    {
        public static void Main(){
        int rows = 4;
        int cols = 5;

        Random rand = new Random();

        int[,] Array = new int[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Array[i, j] = rand.Next(1, 101); 
            }
        }

        Console.WriteLine("Двумерный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(Array[i, j] + " ");
            }
            Console.WriteLine();
        
        }  
        Console.WriteLine("Массив измененный:");
     
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if(i == 0)
                {
                    Console.Write(Array[rows-1, j] + " ");
                }
                else
                {
                    if(i < rows-1)
                    {
                        Console.Write(Array[i, j] + " ");

                    }
                    else
                    {
                        Console.Write(Array[0, j] + " ");
                    }
                }        
            }
            Console.WriteLine();
        
        } 
        } 
    }       
}   
