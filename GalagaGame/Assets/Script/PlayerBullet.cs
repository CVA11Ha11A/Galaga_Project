using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    private Rigidbody playerBullet = default;
    public float bulletSpeed = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        playerBullet = GetComponent<Rigidbody>();
        
        //총알 속도 = 앞방향 * 속도
        playerBullet.velocity = transform.up * bulletSpeed;

        //10초뒤에 오브젝트 파괴
        Destroy(playerBullet,10f);

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            //여기서 적의 Die 메서드 만들고 돌아와서 충돌시 상대의 클레스를 가져오고 destroy실행하면될듯
            EnemySlime enemySlime = other.GetComponent<EnemySlime>();

            if (enemySlime != null)
            {
                enemySlime.EnemyDie();

            }


        }
        
        

    }
}
