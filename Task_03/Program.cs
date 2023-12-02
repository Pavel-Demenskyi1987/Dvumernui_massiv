
int rows = 3;
int cols = 4;

Random rand = new Random();
int[,] Array = new int[rows, cols];

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {        
        Array[i, j] = rand.Next(1, 10); 
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
int minSumRowIndex = FindMinSum(Array);

Console.WriteLine($"Строка с наименьшей суммой элементов: {minSumRowIndex }");

int FindMinSum(int[,] Array) 
    {
        int minSum = int.MaxValue;
        int minSumRowIndex = -1;
        for (int i = 0; i < rows; i++)
        {
            int sum =0;
            for (int j = 0; j < cols; j++)
            {
                sum = sum + Array[i,j];  
            }

            if (sum < minSum)
            {
                minSum = sum;
                minSumRowIndex = i;
            }
        }
    return minSumRowIndex;   
} 
      
      
   
