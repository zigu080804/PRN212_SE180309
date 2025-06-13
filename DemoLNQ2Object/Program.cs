
using DemoLNQ2SQL;
using System.Runtime.Intrinsics.Arm;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
string connectionString = @"server=NGANHUSBAND;database=MyStore;uid=sa;pwd=12345";

MyStoreDataContext context = new MyStoreDataContext(connectionString);

//Câu 1:  Truy vấn toàn bộ danh mục

var dsdm = context.Categories.ToList();
Console.WriteLine("Danh sách danh mục:");
dsdm.ForEach(x => Console.WriteLine(x.CategoryID+"\t"+x.CategoryName));

//Câu 2:  Dùng Query Syntax để lọc ra toàn bộ sản phẩm 
var dsp = from p in context.Products
          select p;
Console.WriteLine("--Danh sách sản phẩm--");
foreach (var p in dsp)
{
    Console.WriteLine(p.ProductID+"\t"+p.ProductName+"\t"+p.UnitPrice);
}
//Câu 3: Tìm danh mục khi biết mã danh mục 
int dmd = 3;
Category cate = context.Categories.FirstOrDefault(x => x.CategoryID == dmd);
if (cate == null)
{
    Console.WriteLine("Không nhìn thấy danh mục có mã" + dmd);
}
else
{
    Console.WriteLine("Đã tìm thấy danh mục có mã =" + dmd);
    Console.WriteLine(cate.CategoryID+"\t"+cate.CategoryName);
}
//Câu 4: Lọc ra Top 3 sản phẩm có giá lớn nhất 

var dssptop3 = context.Products
                      .OrderByDescending(p => p.UnitPrice)
                      .Take(3);
Console.WriteLine("Danh sách 3 sản phẩm đắt nhất");
foreach(var p in dssptop3)
{
    Console.WriteLine(p.ProductID + "\t" + p.ProductName + "\t" + p.UnitPrice);
}
//Câu 5: Thêm mới một danh mục 
//Category c1 = new Category();
//c1.CategoryName = "Hàng Nội Địa Trung thì như cái lông đèn";
//context.Categories.InsertOnSubmit(c1);
//context.SubmitChanges();

//câu 6: Sửa tên danh mục 
//Bước 1: tìm danh mục
//Bước 2: tìm thấy thì sửa

//Category c9 = context.Categories.FirstOrDefault(c => c.CategoryID == 9);
//if (c9 != null)
//{
//    c9.CategoryName = "Hàng gia dụng";
//    context.SubmitChanges();
//}    
////Câu 7 xóa danh mục khi biết mã danh mục
//Category c12 = context.Categories.FirstOrDefault(c => c.CategoryID == 12);
//if (c12 != null)
//{
//    context.Categories.DeleteOnSubmit(c12);
//    context.SubmitChanges();
//}    
//Câu 8: Xóa tất cả danh mục chưa có bất kì sản phẩm nào:
var dssp_empty_product=context.Categories.Where(c=>c.Products.Count()==0)
                                         .ToList();
context.Categories.DeleteAllOnSubmit(dssp_empty_product);
context.SubmitChanges();

//Câu 9: Thêm nhiều danh mục cùng 1 lúc
List<Category> dsdm_new  = new List<Category>();
dsdm_new.Add(new Category() { CategoryName = "Hàng điện tử" });
dsdm_new.Add(new Category() { CategoryName = "Hàng hóa chất" });
dsdm_new.Add(new Category() { CategoryName = "Hàng gia dụng " });