using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Wall : MonoBehaviour
{
    
    [SerializeField]
    public float  Durablevalue;
    public GameObject Player;
    public GameObject wall;
    public Sprite WallSp;
    public Sprite WallSp2;
    public Sprite WallSp3;
    public Sprite WallSp4;

    float increase;
    float reduce;
    private Rigidbody2D rigidBody;
    
    


    // Start is called before the first frame update


    void Update()
    {
        SpriteChange();
        if (Durablevalue > 100)
        {
            Durablevalue = 100;
        }
        Debug.Log(Durablevalue);

     
    }

    public float Damaged()
    {
        
<<<<<<< HEAD
        reduce = Player.GetComponent<wolf>().reduce;
=======
        reduce = Player.GetComponent<Wolf>().reduce;
>>>>>>> bb9b4aba544944e8f307c0d5731317b417519604
        if (Durablevalue > 0)
        {
            Durablevalue += reduce;
          
        }
        return Durablevalue;
    }
    public float recovery()
    {
        increase = Player.GetComponent<Pig>().increase;
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
            wall.GetComponent<SpriteRenderer>().sprite = WallSp3;
        }
        if (Durablevalue < 100)
        {
            wall.GetComponent<SpriteRenderer>().sprite = WallSp;
        }
        if(Durablevalue < 49)
        {
            wall.GetComponent <SpriteRenderer>().sprite = WallSp2;
        }
        if(Durablevalue <= 0)
        {
            wall.GetComponent<SpriteRenderer>().sprite = WallSp4;
        }
    }

}
