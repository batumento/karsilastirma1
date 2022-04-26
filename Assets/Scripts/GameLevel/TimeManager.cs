using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private int time = 90;
    public void StartTime()
    {
        StartCoroutine(TimeRoutine());
    }
    IEnumerator TimeRoutine()
    {
        while (time >= 0)
        {
            if (time < 10)
            {
                gameObject.GetComponent<Text>().text = "0" + time.ToString();
            }
            else
            {
                gameObject.GetComponent<Text>().text = time.ToString();
            }
            yield return new WaitForSeconds(1);
            time--;
        }
        Debug.Log("Bitti!");
    }
}
