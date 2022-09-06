using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    //�|�[�Y���Ă���ԕ\������Q�[���I�u�W�F�N�g�@�������ł���
    [SerializeField] GameObject PauseObject1;
    [SerializeField] GameObject PauseObject2;
    [SerializeField] GameObject PauseObject3;
    [SerializeField] GameObject PauseObject4;
    [SerializeField] GameObject PauseObject5;
    bool pausable = true;   //�|�[�Y�̎g�p���ł��邩
    bool pausing = false;   //�|�[�Y���Ă��邩
    float pauselift_wait = 0;

    void Awake()
    {
        Time.timeScale = 1.0f;
        pausing = false;
    }

    void Update()
    {
        // �|�[�Y���ł����Ԃ�P�L�[�������ꂽ��
        if (Input.GetKeyDown(KeyCode.P) && pausable == true)
        {
            if (pausing == false)
            {
                //�|�[�Y����
                pausing = true;
                Time.timeScale = 0;
            }
            else
            {
                //�|�[�Y����������
                pausing = false;
                Time.timeScale = 1;
            }
        }

        //�|�[�Y��Ԃ𔽉f
        PauseObject1.SetActive(pausing);
        PauseObject2.SetActive(pausing);
        PauseObject3.SetActive(pausing);
        PauseObject4.SetActive(pausing);
        PauseObject5.SetActive(pausing);


        pauselift_wait += Time.unscaledDeltaTime;
    }
}