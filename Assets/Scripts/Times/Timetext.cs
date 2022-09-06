using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timetext : MonoBehaviour
{
    GameObject timerText;
    float time = 180.0f;
    // Start is called before the first frame update
    void Start()
    {
        this.timerText = GameObject.Find("Time");
    }

    // Update is called once per frame
    void Update()
    {
        this.time -= Time.deltaTime;
        if (time > 0.0f)
        {
            GetComponent<Text>().text = this.time.ToString("F1");
        }
        else
        {
            this.time = 0f;
            GetComponent<Text>().text = this.time.ToString("F1");
        }
    }
}
