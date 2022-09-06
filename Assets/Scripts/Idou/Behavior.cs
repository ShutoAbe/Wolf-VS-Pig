using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Behavior : MonoBehaviour
{
    Rigidbody2D rigid2D;
    float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
    }

    // •¨—‰‰Z‚ğ‚µ‚½‚¢ê‡‚ÍFixedUpdate‚ğg‚¤‚Ì‚ªˆê”Ê“I
    void Update()
    {
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        float speedx = Mathf.Abs(this.rigid2D.velocity.x);

        if(speedx < this.maxWalkSpeed)
        {
            this.rigid2D.AddForce(transform.right * key * this.walkForce);
        }

        if (key != 0)
        {
            transform.localScale = new Vector3(key, 1, 1);
        }
    }
}
