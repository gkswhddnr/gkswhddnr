using System.Collections;
using System.Collections.Generic;
using System.Globalization;         //�� �����͸� Ȱ���ϱ� ���Ͽ� Using�� �߰�
using System;                       //DateTime�� �������� ���ؼ� �߰�
using UnityEngine;

public class ArrayMonths : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] months = new string[12]; //12���� ���ڿ� �迭�� �����Ѵ�.

        for (int month = 1; month <= 12; month++)
        {
            DateTime firstDay = new DateTime(DateTime.Now.Year, month, 1);
            string name = firstDay.ToString("MMMM", CultureInfo.CreateSpecificCulture("Ko-KR"));
            months[month - 1] = name; // for���� 1���� �����ؼ� 0�� ���� �����ϰ� ����
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
