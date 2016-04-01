using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    /// <summary>
    ///  选择排序
    /// </summary>
    public class SelectionSortClass
    {
        //选择排序
        public List<int> SelectionSort(List<int> list)
        {
            //要遍历的次数
            for (int i = 0; i < list.Count - 1; i++)
            {
                //假设tempIndex的下标的值最小
                int tempIndex = i;

                for (int j = i + 1; j < list.Count; j++)
                {
                    //如果tempIndex下标的值大于j下标的值,则记录较小值下标j
                    if (list[tempIndex] > list[j])
                        tempIndex = j;
                }

                //最后将假想最小值跟真的最小值进行交换
                var tempData = list[tempIndex];
                list[tempIndex] = list[i];
                list[i] = tempData;
            }
            return list;
        }
    }
}
