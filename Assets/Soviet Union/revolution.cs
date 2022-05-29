
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class revolution : UdonSharpBehaviour
{

    void Update()
    {
        transform.Rotate(new Vector3(0.01f, 0, 0));
    }
}
