using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevideGate : MonoBehaviour
{
    [SerializeField] float operation;
    [SerializeField] ParticleSystem pop;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lead"))
        {

            
            devide();

            GetComponent<BoxCollider>().enabled = false;

        }

    }
    private void devide()
    {
        GameObject leader = GameObject.FindObjectOfType<CollectController>().gameObject;
        for (int i = 0; i < GameManager.ballCount-GameManager.ballCount/operation; i++)
        {
            GameObject next = leader.GetComponent<NodeMovement>().connectedNode;
            Instantiate(pop, leader.transform.position, Quaternion.identity);
            Destroy(leader);
            leader = next;
        }

    }
  
}
