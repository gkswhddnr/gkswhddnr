using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMethodAttribute : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[,] results = new int[10, 10];

        for (int i = 0; i < results.GetLength(0); i++)     //GetLength �迭�� ���̸� ���� �´� 
        {
            for (int j = 0; j < results.GetLength(1); j++)
            {
                results[i, j] = (i + 1) * (j + 1);        // +1�� �ϴ� ������ 0�� ���� for ���� �ݺ��Ǳ� ������ 
                Debug.Log(results[i, j]);
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
