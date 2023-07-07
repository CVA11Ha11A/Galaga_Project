using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SponerScprit : MonoBehaviour
{
    public GameObject slimeObject = default;

    public GameObject sponerBox = default;

    public float slimeSponeTime = 0.5f;    

    public float slimeSpone = default;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        slimeSpone += slimeSponeTime * Time.deltaTime;

        if(slimeSpone > 2)
        {
            GameObject clone = Instantiate(slimeObject);            
            clone.transform.position = sponerBox.transform.position;
            slimeSpone = 0;
        }

    }
}
