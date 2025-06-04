/*Đề tài 
 * Nhập 1 số >= 0 , nếu nhập sai quy tắc thì yêu cầu nhập lại khi nào đúng 
 * nếu đúng thì tính giai thừa của số này  
 */

using System.Text;

int n = -1;
// giả sử sai 
Console.OutputEncoding = Encoding.UTF8;
while (n < 0) // nhập lại cho tới khi nào <0
    {
    String input = Console.ReadLine(); ;
    if (int.TryParse(input, out n) == true)
    {//khi vào đây thì n là số nhưng có thể nhỏ hơn 0
        if (n < 0) {
            Console.WriteLine("tui đã nói với cậu là nhập lớn hơn hoặc bằng không");
            continue; }
        else { break; }
    } else {
        Console.WriteLine("Tui đã bảo là nhập số rồi mà !!");
            }
}
int gt = 1;
for (int i = 1; i <= n; i++)
    gt = gt * i;
Console.WriteLine($"{n} != {gt}");
int[] a = { 5, 2, 9, 1, 5, 6 };

// Sắp xếp tăng dần
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