using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] Score score;
    [SerializeField] PanelContlloler panelcontlloler;
    private void Start()
    {
        score= GameObject.Find("score").GetComponent<Score>();
        panelcontlloler = GameObject.FindWithTag("Player").GetComponent<PanelContlloler>();
    }
    //�Փ˂�������p�̊֐������
    void OnCollisionEnter(Collision co)
    {
        //�G�ꂽ�^�O���Q�[���I�[�o�[�Z���T�[�ɂ��Ă���hfruits�Ȃ�ŏIscore��\������
        if (co.gameObject.tag == "fruits")
        {
            score.PlayScore();
            panelcontlloler.Result();
            Destroy(this.gameObject);

        }
    }

}
