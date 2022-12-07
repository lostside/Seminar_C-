int[] a = {1,2,3,4,5};
int[] b = {1,2,3,4,5};

bool res = true; // res = true - массивы равны, если res = false, то массивы не равны
if (a.Length == b.Length)
{
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i])
        {
            res = false;
        }
    }
    Console.WriteLine(res);
}