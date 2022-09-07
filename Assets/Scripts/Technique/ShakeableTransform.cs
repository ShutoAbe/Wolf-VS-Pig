using System;
using UnityEngine;

public class ShakeableTransform : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gameObject.GetComponent<Cinemachine.CinemachineImpulseSource>().GenerateImpulse();
        }
    }    
}