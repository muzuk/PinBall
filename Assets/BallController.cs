using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour


{
    //ボールが見える可能性のあるz軸の最小値
    private float vissiblePosZ = -6.5f;

    //ゲームオーバーを表示するテキスト
    private GameObject gameoverText;

    //得点を表示するテキスト
    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //シーン中のScoreTextオブジェクトを取得
        this.scoreText = GameObject.Find("ScoreText");
    
    }

     //衝突時に呼ばれる関数
    void OnCollisionEnter(Collision collision)
    {

        //タグによって得点を変える
        if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 3;
        }
        else if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 30;
        }
        else if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 1;
        }
        else if(collision.gameObject.tag == "LargeCloudTag")
        {
            score += 10;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if(this.transform.position.z < this.vissiblePosZ)
        {
            //GameOverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        //Scoreに得点を表示
        string s = score.ToString();
       this.scoreText.GetComponent<Text>().text = score.ToString();
    }
}
