using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject scoreTimePanel;
    [SerializeField] private GameObject scoreGrap;
    [SerializeField] private GameObject bigValueSelected;
    [SerializeField] private GameObject upRectangle;
    [SerializeField] private GameObject downRectangle;

    private TimeManager timeManager;
    private CircleManager circleManager;

    private int counterGame;
    private int whickGame;
    private int upValue;
    private int downValue;
    private int bigValue;
    private int buttonValue;

    private void Awake()
    {
        circleManager = Object.FindObjectOfType<CircleManager>();
        timeManager = Object.FindObjectOfType<TimeManager>();
    }
    void Start()
    {
        counterGame = 20;
        whickGame = 0;
        //Ýkiside ayný aradaki fark birden fazla Child'i olan 
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
        bigValueSelected.GetComponent<CanvasGroup>().DOFade(1, 0.3f);
        WhichGame();
        timeManager.StartTime();
    }

    void WhichGame()
    {
        if (counterGame < 5)
        {
            whickGame = 1;
        }
        else if (counterGame >=5 && counterGame < 10)
        {
            whickGame = 2;
        }
        else if (counterGame >= 10 && counterGame < 15)
        {
            whickGame = 3;
        }
        else if(counterGame >= 15 && counterGame < 20)
        {
            whickGame=4;
        }
        else if(counterGame >= 20 && counterGame <25)
        {
            whickGame = 5;
        }
        else
        {
            whickGame = Random.Range(1, 6);
        }

        switch (whickGame)
        {
            case 1:
                FirstFunction();
                break;

            case 2:
                SecondFunction();
                break;

            case 3:
                ThirdFunction();
                break;

            case 4:
                FourthFunction();
                break;

            case 5:
                FifthFunction();
                break;
        }
    }

    void FirstFunction()
    {
        int randomValue = Random.Range(1, 50);
        if (randomValue<=25)
        {
            upValue = Random.Range(2, 50);
            downValue = upValue + Random.Range(1, 15);
        }
        else
        {
            upValue = Random.Range(2, 50);
            downValue = Mathf.Abs(upValue - Random.Range(1, 10));
        }

        if (upValue >downValue)
        {
            bigValue = upValue;
        }
        else
        {
            bigValue = downValue;
        }

        upRectangle.transform.GetChild(0).GetComponent<Text>().text = upValue.ToString();
        downRectangle.transform.GetChild(0).GetComponent<Text>().text = downValue.ToString();
        Debug.Log(bigValue);

    }
    void SecondFunction()
    {
        int firstNumber = Random.Range(1, 10);
        int secondNumber = Random.Range(1, 20);

        int thirdNumber = Random.Range(1, 10);
        int fourthNumber = Random.Range(1, 20);
        upValue = firstNumber + secondNumber;
        downValue = fourthNumber + thirdNumber;
       

        if (upValue > downValue)
        {
            bigValue = upValue;
        }
        else if (downValue > upValue)
        {
            bigValue = downValue;
        }
        if (upValue == downValue)
        {
            SecondFunction();
            return;
        }
        upRectangle.transform.GetChild(0).GetComponent<Text>().text = firstNumber+"+"+secondNumber;
        downRectangle.transform.GetChild(0).GetComponent<Text>().text = thirdNumber+"+"+fourthNumber;
    }
    void ThirdFunction()
    {
        int firstNumber = Random.Range(11, 30);
        int secondNumber = Random.Range(1, 11);

        int thirdNumber = Random.Range(11, 40);
        int fourthNumber = Random.Range(1, 11);
        upValue = firstNumber - secondNumber;
        downValue = thirdNumber - fourthNumber;


        if (upValue > downValue)
        {
            bigValue = upValue;
        }
        else if (downValue > upValue)
        {
            bigValue = downValue;
        }
        if (upValue == downValue)
        {
            ThirdFunction();
            return;
        }
        upRectangle.transform.GetChild(0).GetComponent<Text>().text = firstNumber + "-" + secondNumber;
        downRectangle.transform.GetChild(0).GetComponent<Text>().text = thirdNumber + "-" + fourthNumber;
    }
    void FourthFunction()
    {
        int firstNumber = Random.Range(1, 10);
        int secondNumber = Random.Range(1, 10);

        int thirdNumber = Random.Range(1, 10);
        int fourthNumber = Random.Range(1, 10);
        upValue = firstNumber * secondNumber;
        downValue = thirdNumber * fourthNumber;


        if (upValue > downValue)
        {
            bigValue = upValue;
        }
        else if (downValue > upValue)
        {
            bigValue = downValue;
        }
        if (upValue == downValue)
        {
            FourthFunction();
            return;
        }
        upRectangle.transform.GetChild(0).GetComponent<Text>().text = firstNumber + " x " + secondNumber;
        downRectangle.transform.GetChild(0).GetComponent<Text>().text = thirdNumber + " x " + fourthNumber;
    }
    void FifthFunction()
    {
        int bolen1 = Random.Range(2, 10);
        upValue = Random.Range(2, 10);

        int bolunen1 = bolen1 * upValue;


        int bolen2 = Random.Range(2, 10);
        downValue = Random.Range(2, 10);

        int bolunen2 = bolen2 * downValue;
        if (upValue > downValue)
        {
            bigValue = upValue;
        }
        else if (downValue > upValue)
        {
            bigValue = downValue;
        }
        if (upValue == downValue)
        {
            FourthFunction();
            return;
        }

        upRectangle.transform.GetChild(0).GetComponent<Text>().text = bolunen1 + " / " + bolen1;
        downRectangle.transform.GetChild(0).GetComponent<Text>().text = bolunen2 + " / " + bolen2;
    }

    public void ButtonValueChecked(string buttonName)
    {
        if (buttonName == "upButton")
        {
            buttonValue = upValue;
        }
        else if (buttonName == "downButton")
        {
            buttonValue = downValue;
        }

        if (buttonValue == bigValue)
        {
            circleManager.CircleLightOpen(counterGame % 5);
            counterGame++;
            WhichGame();
        }
        else
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.red;
        }
    }
}
