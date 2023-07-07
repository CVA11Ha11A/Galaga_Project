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

        //�Ѿ� �ӵ� = �չ��� * �ӵ�
        enemyBullet.velocity = -transform.up * enemyBulletSpeed;

        //10�ʵڿ� ������Ʈ �ı�
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
            //���⼭ ���� Die �޼��� ����� ���ƿͼ� �浹�� ����� Ŭ������ �������� destroy�����ϸ�ɵ�
            PlayerMove player = other.GetComponent<PlayerMove>();

            if (player != null)
            {
                player.PlayerDie();
                player.playerLife -= 1;
            }


        }



    }
}
