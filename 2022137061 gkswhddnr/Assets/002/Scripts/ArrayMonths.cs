using System.Collections;
using System.Collections.Generic;
using System.Globalization;         //월 데이터를 활용하기 위하여 Using에 추가
using System;                       //DateTime을 가져오기 위해서 추가
using UnityEngine;

public class ArrayMonths : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] months = new string[12]; //12개의 문자열 배열은 선언한다.

        for (int month = 1; month <= 12; month++)
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
            string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("Ko-KR"));
            months[month - 1] = name; // for문을 1부터 시작해서 0번 부터 시작하게 보정
        }

        foreach (string month in months)
        {
            Debug.Log(month);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
