using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class GameManage : MonoBehaviour
{
    //public static GameManage instance = null;
    public PlayerMove lifeCount;
    public GameObject gameoverObj;
    public GameObject yesDestroy;
    public Text gameovetText;
    public Text scoreText;
    public Text bestScoreText;
    public Text lifeText;


    public float playerScore;
    private bool isGameover;


    // Start is called before the first frame update
    void Start()
    {
        playerScore = 0f;
        isGameover = false;
        lifeCount = FindAnyObjectByType<PlayerMove>();

    }

    // Update is called once per frame
    void Update()
    {
        if(!isGameover)
        {
            scoreText.text = "Score : "+(int)playerScore;
            //lifeText.text = "Life : " + (int)lifeCount.playerLife;
        }
        else
        {
            if(Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");

            }
        }


    }

    public void EndGame()
    {
        isGameover = true;

        Destroy(yesDestroy.gameObject);           

        gameoverObj.SetActive(true);

        float bestscore = PlayerPrefs.GetFloat("BestScoreText");

        if(playerScore > bestscore)
        {
            bestscore = playerScore;
            PlayerPrefs.SetFloat("BestScoreText", bestscore);
        }

        bestScoreText.text = "BestScore : " + (int)bestscore;


    }

    public void PlayerLifeImg()
    {
        if(lifeCount.playerLife == 2)
        {

        }
    }

    //private void Awake()
    //{
    //        if (instance != this) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
    //            Destroy(this.gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
    //}

    
}


