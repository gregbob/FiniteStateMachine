using UnityEngine;
using System.Collections;

public class Counter  {

    private int count = 0;
    public int Count { get { return count; } }


    public void IncreaseCount()
    {
        count++;
    }
    public void MultiplyCount(int val)
    {
        count = count * val;
    }

    public void PrintCount()
    {
        Debug.Log(count);
    }


}
