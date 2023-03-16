using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMethodAttribute : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[,] results = new int[10, 10];

        for (int i = 0; i < results.GetLength(0); i++)     //GetLength 배열의 길이를 가져 온다 
        {
            for (int j = 0; j < results.GetLength(1); j++)
            {
                results[i, j] = (i + 1) * (j + 1);        // +1을 하는 이유는 0번 부터 for 문이 반복되기 때문에 
                Debug.Log(results[i, j]);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
