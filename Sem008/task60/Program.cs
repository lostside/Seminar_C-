int [,,] sheets = new int[2,2,2];
int number = 10;

for (int i = 0; i < sheets.GetLength(0); i++)
{   
    for (int j= 0; j < sheets.GetLength(1); j++)
    {
        for (int k = 0; k < sheets.GetLength(2); k++)
        {
            sheets[i,k,j] = number;
            number++;
            //Console.WriteLine(i,k,j);
        }
    }
    
}