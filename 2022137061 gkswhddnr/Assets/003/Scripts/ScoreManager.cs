using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public List<int> scores = new List<int>();
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int randomNumber = Random.Range(0, 100);
            scores.Add(randomNumber);
        }

        if (Input.GetMouseButtonDown(1))
        {
            scores.RemoveAt(3);
        }
    }
}
