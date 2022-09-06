using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

namespace MathTools
{
    /// <summary>
    /// 随机数控制程序
    /// </summary>
    public sealed class RandomSelf 
    {
        private static Random r = new System.Random();
        /// <summary>
        /// 生成随机整数，包含start 和 int
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static int GetRandomRange(int start, int end)
        {
            int number = r.Next(start, end + 1);
            return number;
        }

        /// <summary>
        /// 随机洗牌，重新排序list
        /// </summary>
        /// <param name="targetList"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> RandomShuffle<T>(List<T> targetList)
        {
            List<T> temp = new List<T>();
            while (targetList.Count > 0)
            {
                var randomIndex = r.Next(0, targetList.Count);
                temp.Add(targetList[randomIndex]);
                targetList.RemoveAt(randomIndex);
            }
            targetList = temp;
            return targetList;
        }
    }
    
    
}

