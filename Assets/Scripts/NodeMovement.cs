using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeMovement : MonoBehaviour
{
    public GameObject connectedNode;
   

    [SerializeField] float lerpSpeed =20;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<RollingScript>().rotation = new Vector3(200, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Lerp(transform.position.x, connectedNode.transform.position.x, Time.deltaTime * lerpSpeed),
            connectedNode.transform.position.y,
            connectedNode.transform.position.z +1.5f
            );
    }
    private void OnDestroy()
    {


        GameManager.ballCount--;
        connectedNode.gameObject.AddComponent<CollectController>();

    }
}
