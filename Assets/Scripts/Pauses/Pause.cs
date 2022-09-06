using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    //ポーズしている間表示するゲームオブジェクト　増減もできる
    [SerializeField] GameObject PauseObject1;
    [SerializeField] GameObject PauseObject2;
    [SerializeField] GameObject PauseObject3;
    [SerializeField] GameObject PauseObject4;
    [SerializeField] GameObject PauseObject5;
    bool pausable = true;   //ポーズの使用ができるか
    bool pausing = false;   //ポーズしているか
    float pauselift_wait = 0;

    void Awake()
    {
        Time.timeScale = 1.0f;
        pausing = false;
    }

    void Update()
    {
        // ポーズができる状態でPキーが押されたら
        if (Input.GetKeyDown(KeyCode.P) && pausable == true)
        {
            if (pausing == false)
            {
                //ポーズする
                pausing = true;
                Time.timeScale = 0;
            }
            else
            {
                //ポーズを解除する
                pausing = false;
                Time.timeScale = 1;
            }
        }

        //ポーズ状態を反映
        PauseObject1.SetActive(pausing);
        PauseObject2.SetActive(pausing);
        PauseObject3.SetActive(pausing);
        PauseObject4.SetActive(pausing);
        PauseObject5.SetActive(pausing);


        pauselift_wait += Time.unscaledDeltaTime;
    }
}