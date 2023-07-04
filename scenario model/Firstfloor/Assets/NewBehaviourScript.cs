using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
    public float speed;

    float AD;

    float WS;

    void Update()
    {
        AD = Input.GetAxis("Horizontal");//横轴

        WS = Input.GetAxis("Vertical"); //纵轴

        this.gameObject.transform.Translate(new Vector3(AD * speed, 0, WS * speed));

    }//一句话完成移动控制(这里只管我们游戏对象的前后左右移动)  里边是我们传入的方向
}


