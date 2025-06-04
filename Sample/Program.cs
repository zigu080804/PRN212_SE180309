(int , double) SumAverage(params int[]a)
{
    int sum = 0;
    for(int i = 0; i < a.Length; i++) 
        sum += a[i];
    double avg=sum/a.Length;
    return (sum,avg);
}
int[] arr = { 1, 4, 56, 66, 3, 5, 6, 78, 3 };
(int s,double v) = SumAverage(arr);
Console.WriteLine($"SUM={s}");
Console.WriteLine($"AVERAGE={v}");