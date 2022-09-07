using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ookami : MonoBehaviour
{
    public GameObject ookami;
    Rigidbody2D rigid2D;
    //float walkForce = 30.0f;
    //float maxWalkSpeed = 2.0f;
    //Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.position = new Vector3(4, -3, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.position = new Vector3(-4, -3, 0);
        }
        if (Input.GetKey("up"))
        {
            transform.position = new Vector3(0, 0.8f, 0);
        }

    }
}
