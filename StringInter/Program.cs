using System.Text;

Console.OutputEncoding = Encoding.UTF8;
String ho = "Nguyễn";
String ten = "Nguyễn";
String tenlot = "Văn";


String fullname = ho + ten;

Console.WriteLine(fullname);

StringBuilder stringBuilder = new StringBuilder();

stringBuilder.Append(ho);
stringBuilder.Append(" ");
stringBuilder.Append(tenlot); 
stringBuilder.Append(" ");
stringBuilder.Append(ho);