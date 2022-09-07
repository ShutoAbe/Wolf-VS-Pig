using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Wolf : MonoBehaviour
{
    [SerializeField]
    public float reduce = -5f;
    public GameObject Wall;
    public GameObject Roof;
    public GameObject Wall2;


    int State = 0;
    //State‚ª 0‚Ì‚Æ‚«Left/1‚Ì‚Æ‚«Top/2‚Ì‚Æ‚«Right



    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
            State = 0;
        }
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            State = 1;
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            State = 2;
        }
        if (Input.GetKeyUp(KeyCode.Space) && State == 0 )
        {

            Wall.GetComponent<Wall>().Damaged();
           
            Debug.Log("a");
        }
        if (Input.GetKeyUp(KeyCode.Space) && State == 1)
        {
            
            Roof.GetComponent<Roof>().Damaged();
            Debug.Log("b");
        }
        if (Input.GetKeyUp(KeyCode.Space) && State == 2)
        {
            Wall2.GetComponent<Wall2>().Damaged();
            Debug.Log("c");
        }
    }

    
}
