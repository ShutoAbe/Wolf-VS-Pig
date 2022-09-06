using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pig : MonoBehaviour
{
    [SerializeField]
    public GameObject Wall;

    float Durablevalue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Durablevalue = Wall.GetComponent<wall>().Durablevalue;
        if (Input.GetKeyDown(KeyCode.Return) && Durablevalue < 100)
        {
            Durablevalue += 3;
        }
    }
}
