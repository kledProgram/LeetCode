/* ==============================================================================
 * 功能描述：_22括号生成  
 * 创 建 者：phoenix
 * 邮箱：1015522764@qq.com
 * 创建日期：2021/02/20 15:32:32
 * CLR Version :4.0.30319.42000
 * ==============================================================================*/
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    //数字 n 代表生成括号的对数，请你设计一个函数，用于能够生成所有可能的并且 有效的 括号组合。
    class _22括号生成
    {
        class Solution
        {
            public IList<String> GenerateParenthesis(int n)
            {
                IList<String> ans = new List<String>();
                backtrack(ans, new StringBuilder(), 0, 0, n);
                return ans;
            }

            /// <summary>
            /// 回溯
            /// </summary>
            /// <param name="ans">存字符串的数组</param>
            /// <param name="cur">当前字符串</param>
            /// <param name="open">"("</param>
            /// <param name="close">")"</param>
            /// <param name="max">括号对数</param>
            public void backtrack(IList<String> ans, StringBuilder cur, int open, int close, int max)
            {
                //括号填完了
                if (cur.Length == max * 2)
                {
                    ans.Add(cur.ToString());
                    return;
                }
                ///回溯策略:首先肯定以'('开始,然后对openclose的数量进行统计继续回溯直到括号占满所有位置
                {
                    if (open < max)
                    {
                        cur.Append('(');
                        //回溯策略:
                        backtrack(ans, cur, open + 1, close, max);
                        //撤销操作,删除当前状态最后一个位置的符号
                        cur.Remove(cur.Length - 1, 1);
                    }
                    if (close < open)
                    {
                        cur.Append(')');
                        backtrack(ans, cur, open, close + 1, max);
                        cur.Remove(cur.Length - 1, 1);
                    }
                }
            }
        }

    }
}



