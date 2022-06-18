
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class Hit : UdonSharpBehaviour
{
    [SerializeField] private GameObject ParticleSystemPrefab;
    [SerializeField] private MeshRenderer mesh;
    [SerializeField] private MeshCollider meshcollider;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name != "Plane") //Objectタグの付いたゲームオブジェクトと衝突したか判別
        {
            return;
        }
        else
        {
            Explosion();
         
        }
    }
    private void Explosion()
    {
        mesh.enabled = false;
        meshcollider.enabled = false;
        GameObject ParticleSystem = VRCInstantiate(ParticleSystemPrefab);
        ParticleSystem.transform.parent = this.gameObject.transform;
        ParticleSystem.transform.localPosition = Vector3.zero;

    }
}