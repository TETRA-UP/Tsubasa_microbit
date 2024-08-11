using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    [SerializeField] GameObject resultText;
    [SerializeField] GameObject resultWindow;
    [SerializeField] GameObject retry;
    Text text;
    int score = 0;
    public bool result;
    void Start()
    {
        text = resultText.GetComponent<Text>();
        resultText.SetActive(false);
        resultWindow.SetActive(false);
        retry.SetActive(false);
        result = false;
    }
    void Update()
    {

    }

    public void PlayScore()
    {
        //score用オブジェクトを表示
         resultText.SetActive(true);
        //テキストを書き換える
　　　　　text.text="yoar score \n"+score.ToString() + "Point";
        retry.SetActive(true);
        resultWindow.SetActive(true);
    }

    //ここにscore加算のプログラムを書きましょう

    public void Retry()
    {
        SceneManager.LoadScene("Main");
    }
    //scoreに加算するメゾット
    public void PulsScore()
    {
        score++;
    }
}
