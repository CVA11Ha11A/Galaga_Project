using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySlime : MonoBehaviour
{
    private Rigidbody enemySlime = default;
    public float SlimeSpeed = 1.0f;
    public float attackTime = 0f;
    public float attackSleep = 1f;

    public GameObject Enemybullet;
    // Start is called before the first frame update
    void Start()
    {
        enemySlime = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        attackTime += attackSleep * Time.deltaTime;
        if (attackTime >= 1)
        {
            //Debug.Log("���� ������");
            GameObject enemyBullet = Instantiate(Enemybullet, transform.position, transform.rotation);
            attackTime = 0;
            
        }

    }

    public void EnemyDie()
    {
        gameObject.SetActive(false);
    }
}
