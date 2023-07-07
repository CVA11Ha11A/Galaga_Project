using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody playerRigidbody = default;
    public float speed = 5.0f;

    public GameObject PlayerBullet;

    public float playerLife = 2;
    


    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);

        playerRigidbody.velocity = newVelocity;

        //�Ʒ��� �Ѿ� �߻��ϸ� �ɵ�
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GameObject bullet = Instantiate(PlayerBullet, transform.position, transform.rotation);


        }

    }

    public void PlayerDie()
    {
        if(playerLife <= 0)
        { 
        gameObject.SetActive(false);

            GameManage gameManage = FindObjectOfType<GameManage>();
            gameManage.EndGame();
        }


    }



}
