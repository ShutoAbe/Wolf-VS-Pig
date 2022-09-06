using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour
{
    [SerializeField]
    public float  Durablevalue;
    public GameObject Player;

    float reduce;
    // Start is called before the first frame update


    void Update()
    {
        reduce = Player.GetComponent<wolf>().reduce;
        if(Durablevalue < 0)
        {
            Destroy(gameObject);
        }

       Debug.Log(Durablevalue);

    }


}
