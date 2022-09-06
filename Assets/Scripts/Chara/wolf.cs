using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wolf : MonoBehaviour
{
    [SerializeField]
    public float reduce = -5f;
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
            if (Input.GetKeyUp(KeyCode.Space))
            {

                Wall.GetComponent<wall>().Damaged();
                Debug.Log("1");
            }

        }
    }
}
