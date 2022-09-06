using System;
using UnityEngine;

public class ShakeableTransform : MonoBehaviour
{
    public ShakeableTransform m_shakeable;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_shakeable.InduceStress(1);
        }
    }

    private void InduceStress(int v)
    {
        throw new NotImplementedException();
    }
}