using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //5次比较
            for (int i = 1; i <= 1; i++)
            {
                List<int> list = new List<int>();

                //插入200个随机数到数组中
                for (int j = 0; j < 20000; j++)
                {
                    Thread.Sleep(1);
                    list.Add(new Random((int)DateTime.Now.Ticks).Next(0, 100000000));
                }            

                Console.WriteLine("\n第" + i + "次比较：");

                Stopwatch watch = new Stopwatch();

                watch.Start();
                var result = list.OrderBy(single => single).ToList();
                watch.Stop();

                Console.WriteLine("\n系统定义的快速排序耗费时间：" + watch.ElapsedMilliseconds);
                Console.WriteLine("输出前是十个数:" + string.Join(",", result.Take(10).ToList()));

                watch.Start();
                new QuickSortClass().QuickSort(list, 0, list.Count - 1);
                watch.Stop();

                Console.WriteLine("\n俺自己写的快速排序耗费时间：" + watch.ElapsedMilliseconds);
                Console.WriteLine("输出前是十个数:" + string.Join(",", list.Take(10).ToList()));


                watch.Start();
                new SelectionSortClass().SelectionSort(list);
                watch.Stop();

                Console.WriteLine("\n直接选择排序耗费时间：" + watch.ElapsedMilliseconds);
                Console.WriteLine("输出前是十个数:" + string.Join(",", list.Take(10).ToList()));


                watch.Start();
                new HeapSortClass().HeapSort(list, 10);
                watch.Stop();
                Console.WriteLine("\n堆排序求前K大耗费时间：" + watch.ElapsedMilliseconds);
                Console.WriteLine("输出前十个数:" + string.Join(",", list.Take(10).ToList()));

                watch.Start();
                new InsertSortClass().InsertSort(list);
                watch.Stop();
                Console.WriteLine("\n插入排序求前K大耗费时间：" + watch.ElapsedMilliseconds);
                Console.WriteLine("输出前十个数:" + string.Join(",", list.Take(10).ToList()));

                watch.Start();
                
                new MergeSortClass().MergeSort(list.ToArray(), new int[list.Count], 0, list.Count-1);
                watch.Stop();
                Console.WriteLine("\n合并排序求前K大耗费时间：" + watch.ElapsedMilliseconds);
                Console.WriteLine("输出前十个数:" + string.Join(",", list.Take(10).ToList()));

            }
        }
    }
}
