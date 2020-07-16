using System;

namespace LogHelper.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            LogHelper.Logger.Debug("测试");
            LogHelper.Logger.Error("测试");
        }
    }
}
