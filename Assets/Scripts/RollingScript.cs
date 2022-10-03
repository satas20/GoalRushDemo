using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingScript : MonoBehaviour
{
    [SerializeField] public Vector3 rotation = new Vector3(0,0,0);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(rotation*Time.deltaTime,Space.World);
    }
}
