using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class CountDownManager : MonoBehaviour
{
    private GameManager gameManager;
    private void Awake()
    {
        gameManager = Object.FindObjectOfType<GameManager>();
    }
    void Start()
    {
        StartCoroutine(CountDownRoutine());
    }

    IEnumerator CountDownRoutine()
    {
        gameObject.GetComponentInChildren<Text>().text = "3";
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);

        gameObject.GetComponentInChildren<Text>().text = "2";
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);


        gameObject.GetComponentInChildren<Text>().text = "1";
        yield return new WaitForSeconds(0.5f);
        gameObject.GetComponent<RectTransform>().DOScale(1, 0.5f).SetEase(Ease.OutBack);
        yield return new WaitForSeconds(1);
        gameObject.GetComponent<RectTransform>().DOScale(0, 0.5f).SetEase(Ease.InBack);
        yield return new WaitForSeconds(0.6f);
        StopAllCoroutines();

        gameManager.StartGame();
    }

}
