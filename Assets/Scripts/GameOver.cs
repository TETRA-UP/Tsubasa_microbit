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
    //衝突した時専用の関数を作る
    void OnCollisionEnter(Collision co)
    {
        //触れたタグがゲームオーバーセンサーについている”fruitsなら最終scoreを表示する
        if (co.gameObject.tag == "fruits")
        {
            score.PlayScore();
            panelcontlloler.Result();
            Destroy(this.gameObject);

        }
    }

}
