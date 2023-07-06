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
        
        //�Ѿ� �ӵ� = �չ��� * �ӵ�
        playerBullet.velocity = transform.up * bulletSpeed;

        //10�ʵڿ� ������Ʈ �ı�
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
            //���⼭ ���� Die �޼��� ����� ���ƿͼ� �浹�� ����� Ŭ������ �������� destroy�����ϸ�ɵ�
            EnemySlime enemySlime = other.GetComponent<EnemySlime>();

            if (enemySlime != null)
            {
                enemySlime.EnemyDie();

            }


        }
        
        

    }
}
