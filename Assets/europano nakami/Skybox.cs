
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Skybox : UdonSharpBehaviour
{
    [Range(0.003f, 0.1f)]
    public float rotateSpeed;

    public Material sky;

    float rotationRepeatValue;
    void Update()
    {
        rotationRepeatValue = Mathf.Repeat(sky.GetFloat("_Rotation") + rotateSpeed, 360f);

        sky.SetFloat("_Rotation", rotationRepeatValue);


    }
}
