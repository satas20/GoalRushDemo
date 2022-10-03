using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PostScript : MonoBehaviour
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
        if (other.CompareTag("Lead"))
        {
            GameManager.goalCount++;
            other.GetComponent<NodeMovement>().connectedNode.tag = "Lead";
            other.GetComponent<NodeMovement>().connectedNode.AddComponent<CollectController>();
            Instantiate(pop, other.transform.position, Quaternion.identity);

            Destroy(other.gameObject);
        }

        if (other.CompareTag("Player"))
        {
            other.gameObject.transform.position = other.gameObject.transform.position - new Vector3(0, 0, -5);
        }

    }
}
