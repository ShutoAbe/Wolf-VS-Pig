using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wolf : MonoBehaviour
{
    [SerializeField]
    public float reduce = -5f;
    public GameObject Wall;
    public GameObject Roof;

    bool isKeyDown = false;
    bool isKeyUp = false;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            isKeyUp = true;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isKeyDown = true;
        }
    }

    public void OnTriggerStay2D(Collider2D collision)
    { 
        if (collision.gameObject.tag == "Wall"&& isKeyUp)
        {   
            isKeyUp = false;
            Wall.GetComponent<wall>().Damaged();
            
            
        }
        if (collision.gameObject.tag == "Roof" && isKeyDown)
        { 
            isKeyDown = false;
            Roof.GetComponent<roof>().Damaged();
           
        }
        if (collision.gameObject.tag == "Wall2" && isKeyUp)
        {
            isKeyUp = false;
            Wall.GetComponent<wall>().Damaged();


        }
    }
}
