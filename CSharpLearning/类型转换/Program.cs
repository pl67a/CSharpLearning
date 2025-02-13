namespace 类型转换
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 把23490转成字符
            Console.WriteLine(23490.ToString());
            Console.WriteLine(Convert.ToString(23490));
            Console.WriteLine("Hello, World!");

            try
            {
                string str = Console.ReadLine();
                int i = int.Parse(str);

            }
            catch 
            {
                Console.WriteLine("需要输入数字");
            }
        }
    }
}
