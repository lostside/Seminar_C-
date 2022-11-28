// int []A = {1, 3, 4, 5, 7, 8};

// for (int i =0; i < (A.Leight /2); i++);
// {
//     temp = A[i];
//     A[i] = A.Length - 1;
//     A.Length - 1 = temp;
// }
int[] array = {2,4,9,5,7,34,12,5,1};
        int size = array.Length;
        int index = 0;
        while (index<size/2)
        {
            int temp = array[size-1-index];
            array[size-1-index] = array[index];
            array[index]=temp;
            index++;
        }
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}