using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wall : MonoBehaviour
{
    [SerializeField]
    public float  Durablevalue;
    public GameObject Player;
    float increase;
    float reduce;
    private Rigidbody2D rigidBody;
    // Start is called before the first frame update


    void Update()
    {
        if(Durablevalue <= 0)
        {
            gameObject.SetActive(false);
        }
        if (Durablevalue > 100)
        {
            Durablevalue = 100;
        }
        Debug.Log(Durablevalue);

    }

    public float Damaged()
    { 
        reduce = Player.GetComponent<wolf>().reduce;
        if (Durablevalue > 0)
        {
            Durablevalue += reduce;
        }
        return Durablevalue;
    }
    public float recovery()
    {
        increase = Player.GetComponent<pig>().increase;
        Durablevalue += increase;
       
        return increase;
    }
    

}
