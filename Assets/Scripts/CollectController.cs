using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectController : MonoBehaviour
{
    public GameObject ball;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect")) 
        {
            gameObject.tag = "Collected";
            other.gameObject.transform.position = transform.position + Vector3.forward;
            other.gameObject.AddComponent<CollectController>();
            other.gameObject.AddComponent<NodeMovement>();
            other.gameObject.GetComponent<NodeMovement>().connectedNode = this.transform.gameObject;
            
            other.gameObject.GetComponent<SphereCollider>().isTrigger = false;
            other.gameObject.tag = "Lead";
            GameManager.ballCount++;
            Destroy(gameObject.GetComponent<CollectController>());
            
        }
    }
    private void Update()
    {
        gameObject.tag = "Lead";
        if (Input.GetKeyDown("f"))
        {
            Destroy(gameObject);

        }
        if (Input.GetKeyDown("d"))
        {
            
            Instantiate(ball);

        }
    }
}
