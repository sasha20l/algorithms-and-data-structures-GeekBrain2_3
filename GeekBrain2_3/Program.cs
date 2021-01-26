using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace GeekBrain2_3
{
    class Program
    {
        static void Main(string[] args)
        {

                BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);


        }


        

    }

    public class BechmarkClass
    {
        public static double PointDistanceDoubleStructSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;
            double y = pointOne.Y - pointTwo.Y;
            return Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceFloatClassSqrt(PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceFloatStructSqrt(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return (float)Math.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceFloatStruct(PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;
            float y = pointOne.Y - pointTwo.Y;
            return ((x * x) + (y * y));
        }


        [Benchmark]
        public void pointDistanceDoubleStructSqrt()
        {
            PointDistanceDoubleStructSqrt(new PointStruct { X = 2, Y = 2 }, new PointStruct { X = 1, Y = 1 });
        }

        [Benchmark]
        public void pointDistanceFloatStructSqrt()
        {
            PointDistanceFloatStructSqrt(new PointStruct { X = 2, Y = 2 }, new PointStruct { X = 1, Y = 1 });
        }

        [Benchmark]
        public void pointDistanceFloatClassSqrt()
        {
            PointDistanceFloatClassSqrt(new PointClass { X = 2, Y = 2 }, new PointClass { X = 1, Y = 1 });
        }

        [Benchmark]
        public void pointDistanceFloatStruct()
        {
            PointDistanceFloatStruct(new PointStruct { X = 2, Y = 2 }, new PointStruct { X = 1, Y = 1 });
        }
    }



    public class PointClass
    {
        public int X;
        public int Y;
    }

    public struct PointStruct
    {
        public int X;
        public int Y;
    }




}
