namespace 变量
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 有符号
            #region 有符号
            sbyte b = -128;
            int i = -1234;
            short s = -12345;
            long l = -1234231;
            Console.WriteLine("sbyte: " + b);
            Console.WriteLine("int: " + i);
            Console.WriteLine("short: " + s);
            Console.WriteLine("long: " + l);
            #endregion

            #region 无符号
            byte ub = 1;
            uint ui = 12;
            ushort us = 123;
            ulong ul = 1234;
            Console.WriteLine("byte: " + ub);
            Console.WriteLine("uint: " + ui);
            Console.WriteLine("ushort: " + us);
            Console.WriteLine("ulong: " + ul);
            #endregion


            #region 浮点数
            float f = 1.2345f;
            double d = -123.2321421421;
            decimal de = 0.123214214m;
            Console.WriteLine("float: " + f);
            Console.WriteLine("double: " + d);
            Console.WriteLine("decimal: " + de);
            #endregion

            #region 特殊类型
            bool bFlag = true;
            char c = 'a';
            string str = "absdfjdslk";
            Console.WriteLine("bool: " + bFlag);
            Console.WriteLine("char: " + c);
            Console.WriteLine("string: " + str);


            #endregion

            Console.WriteLine("Hello, World!");
        }
    }
}
