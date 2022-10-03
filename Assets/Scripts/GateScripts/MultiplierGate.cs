using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplierGate : MonoBehaviour
{
    public GameObject ball;

    [SerializeField] float operation;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Lead"))
        {


            add();
            GetComponent<BoxCollider>().enabled = false;


        }
    }
    private void add()
    {
        GameObject newBall;
        for (int i = 0; i < GameManager.ballCount-(GameManager.ballCount/operation); i++)
        {

            GameObject leader = GameObject.FindObjectOfType<CollectController>().gameObject;

            newBall = Instantiate(ball,
               new Vector3(leader.transform.position.x, leader.transform.position.y, leader.transform.position.z + 1.5f),
                Quaternion.identity);

            newBall.AddComponent<CollectController>();
            newBall.tag = "Lead";
            leader.tag = "Collected";
            Destroy(leader.GetComponent<CollectController>());

            newBall.AddComponent<NodeMovement>();
            newBall.GetComponent<NodeMovement>().connectedNode = leader;
            

            leader = newBall;
            GameManager.ballCount++;
        }
    }
}
