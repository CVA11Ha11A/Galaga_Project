using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DownWellScript : MonoBehaviour
{
    private BoxCollider wellCollider;

    // Start is called before the first frame update
    void Start()
    {
        wellCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.LogFormat("���� ������Ʈ�� �̸� -> {0}",other.name);

        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }

        if(other.gameObject.CompareTag("Bullet"))
        {
            Destroy(other.gameObject);
        }
    }

}
