using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    [SerializeField] string scene_name;

    public void ClickCalled()
    {
        SceneManager.LoadScene(scene_name); //文字列型変数scene_nameに入力された名前のシーンへ移動する
    }
}
