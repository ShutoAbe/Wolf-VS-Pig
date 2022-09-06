using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
    [SerializeField]
    public float increase = 3;
    public GameObject Wall;

   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Wall.GetComponent<wall>().recovery();
            }
        }
    }
}
