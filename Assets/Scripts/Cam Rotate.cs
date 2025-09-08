using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //현재각도
    Vector3 angle;
    //마우스감도
    public float sensitivity = 200;
    // Start is called before the first frame update
    void Start()
    {
        //시작할 때 현재 카메라의 각도를 적용한다.
        angle = Camera.main.transform.eulerAngles;
        angle.x *= -1; //앵글의 반대편 그래서 -1을 곱해줌
    }

    // Update is called once per frame
    void Update()
    {
        //마우스정보입력
        float x = Input.GetAxis("Mouse Y");
        float y = Input.GetAxis("Mouse X");
        //방향확인
        angle.x += x * sensitivity * Time.deltaTime;
        angle.y += y * sensitivity * Time.deltaTime;

        angle.x = Mathf.Clamp(angle.x, -90, 90); //제한조건
        //회전
        transform.eulerAngles = new Vector3(-angle.x, angle.y, transform.eulerAngles.z);
    }
}
