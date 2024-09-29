// Bài tập hằng và biến

//Bài 1
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap so nguyen duong a: ");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Nhap vao so nguyen b: ");
//        int b = Convert.ToInt32(Console.ReadLine());

//        int tong = a + b;
//        int hieu = a - b;
//        int tich = a * b;
//        int thuong = a / b;

//        Console.WriteLine($"Tong: {tong}");
//        Console.WriteLine($"Hieu: {hieu}");
//        Console.WriteLine($"Nhan: {tich}");
//        Console.WriteLine($"Thuong: {thuong}");
//    }
//}




//Bài 2
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap dai hinh chu nhat: ");
//        double chieudai = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Nhap chieu rong hinh chu nhat: ");
//        double chieurong = Convert.ToInt32(Console.ReadLine());

//        double dientich = chieudai * chieurong;
//        double chuvi = (chieudai + chieurong) * 2;

//        Console.WriteLine($"Dien tich hinh chu nhat: {dientich}");
//        Console.WriteLine($"Chu vi hình chu nhat: {chuvi}");
//    }
//}



//Bài 3
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap duong kinh hinh tron: ");
//        double duongkinh = Convert.ToInt32(Console.ReadLine());

//        double bankinh = duongkinh / 2;
//        double chuvi = 2 * Math.PI * bankinh;
//        double dientich = Math.PI * bankinh * bankinh;


//        Console.WriteLine($"Ban kinh hinh tron: {bankinh}");
//        Console.WriteLine($"Chu vi hinh tron: {chuvi}");
//        Console.WriteLine($"Dien tich hinh tron: {dientich}");
//    }
//}


//Bài 4
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Nhap ho và ten hoc sinh: ");
//        string hovaten = Console.ReadLine();

//        Console.Write("Nhap lop: ");
//        string lop = Console.ReadLine();

//        Console.Write("Nhap diem trung binh hoc ky I: ");
//        double diemTBHKI = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Nhap diem trung binh hoc ky II: ");
//        double diemTBHKII = Convert.ToInt32(Console.ReadLine());

//        double diemTBcanam = (diemTBHKI + diemTBHKII * 2) / 3;

//        Console.WriteLine($"Ho va ten: {hovaten}");
//        Console.WriteLine($"Lop: {lop}");
//        Console.WriteLine($"Diem trung binh ca nam: {diemTBcanam}");
//    }
//}




//Bài 6
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Nhap vao ngay (dd): ");
//        int day = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Nhap vao thang (mm): ");
//        int month = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("Nhap vao nam (yyyy): ");
//        int year = Convert.ToInt32(Console.ReadLine());


//        DateTime inputDate = new DateTime(year, month, day);
//        DateTime yesterday = inputDate.AddDays(-1);
//        DateTime tomorrow = inputDate.AddDays(1);

//        Console.WriteLine($"Ngay hom qua: {yesterday.ToString("dd/MM/yyyy")}");
//        Console.WriteLine($"Ngay mai: {tomorrow.ToString("dd/MM/yyyy")}");
//        Console.WriteLine($"Ngay hom nay: {day.ToString()}");

//    }
//}






