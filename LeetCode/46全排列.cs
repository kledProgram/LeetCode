/* ==============================================================================
 * 功能描述：_46全排列  
 * 创 建 者：phoenix
 * 邮箱：1015522764@qq.com
 * 创建日期：2021/02/20 14:09:42
 * CLR Version :4.0.30319.42000
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _46全排列
    {
        public class Solution
        {
            public static IList<IList<int>> Permute(int[] nums)
            {
                IList<int> output = new List<int>();
                IList<IList<int>> res = new List<IList<int>>();

                foreach (var num in nums)
                {
                    output.Add(num);
                }
                backtrack(nums.Length, output, res, 0);

                return res;
            }
            //回溯函数
            public static void backtrack(int len, IList<int>output, IList<IList<int>> res,int frist) 
            {
                //所有数填完了
                if (frist == len)
                {
                    Console.WriteLine("所有数填完了");
                    printArray(output);
                    Console.WriteLine();
                    res.Add(new List<int>(output));
                }

                for (int i = frist; i < len; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("frist="+frist+"   i="+i);
                    Console.WriteLine();


                    Console.WriteLine("当前数组:");
                    printArray(output);
                    // 动态维护数组
                    swap(output, frist, i);

                    Console.WriteLine("交换位置"+ frist+"和"+i+"上的数字");
                    printArray(output);



                    Console.WriteLine("继续递归填下一个数");
                    // 继续递归填下一个数
                    backtrack(len, output, res, frist + 1);
                    printArray(output);

                    Console.WriteLine("撤销操作...");
                    // 撤销操作
                    swap(output, frist, i);
                    Console.WriteLine("交换位置" + frist + "和" + i + "上的数字");

                    printArray(output);


                }

            }
            //交换数组中frist和i的位置
            public static void swap(IList<int> output, int frist, int i) 
            {
                if (frist == i) 
                {
                    return; 
                }
                    
                int temp = output[i];
                output[i] = output[frist];
                output[frist] = temp;
            }

            static void printArray(IList<int> output) 
            {
                foreach (var item in output)
                {
                    Console.Write(item);
                }
                Console.WriteLine();
            }


        }


    }
}
