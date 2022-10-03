using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horSpeed;
    public float moveSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            transform.Translate(new Vector3(0, 0, moveSpeed * Time.deltaTime));
            if (Input.GetAxis("Mouse X") > 0 && transform.position.x<4)
            {
                transform.position = Vector3.Lerp(transform.position,
                    new Vector3(transform.position.x + horSpeed, transform.position.y, transform.position.z),
                    .1f);
            }
            else if (Input.GetAxis("Mouse X") < 0 &&transform.position.x>-4)
            {
                transform.position = Vector3.Lerp(transform.position,
                    new Vector3(transform.position.x - horSpeed, transform.position.y, transform.position.z),
                    .1f);
            }
    }

}

