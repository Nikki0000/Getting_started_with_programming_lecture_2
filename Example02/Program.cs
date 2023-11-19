int[] array = { 11, 21, 13, 41, 15, 61, 17, 18, 19 };

int Max(int[] array)
{
    int result = array.Max();
    //if (arg2 > result) result = arg2;
    //if (arg3 > result) result = arg3;
    return result;
}



//int max = Max(
//        Max(a1, b1, c1),
//        Max(a2, b2, c2),
//        Max(a3, b3, c3));

Console.WriteLine(Max(array));

