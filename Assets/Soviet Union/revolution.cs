
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class revolution : UdonSharpBehaviour
{

    void Update()
    {
        transform.Rotate(0, -0.01f, 0);
    }
}
