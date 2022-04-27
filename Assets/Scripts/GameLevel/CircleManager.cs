using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CircleManager : MonoBehaviour
{
    [SerializeField] private GameObject[] circles;
    void Start()
    {
        CircleLightClose();
    }
    public void CircleLightClose()
    {
        foreach (var circle in circles)
        {
            circle.GetComponent<RectTransform>().localScale = Vector3.zero;
        }
    }

    public void CircleLightOpen(int whichCircle)
    {
        circles[whichCircle].GetComponent<RectTransform>().DOScale(1, 0.3f);
        if (whichCircle % 5 == 0)
        {
            CircleLightClose();
        }
    }
}
