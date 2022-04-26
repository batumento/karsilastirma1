using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Transform brain;
    [SerializeField] private GameObject startButton;
    // Start is called before the first frame update
    void Start()
    {
        brain.GetComponent<RectTransform>().DOLocalMoveX(0, 1f).SetEase(Ease.OutBack);
        startButton.GetComponent<RectTransform>().DOLocalMoveY(-250, 1f).SetEase(Ease.OutBack);
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}
