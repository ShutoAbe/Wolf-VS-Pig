using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class roof : MonoBehaviour
{

    [SerializeField]
    public float  Durablevalue;
    public GameObject Player;
    public GameObject Roof;
    public Sprite RoofSp;
    public Sprite RoofSp2;
    public Sprite RoofSp3;
    public Sprite RoofSp4;


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
        if (Durablevalue == 100)
        {
            Roof.GetComponent<SpriteRenderer>().sprite = RoofSp3;
        }
        if (Durablevalue < 100)
        {
            Roof.GetComponent<SpriteRenderer>().sprite = RoofSp;
        }
        if (Durablevalue < 49)
        {
            Roof.GetComponent<SpriteRenderer>().sprite = RoofSp2;
        }
        if(Durablevalue <= 0)
        {
            Roof.GetComponent<SpriteRenderer>().sprite = RoofSp4;
        }
    }
}

