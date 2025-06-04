// Sắp xếp tăng dần
using System.Text;

int[] a = { 5, 2, 9, 1, 5, 6 };

for (int i = 0; i < a.Length - 1; i++)
{
    for (int j = 0; j < a.Length - i - 1; j++)
    {
        if (a[j] > a[j + 1])
        {
            // Đổi chỗ 2 phần tử
            int temp = a[j];
            a[j] = a[j + 1];
            a[j + 1] = temp;
        }
    }
}

void swap(ref int a, ref int b)
{
    int temp = a;
    a = b;
    b = temp;
}
void sort_arr(int[] arr)
{
    for(int i = 0;i < arr.Length; i++)
    {
        for (int j = i+1;j < arr.Length; j++)
        {
            if (arr[j] < arr[i])
            {
                swap(ref arr[i], ref arr[j]);
            }

        }
    } 
        
}
void create_array(int[]arr)
{
    Random rd = new Random();  
    for(int i = 0; i < arr.Length; i++) 
        {
        arr[i] = rd.Next(100);
        }
}
void print_array (int[]arr)
{
    foreach(int x in arr)
    {
        Console.WriteLine($"{x}\t");
    }
}
int[]arr = new int[10];
create_array(arr);
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Mảng truocs khi sắp xếp");
print_array(arr);
Console.WriteLine("Mảng sau khi sắp xếp");
sort_arr(arr);
print_array(arr);

void sapxep2while (int[]arr)
{
    int n = arr.Length;
    int i = 0;
    while (i < n - 1)
    {
        int j = 0;
        while (j < n - i - 1)
        {
            if (arr[j] > arr[j + 1])
            {
                // Đổi chỗ
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
            j++;
        }
        i++;
    }
}
create_array(arr);
Console.WriteLine("Mang 2while");
sapxep2while(arr);
print_array(arr);

void sapxepdowhile (int[]arr)
{
    int n = arr.Length;
    int i = 0;
    do
    {
        int j = 0;
        while (j < n - i - 1)
        {
            if (arr[j] > arr[j + 1])
            {
                // Đổi chỗ
                int temp = arr[j];
                arr[j] = arr[j + 1];
                arr[j + 1] = temp;
            }
            j++;
        }
        i++;
        } while (i < n - 1) ;
}
create_array(arr);
Console.WriteLine("Mang dowhile");
sapxepdowhile(arr);
print_array(arr);




