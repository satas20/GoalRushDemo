using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateScript : MonoBehaviour
{
    public GameObject ball;
    
    [SerializeField] float operation;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lead")) 
        {

            if (operation <0) 
            {
                sub();
            }
            else
            {
                add();
            }
        }
       
    }
    private void add() 
    {
        for (int i = 0; i < operation; i++)
        {
            GameObject leader = GameObject.FindObjectOfType<CollectController>().gameObject;
            Debug.Log(leader.transform.position);
            GameObject newBall = Instantiate(ball,
               new Vector3(leader.transform.position.x,leader.transform.position.y,leader.transform.position.z+1.5f),
                Quaternion.identity);
            newBall.AddComponent<CollectController>();

            Destroy(leader.GetComponent<CollectController>());
            
            newBall.AddComponent<NodeMovement>();
            newBall.GetComponent<NodeMovement>().connectedNode = leader;
            leader = newBall;

        }
    }
    private void sub() 
    {
        GameObject leader = GameObject.FindObjectOfType<CollectController>().gameObject;
        for (int i = 0; i < operation * -1; i++)
        {
            GameObject next = leader.GetComponent<NodeMovement>().connectedNode;
            Destroy(leader);
            leader = next;
        }
    }
   
}
