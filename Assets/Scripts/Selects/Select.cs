using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    [SerializeField] string scene_name;

    public void ClickCalled()
    {
        SceneManager.LoadScene(scene_name); //������^�ϐ�scene_name�ɓ��͂��ꂽ���O�̃V�[���ֈړ�����
    }
}
