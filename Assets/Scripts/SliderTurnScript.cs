using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderTurnScript : MonoBehaviour
{
    float z;
    // Start is called before the first frame update
    void Start()
    {
         z = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, 0, z);
        if (transform.position.x < -4) 
        {
            transform.rotation = Quaternion.Euler(new Vector3(0,90,0));
        }
        if (transform.position.x >4)
        {
            transform.rotation = Quaternion.Euler(new Vector3(0, 270, 0));
        }
    }
}
