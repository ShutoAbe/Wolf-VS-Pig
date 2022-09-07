using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pig : MonoBehaviour
{
    [SerializeField]
    public float increase = 3;
    public GameObject Wall;
    public GameObject Roof;
    public GameObject Wall2;

    bool isKey = false;
    bool isKeyDown = false;
    bool isKeyUp = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyUp(KeyCode.Return))
        {
            isKeyUp = true;  
            isKey = true;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isKeyDown = true;
          
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" && isKeyUp)
        {
            isKeyUp = false;
            Wall.GetComponent<Wall>().recovery();
            
        }
        if (collision.gameObject.tag == "Roof" && isKeyDown)
        {
            isKeyDown = false;
            Roof.GetComponent<Roof>().recovery();
       
        }
        if (collision.gameObject.tag == "Wall2" && isKey)
        {
            isKey = false;
            Wall.GetComponent<Wall2>().recovery();

        }
    }
}
