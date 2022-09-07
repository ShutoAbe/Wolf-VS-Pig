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

<<<<<<< HEAD
    bool isKey = false;
    bool isKeyDown = false;
    bool sss = true;
=======

    int State = 0;
    //State‚ª 0‚Ì‚Æ‚«Left/1‚Ì‚Æ‚«Top/2‚Ì‚Æ‚«Right



>>>>>>> bb9b4aba544944e8f307c0d5731317b417519604
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.LeftArrow))
        {
<<<<<<< HEAD
            sss = false;
            isKey = true;
            Debug.Log("f");
=======
            State = 0;
>>>>>>> bb9b4aba544944e8f307c0d5731317b417519604
        }
        if(Input.GetKeyUp(KeyCode.UpArrow))
        {
<<<<<<< HEAD
            isKeyDown = true;
            
=======
            State = 1;
>>>>>>> bb9b4aba544944e8f307c0d5731317b417519604
        }
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            State = 2;
        }
        if (Input.GetKeyUp(KeyCode.Space) && State == 0 )
        {

<<<<<<< HEAD
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
=======
            Wall.GetComponent<Wall>().Damaged();
           
            Debug.Log("a");
>>>>>>> bb9b4aba544944e8f307c0d5731317b417519604
        }
        if (Input.GetKeyUp(KeyCode.Space) && State == 1)
        {
<<<<<<< HEAD
            isKey = false;
            Wall.GetComponent<wall2>().Damaged();
=======
            
            Roof.GetComponent<Roof>().Damaged();
            Debug.Log("b");
        }
        if (Input.GetKeyUp(KeyCode.Space) && State == 2)
        {
            Wall2.GetComponent<Wall2>().Damaged();
>>>>>>> bb9b4aba544944e8f307c0d5731317b417519604
            Debug.Log("c");
        }
    }

    
}
