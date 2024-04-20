internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Nhap vao so luong hang cua mang:");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap vao so luong cot cua mang:");
        int y = Convert.ToInt32(Console.ReadLine());
        int[,] myarry = new int[x,y]; 
        Console.WriteLine("Nhap tung gia tri vao mang !");
        for (int row = 0; row < x;row++)
        {
            for ( int col = 0; col < y;col++)
            {
                Console.WriteLine("Nhap vao gia tri phan tu ({0},{1})",row,col);
                myarry[row,col] = Convert.ToInt32(Console.ReadLine());
            }
        }
        int max = 0;
        Console.WriteLine("Mang da tao la:");
        for (int row = 0; row < x;row++)
        {
            
            for ( int col = 0; col < y;col++)
            {
                if (myarry[row,col] > max)
                {
                    max = myarry[row,col];
                }
                Console.Write(myarry[row,col]+" ");
            }
            Console.WriteLine("\n");
        }
        Console.WriteLine("Phan tu co gia tri lon nhat la: {0}",max);
    }
}