using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // 마우스 버튼을 누른 위치 저장
            this.startPos = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0)) // 마우스 버튼을 뗀 시점
        {
            // 마우스 버튼을 뗀 위치 저장
            Vector2 endPos = Input.mousePosition;

            // 스와이프 길이 계산
            float swipeLength = endPos.x - this.startPos.x;

            // 속도 계산
            this.speed = swipeLength / 500.0f;
        }
        GetComponent<AudioSource>().Play();
        // 자동차 이동
        transform.Translate(this.speed, 0, 0);

        // 속도 감속
        this.speed *= 0.98f;
    }
}