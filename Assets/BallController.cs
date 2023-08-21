using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour


{
    //�{�[����������\���̂���z���̍ŏ��l
    private float vissiblePosZ = -6.5f;

    //�Q�[���I�[�o�[��\������e�L�X�g
    private GameObject gameoverText;

    //���_��\������e�L�X�g
    private GameObject scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        //�V�[������ScoreText�I�u�W�F�N�g���擾
        this.scoreText = GameObject.Find("ScoreText");
    
    }

     //�Փˎ��ɌĂ΂��֐�
    void OnCollisionEnter(Collision collision)
    {

        //�^�O�ɂ���ē��_��ς���
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
        //�{�[������ʊO�ɏo���ꍇ
        if(this.transform.position.z < this.vissiblePosZ)
        {
            //GameOverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }
        //Score�ɓ��_��\��
        string s = score.ToString();
       this.scoreText.GetComponent<Text>().text = score.ToString();
    }
}
