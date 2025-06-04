int sum(params int[]a)
{
    int s = 0;
    foreach(int x in a)
        s = s + x;
    return s;
}

Console.WriteLine(sum());

Console.WriteLine(sum(1, 4, 9));

        Console.WriteLine(sum(1,4,9,10,11));