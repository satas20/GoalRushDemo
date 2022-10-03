using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubGate : MonoBehaviour
{
    [SerializeField] float operation;
    [SerializeField] ParticleSystem pop;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lead"))
        {

           
                sub();
                GetComponent<BoxCollider>().enabled = false;


        }

    }
    private void sub()
    {
        GameObject leader = GameObject.FindObjectOfType<CollectController>().gameObject;
        for (int i = 0; i < operation ; i++)
        {
            GameObject next = leader.GetComponent<NodeMovement>().connectedNode;
            Instantiate(pop, leader.transform.position, Quaternion.identity);
           

            Destroy(leader);
            leader = next;
        }

    }
}

