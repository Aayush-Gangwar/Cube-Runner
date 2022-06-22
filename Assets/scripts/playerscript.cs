using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public Rigidbody rb;
    // Start is called before the first frame update
    public float ff = 500f;
    public float speed = 20f;
    public float maxX;
    public float minX;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
      //  rb.AddForce(0, 0, ff * Time.deltaTime);
        Vector3 Playerpos = transform.position;
        if (Playerpos.x>maxX)
        {
            Playerpos.x = maxX;
        }
        if(Playerpos.x <minX)
        {
            Playerpos.x = minX;
        }
        transform.position = Playerpos;
       // rb.AddForce(0, 0, ff*Time.deltaTime);
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            // rb.AddForce(500 * Time.deltaTime, 0, 0);
            transform.position += new Vector3(speed* Time.deltaTime, 0, 0);
        }
         else if (Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= new Vector3(speed* Time.deltaTime, 0, 0);
        }
        //rb.AddForce(0, 0, ff * Time.deltaTime);
    }
    private void FixedUpdate()
    {
        rb.AddForce(0, 0, ff * Time.deltaTime);
    }
}
