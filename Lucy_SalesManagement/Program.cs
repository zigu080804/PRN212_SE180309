using System.Text;
using Lucy_SalesManagement;

Console.OutputEncoding = Encoding.UTF8;

string connectionString = "server=NGANHUSBAND;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context =
    new Lucy_SalesDataDataContext(connectionString);

int mkh = 1;
Customer cus =  context.Customers.FirstOrDefault(c=>c.CustomerID==mkh);
if(cus!=null)
{
    Console.WriteLine(cus.CustomerID + "\t" + cus.ContactName);

}   
//Câu 2: Lọc ra danh sách các hóa đơn của khách hàng tìm thấy 
if(cus!=null)
{
    Console.WriteLine("Danh sách hóa đơn của khách hàng");
    foreach(Order od in cus.Orders)
    {
        Console.WriteLine(od.OrderID + "\t" + od.OrderDate.ToString("dd/mm/yy"));
    }    
} 
//Câu 3: Nâng cấp câu 2 
//Bổ sung thêm 1 cột của hiện thị trị giá của hóa đơn 