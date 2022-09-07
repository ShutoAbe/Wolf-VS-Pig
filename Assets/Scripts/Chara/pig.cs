using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
    [SerializeField]
    public float increase = 3;
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
        if (Input.GetKeyDown(KeyCode.Return))
        {
            isKeyUp = true;
        }
        if (Input.GetKeyUp(KeyCode.Return))
        {
            isKeyDown = true;
        }
    }
    public void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall" && isKeyUp)
        {
            isKeyUp = false;
            Wall.GetComponent<wall>().recovery();
            
        }
        if (collision.gameObject.tag == "Roof" && isKeyDown)
        {
            isKeyDown = false;
            Roof.GetComponent<roof>().recovery();
       
        }
        if (collision.gameObject.tag == "Wall2" && isKeyUp)
        {
            isKeyUp = false;
            Wall.GetComponent<wall>().recovery();

        }
    }
}
