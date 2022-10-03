using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameEnding : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("endGame")) 
        {
            Debug.Log("xx"); 
            anim.SetBool("gameEnd", true);
            FindObjectOfType<Movement>().horSpeed = 0;
            FindObjectOfType<Movement>().moveSpeed = 0;
            FindObjectOfType<CameraFollow>().offset = new Vector3(0, 10, -30);

        }
    }
}
