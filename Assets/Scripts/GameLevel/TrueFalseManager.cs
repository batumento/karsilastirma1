using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TrueFalseManager : MonoBehaviour
{
    public void TrueIconSetActive()
    {
        StartCoroutine(TrueIconScale());
    }
    public void FalseIconSetActive()
    {
        StartCoroutine(FalseIconScale());
    }

    IEnumerator TrueIconScale()
    {
        gameObject.transform.GetChild(0).GetComponent<RectTransform>().DOScale(1,0.2f);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.GetChild(0).GetComponent<RectTransform>().DOScale(0, 0.2f);
    }
    IEnumerator FalseIconScale()
    {
        gameObject.transform.GetChild(1).GetComponent<RectTransform>().DOScale(1, 0.2f);
        yield return new WaitForSeconds(0.5f);
        gameObject.transform.GetChild(1).GetComponent<RectTransform>().DOScale(0, 0.2f);
    }
}
