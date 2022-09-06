using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class wall : MonoBehaviour
{
    
    [SerializeField]
    public float  Durablevalue;
    public GameObject Player;
    public GameObject Wall;
    public Sprite WallSp;
    public Sprite WallSp2;
    public Sprite WallSp3;

    float increase;
    float reduce;
    private Rigidbody2D rigidBody;
    
    


    // Start is called before the first frame update


    void Update()
    {
        SpriteChange();
        if (Durablevalue <= 0)
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
        if (increase < 100)
        {
            Durablevalue += increase;
        }
        return increase;
    }
    public void SpriteChange()
    {
        if(Durablevalue == 100)
        {
            Wall.GetComponent<SpriteRenderer>().sprite = WallSp3;
        }
        if (Durablevalue < 100)
        {
            Wall.GetComponent<SpriteRenderer>().sprite = WallSp;
        }
        if(Durablevalue < 49)
        {
            Wall.GetComponent <SpriteRenderer>().sprite = WallSp2;
        }
    }

}