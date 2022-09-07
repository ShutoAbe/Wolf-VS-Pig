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
    public GameObject Wall2;

    bool isKey = false;
    bool isKeyDown = false;
    bool sss = true;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            sss = false;
            isKey = true;
            Debug.Log("f");
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isKeyDown = true;
            
        }
        
    }

    public void OnTriggerStay2D(Collider2D collision)
    {
      
        if((collision.gameObject.tag == "Wall") && sss == false)
        {   
            
            Wall.GetComponent<wall>().Damaged();
            sss = true;
            Debug.Log("a");
        }
        if (collision.gameObject.tag == "Roof" && isKeyDown)
        { 
            isKeyDown = false;
            Roof.GetComponent<roof>().Damaged();
            Debug.Log("b");
        }
        if (collision.gameObject.tag == "Wall2" && isKey)
        {
            isKey = false;
            Wall.GetComponent<wall2>().Damaged();
            Debug.Log("c");
        }
    }
}
