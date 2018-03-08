using System;

namespace CoreConsole1
{
    /**
     * C# 7.0 语法测试.
     **/
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World中国XXYY!");

            // 创建Tuple的两种方式
            var tuple1 = Tuple.Create(1, "小明");
            var tuple2 = new Tuple<int, string>(2, "小明2");
            // 创建ValueTuple
            var valueTuple = (3, "小明3");
            var namedValueTuple = (Id:4, Name: "小明4");
            // 元组析构
            var (id, name) = valueTuple; // namedValueTuple;

            Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(valueTuple);
            Console.WriteLine($"tuple1: {tuple1.Item1}, {tuple1.Item2}");
            Console.WriteLine($"tuple2: {tuple2.Item1}, {tuple2.Item2}");
            Console.WriteLine($"valueTuple: {valueTuple.Item1}, {tuple1.Item2}");
            Console.WriteLine($"namedValueTuple: {namedValueTuple.Id}, {namedValueTuple.Name}");
            Console.WriteLine($"元组析构: {id},{name}");

            // 析构自定义类
            var p = new Point() { X = 1.1, Y = 2.2 };
            Console.WriteLine(p);
            var (x1, y1) = p;   // 析构此对象
            Console.WriteLine($"({x1},{y1})");

            //接收方法返回的元组
            var (sid, sname) = NewStudent();
            Console.WriteLine($"(sid,sname): {sid},{sname}");
            var stu = NewStudent();
            Console.WriteLine($"stu: {stu.Item1},{stu.Item2}");

            // 测试返回引用的修改
            ref var r1  = ref GetArrItem(3);
            Console.WriteLine($"{arr[3]}, 修改前r1: {r1}");
            r1 += 1;
            Console.WriteLine($"{arr[3]}, 修改后r1: {r1}");

            var r2 = GetArrItem(2);
            Console.WriteLine($"{arr[2]}, 修改前r2: {r2}");
            r2 += 1;
            Console.WriteLine($"{arr[2]}, 修改后r2: {r2}");

            var n1 = 0b0001_0001;
            Console.WriteLine($"n1={n1}");

            //Console.ReadKey();
        }

        // 返回元组
        static (int,string) NewStudent()
        {
            return (1, "小明");
        }

        static long[] arr = { 11, 22, 33, 44 };
        // 返回数组元素的引用
        static ref long GetArrItem(int idx)
        {
            return ref arr[idx];
        }
    }


    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        //析构方法
        public void Deconstruct(out double x, out double y)
        {
            x = this.X;
            y = this.Y;
        }
    }
}
