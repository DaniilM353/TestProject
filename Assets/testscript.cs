using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test
{ 

}
public class testscript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        short s = 0;
        int a = 1;
        long b = 3;
        float y = 4;
        double p = 5;
        Debug.Log($"short : {short.MinValue} - {short.MaxValue}");
        object o = a;
        double d2 = (double)o;

        a = (int)b;
        Test mc = new Test();
        TestFunc(mc);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TestFunc(Test mc)
    {
        i = 10;
        Debug.Log(i);
    
    
    }  
}
public class MyList
{
    public void Push(int i)
    { 
    }
    public int Indexof(int item)
    {
        return 0;
    }
    public void Remove(int item) { }
    public void Clear() { }
    public void Insert(int index, int item) { }
    public void RemoveAt(int index) { }
}
