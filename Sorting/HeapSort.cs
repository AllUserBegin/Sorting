using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    /// <summary>
    /// 堆排序
    /// </summary>
    public class HeapSortClass
    {
        ///<summary>
        /// 构建堆
        ///</summary>
        ///<param name="list">待排序的集合</param>
        ///<param name="parent">父节点</param>
        ///<param name="length">输出根堆时剔除最大值使用</param>
        public void HeapAdjust(List<int> list, int parent, int length)
        {
            //temp保存当前父节点
            int temp = list[parent];

            //得到左孩子(这可是二叉树的定义哇)
            int child = 2 * parent + 1;

            while (child < length)
            {
                //如果parent有右孩子，则要判断左孩子是否小于右孩子
                if (child + 1 < length && list[child] < list[child + 1])
                    child++;

                //父节点大于子节点，不用做交换
                if (temp >= list[child])
                    break;

                //将较大子节点的值赋给父亲节点
                list[parent] = list[child];

                //然后将子节点做为父亲节点，已防止是否破坏根堆时重新构造
                parent = child;

                //找到该父节点左孩子节点
                child = 2 * parent + 1;
            }
            //最后将temp值赋给较大的子节点，以形成两值交换
            list[parent] = temp;
        }

        ///<summary>
        /// 堆排序
        ///</summary>
        ///<param name="list">待排序的集合</param>
        ///<param name="top">前K大</param>
        ///<returns></returns>
        public  List<int> HeapSort(List<int> list, int top)
        {
            List<int> topNode = new List<int>();

            //list.Count/2-1:就是堆中非叶子节点的个数
            for (int i = list.Count / 2 - 1; i >= 0; i--)
            {
                HeapAdjust(list, i, list.Count);
            }

            //最后输出堆元素（求前K大）
            for (int i = list.Count - 1; i >= list.Count - top; i--)
            {
                //堆顶与当前堆的第i个元素进行值对调
                int temp = list[0];
                list[0] = list[i];
                list[i] = temp;

                //最大值加入集合
                topNode.Add(temp);

                //因为顺序被打乱，必须重新构造堆
                HeapAdjust(list, 0, i);
            }
            return topNode;
        }
    }
}
