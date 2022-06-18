
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;


public class Meteour : UdonSharpBehaviour
{
    public GameObject MeteourPrefab;
   

    //時間間隔の最小値
    public float minTime = 2f;
    //時間間隔の最大値
    public float maxTime = 5f;

    public float xMinPosition = -10f;
    public float xMaxPosition = 10f;
    public float yMinPosition = 0f;
    public float yMaxPosition = 10f;
    public float zMinPosition = 10f;
    public float zMaxPosition = 20f;
    //敵生成時間間隔
    private float interval;
    //経過時間
    private float time = 0f;





    void Start()
    {
        interval = GetRandomTime();
    }

    void Update()
    {
        time += Time.deltaTime;
        if (time > interval)
        {
            //enemyをインスタンス化する(生成する)
            GameObject Meteour = VRCInstantiate(MeteourPrefab);
            //生成した敵の座標を決定する(現状X=0,Y=10,Z=20の位置に出力)
           Meteour.transform.position = GetRandomPosition();
            //経過時間を初期化して再度時間計測を始める
            time = 0f;
            interval = GetRandomTime();
        }
    }
    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }
    private Vector3 GetRandomPosition()
    {
        //それぞれの座標をランダムに生成する
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);
        float z = Random.Range(zMinPosition, zMaxPosition);

        //Vector3型のPositionを返す
        return new Vector3(x, y, z);
    }
}