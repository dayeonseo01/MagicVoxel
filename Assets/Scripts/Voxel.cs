using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voxel : MonoBehaviour
{
    //속도 속성
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        //랜덤방향
        Vector3 direction = Random.insideUnitSphere;
        //날아가는 속도를 준다
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
    }

    //복셀 제거 시간
    public float destoryTime = 3.0f;
    //경과시간
    float currentTime;
    // Update is called once per frame
    void Update()
    {
        //일정시간이 지나면 제거
        //시간 흐름
        currentTime += Time.deltaTime;
        //제거 완
        //만약 경과 시간이 제거시간을 초과
        if(currentTime > destoryTime)
        {
            //복셀 제거
            Destroy(gameObject);
        }
    }
}
