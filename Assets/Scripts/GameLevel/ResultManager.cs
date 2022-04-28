using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultManager : MonoBehaviour
{
    [SerializeField] private Text trueQuestion, falseQuestion, score;
    public void ResultPanelFields(int _trueQuestion, int _falseQuestion,int _score)
    {
        trueQuestion.text = _trueQuestion.ToString();
        falseQuestion.text = _falseQuestion.ToString();
        score.text = _score.ToString();
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Again()
    {
        SceneManager.LoadScene(1);
    }
}
