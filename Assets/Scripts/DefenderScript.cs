using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenderScript : MonoBehaviour
{
    [SerializeField] ParticleSystem pop;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        destroyTillBall(other.gameObject);
    }
    private void destroyTillBall(GameObject ball) 
    {
        GameObject current = GameObject.FindObjectOfType<CollectController>().gameObject;
        GameObject N = current;
        while (true) 
        {
            Debug.Log(N.ToString() + Time.deltaTime);
             N = current;
            if (current.Equals(ball.GetComponent<NodeMovement>().connectedNode)){
                break; 
            }
            else
            {
                current = current.GetComponent<NodeMovement>().connectedNode;
                Instantiate(pop, N.transform.position, Quaternion.identity);

                Destroy(N);
            }
        }
    }
}
