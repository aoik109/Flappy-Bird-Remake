using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BirdScript : MonoBehaviour

{
    //UnityEvent myEvent = new UnityEvent();

    public Rigidbody2D rigidBody;
    public float flapStrength;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.name = "Bob Birdington";
        //myEvent.AddListener(flyUp);
        flap();
    }

    // Update is called once per frame
    void Update()
    {
        // if the spacebar is pressed, then we increase velocity of rigidbody (vector)
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //myEvent.Invoke();
            flap();            
        }
    }

    /* void flyUp() {
         transform.position = transform.position + new Vector3(0.0f, 8.0f);
         //Debug.Log("space was pressed");
     } */

    void flap()
    {
        rigidBody.velocity = Vector2.up * flapStrength; // (0,1) * 5
    }
}
