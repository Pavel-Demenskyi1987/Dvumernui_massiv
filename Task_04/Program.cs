

int rows = 3;
int cols = 4;


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
int index1 = 0;
int index2 = 0;   
int min = Array[0,0];
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if(Array[i,j] < min)
        {
            min = Array[i,j];
        }
        if(Array[i,j] == min)
        {
            index1 = i;
            index2 = j;
        }
    }
}

System.Console.WriteLine();

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        if(i == index1 || j == index2)
        {
             continue;
        }
        else
        {
            Console.Write(Array[i, j] + " ");
        }
                
    }
    Console.WriteLine();
        
} 
        
        

