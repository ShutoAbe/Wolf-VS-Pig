using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    //�Q�[���I��:�{�^������Ăяo��
    public void Game()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//�Q�[���v���C�I��
#else
    Application.Quit();//�Q�[���v���C�I��
#endif
    }
}