using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{
    public int a = 10;
    public float b = 10.0f;
    private string c = "10";
    private string sample = "5";
    private bool d = false;

    int[] sampleArr = { 1, 2, 3, 4, 5 };
    List<string> sampleList =  new List<string>() { "hello", "there" };
    Dictionary<string, int> sampleDict = new Dictionary<string, int>(){ { "a", 1 }, { "b", 2 } };
    

    //single line comment

    /*
     * multi line comment
     */

    /// <summary>
    /// summary comment
    /// </summary>
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(a);
        Debug.LogFormat("int: {0}, float: {1}", a, b);
        string concat = c + sample;
        string interp = $"{c}{sample}";
        Debug.Log(example(a, a));

        if (a == 10)
        {
            Debug.Log("a equals 10");
            if (b == 10.0f)
            {
                Debug.Log("b also equals 10");
            }
        }
        else
        {
            Debug.Log("a does not equal 10");
        }
        switch (a)
        {
            case 10:
                Debug.Log("a equals 10");
                break;
            default:
                Debug.Log("a does not equal 10");
                break;
        }

        for(int i = 0; i<sampleList.Count; i++)
        {
            if(i == 0)
            {
                Debug.Log(sampleList[i]);
            }
        }

        foreach(string i in sampleList)
        {
            Debug.Log(i);
        }

        foreach (string key in sampleDict.Keys)
        {
            Debug.Log($"{key}: {sampleDict[key]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int example(int inputA, int inputB)
    {
        return inputA + inputB;
    }
}
