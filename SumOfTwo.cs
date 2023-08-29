
SumofTwo(new int[] { 1, 2, 4, 5, 64, 23, 3, 8 }, 8);
string SumofTwo(int[] array, int target)
{
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 1; j < array.Length; j++)
        {
            if (i != j)
            {
                if ((array[i] + array[j]) == target)
                {
                    Console.WriteLine($" indexs{i} and {j}");
                    return $" indexs{i} and {j}";
                }
            }
        }
        //if ((array.Length - 1) != i)
        //{
        //    if ((array[i] + array[i + 1]) == target)
        //    {
        //        return $" indexs{i} and {i + 1}";
        //    }
        //}
    }
    return string.Empty;
}
