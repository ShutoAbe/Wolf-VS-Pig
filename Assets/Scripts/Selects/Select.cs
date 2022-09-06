using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Select : MonoBehaviour
{
    [SerializeField] string scene_name;

    public void ClickCalled()
    {
        SceneManager.LoadScene(scene_name); //•¶š—ñŒ^•Ï”scene_name‚É“ü—Í‚³‚ê‚½–¼‘O‚ÌƒV[ƒ“‚ÖˆÚ“®‚·‚é
    }
}
