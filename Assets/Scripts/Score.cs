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
        //score�p�I�u�W�F�N�g��\��
         resultText.SetActive(true);
        //�e�L�X�g������������
�@�@�@�@�@text.text="yoar score \n"+score.ToString() + "Point";
        retry.SetActive(true);
        resultWindow.SetActive(true);
    }

    //������score���Z�̃v���O�����������܂��傤

    public void Retry()
    {
        SceneManager.LoadScene("Main");
    }
    //score�ɉ��Z���郁�]�b�g
    public void PulsScore()
    {
        score++;
    }
}
