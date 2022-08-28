using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteControl : MonoBehaviour
{
    float rotSpeed = 0; // ȸ���ӵ�
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float init = 0.0f;
        //Ŭ���ϸ� ȸ���Ѵ�.
        if (Input.GetMouseButtonDown(0))
        {
            init = gameObject.transform.eulerAngles.z;
            rotSpeed = 10;
        }
        rotSpeed *= 0.96f;
        //ȸ�� �ӵ���ŭ �귿�� ȸ����Ų��.
        gameObject.transform.Rotate(0, 0, rotSpeed);
        float end = gameObject.transform.eulerAngles.z;

        Debug.Log(init);
        Debug.Log(end);


        float distance = end - init;
        if(rotSpeed < 0.01)
        {
            if (distance > -30 || distance <= 30)
            {
                Debug.Log("�������");
            }
            else if (distance > 30 || distance <= 90)
            {
                Debug.Log("�������");
            }
            else if (distance > 90 || distance <= 150)
            {
                Debug.Log("����ſ쳪��");
            }
            else if (distance > 150 || distance <= 210)
            {
                Debug.Log("�������");
            }
            else if (distance > 210 || distance <= 270)
            {
                Debug.Log("�������");
            }
            else if (distance > 270 || distance <= 360)
            {
                Debug.Log("�������");
            }
        }
    }

}
