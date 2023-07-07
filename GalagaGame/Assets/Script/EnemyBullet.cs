using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    private Rigidbody enemyBullet = default;

    public float enemyBulletSpeed = 2.0f; 


    // Start is called before the first frame update
    void Start()
    {
        enemyBullet = GetComponent<Rigidbody>();

        //총알 속도 = 앞방향 * 속도
        enemyBullet.velocity = -transform.up * enemyBulletSpeed;

        //10초뒤에 오브젝트 파괴
        Destroy(enemyBullet, 10f);


    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //여기서 적의 Die 메서드 만들고 돌아와서 충돌시 상대의 클레스를 가져오고 destroy실행하면될듯
            PlayerMove player = other.GetComponent<PlayerMove>();

            if (player != null)
            {
                player.PlayerDie();
                player.playerLife -= 1;
            }


        }



    }
}
