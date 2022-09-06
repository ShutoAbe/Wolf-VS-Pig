using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
    [SerializeField]
    public float increase = 3;
    public GameObject Wall;
    public GameObject Roof;
    
    
    bool isKeyUp = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isKeyUp = true;
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" && isKeyUp)
        {
            isKeyUp = false;
            Wall.GetComponent<wall>().recovery();
            
        }
        else if (collision.gameObject.tag == "Roof" && isKeyUp)
        {
            isKeyUp = false;
            Roof.GetComponent<wall>().recovery();
       
        }
    }
}
