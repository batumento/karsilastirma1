using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject scoreTimePanel;
    [SerializeField] private GameObject scoreGrap;
    [SerializeField] private GameObject upRectangle;
    [SerializeField] private GameObject downRectangle;

    private TimeManager timeManager;

    private void Awake()
    {
        timeManager = Object.FindObjectOfType<TimeManager>();
    }
    void Start()
    {   //Ýkiside ayný aradaki fark birden fazla Child'i olan 
        upRectangle.transform.GetChild(0).GetComponent<Text>().text = "";
        downRectangle.transform.GetChild(0).GetComponent<Text>().text = "";
        SceneScreenUpdate();
    }
    void SceneScreenUpdate()
    {
        scoreTimePanel.GetComponent<CanvasGroup>().DOFade(1,1);
        scoreGrap.GetComponent<CanvasGroup>().DOFade(1, 1);
        upRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f).SetEase(Ease.OutBack);
        downRectangle.GetComponent<RectTransform>().DOLocalMoveX(0, 0.7f).SetEase(Ease.OutBack);

    }
    public void StartGame()
    {
        scoreGrap.GetComponent<CanvasGroup>().DOFade(0, 0.2f);
        downRectangle.transform.GetChild(0).GetComponent<Text>().text = "31";
        upRectangle.transform.GetChild(0).GetComponent<Text>().text = "62";
        timeManager.StartTime();
    }
}
