using UnityEngine;
using System.Collections;

public class Cube : MonoBehaviour
{
    public float speed;

    float AD;

    float WS;

    void Update()
    {
        AD = Input.GetAxis("Horizontal");//����

        WS = Input.GetAxis("Vertical"); //����

        this.gameObject.transform.Translate(new Vector3(AD * speed, 0, WS * speed));

    }//һ�仰����ƶ�����(����ֻ��������Ϸ�����ǰ�������ƶ�)  ��������Ǵ���ķ���
}


