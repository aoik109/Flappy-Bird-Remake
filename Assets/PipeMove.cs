using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 2;
    public float destroyZone = -11.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        // Time.deltaTime ensures that multiplication happens the same no matter the frame rate

        if (transform.position.x < destroyZone)
        {
            Destroy(gameObject);
        }
    }
}
