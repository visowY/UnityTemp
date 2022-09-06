using System.Collections;
using System.Collections.Generic;
using System.Linq;
using MathTools;
using NetExtends;
using UnityEngine;

public class MonoTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      Test2();
    }

    private void Test1()
    {
        // 随机数统计
        // 随机数
        List<int> randomStatistic = new List<int>(){0,0,0,0,0,0,0};
        for (int i = 0; i < 1000; i++)
        {
            
            var s = RandomSelf.GetRandomRange(1, 6);
            randomStatistic[s] += 1;
        }
        var str =randomStatistic.JoinItemToStr("_");
        Debug.LogError(str);
    }

    private void Test2()
    {
        // 随机排序
        List<int> sortList = Enumerable.Range(0, 100).ToList();
        Debug.Log($"before: {sortList.JoinItemToStr("_")}");

        sortList = RandomSelf.RandomShuffle(sortList);
        Debug.Log($"after: {sortList.JoinItemToStr("_")}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
