using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstArray : MonoBehaviour
{
    public int[] numbers = new int[] { 9, -11, 6, -12, 1 };
    // Start is called before the first frame update
    void Start()
    {
        numbers[0] = 7;
        Debug.Log(numbers[0]); // �迭�� 0��° ��Ҹ� Log â�� �����ش�; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}