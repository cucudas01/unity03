using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag; 
    TextMeshProUGUI distanceText;

    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        GameObject distance = GameObject.Find("distance");

        // TextMeshProUGUI 컴포넌트를 가져옵니다.
        if (distance != null)
        {
            this.distanceText = distance.GetComponent<TextMeshProUGUI>();
            if (this.distanceText == null)
            {
                Debug.LogError("distance 오브젝트에 TextMeshProUGUI 컴포넌트가 없습니다.");
            }
        }
        else
        {
            Debug.LogError("distance 오브젝트를 찾을 수 없습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (this.car != null && this.flag != null && this.distanceText != null)
        {
            float length = this.flag.transform.position.x - this.car.transform.position.x;
            this.distanceText.text = "Distance: " + length.ToString("F2") + "m";
        }
    }
}