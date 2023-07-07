using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlime : MonoBehaviour
{
    private Rigidbody enemySlime = default;
    public float slimeSpeed = 1.0f;
    public float attackTime = 0f;
    public float attackSleep = 1f;
    public float moveTime = 0f;




    public GameObject Enemybullet;
    // Start is called before the first frame update
    void Start()
    {
        enemySlime = GetComponent<Rigidbody>();
        enemySlime.velocity = -transform.up * slimeSpeed * Time.deltaTime;

    }

    // Update is called once per frame
    void Update()
    {
        

        attackTime += attackSleep * Time.deltaTime;


        if (attackTime >= 1)
        {
            //Debug.Log("여기 들어오나");
            GameObject enemyBullet = Instantiate(Enemybullet, transform.position, transform.rotation);
            attackTime = 0;
            
        }

        //if(moveTime > 3)
        //{
        //    enemySlime.velocity = -transform.up * slimeSpeed * Time.deltaTime;
        //    moveTime = 0;
        //}

        //else
        //{
        //    moveTime += Time.deltaTime * 1;
        //}

    }

    public void EnemyDie()
    {
        gameObject.SetActive(false);
    

    }
}
