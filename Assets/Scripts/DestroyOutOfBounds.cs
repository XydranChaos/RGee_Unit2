using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // Start is called before the first frame update
    private float topOfScene = 32.0f;
    private float bottomOfScene = -11.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topOfScene)
        {
            Destroy(gameObject);
        }
        else if(transform.position.z < bottomOfScene)
        {
            Destroy(gameObject);
        }
    }
}

