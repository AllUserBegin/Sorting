using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    public class InsertSortClass
    {
        public void InsertSort(List<int> list)
        {
            //无须序列
            for (int i = 1; i < list.Count; i++)
            {
                var temp = list[i];

                int j;

                //有序序列
                for (j = i - 1; j >= 0 && temp < list[j]; j--)
                {
                    list[j + 1] = list[j];
                }
                list[j + 1] = temp;
            }
        }
    }
}
