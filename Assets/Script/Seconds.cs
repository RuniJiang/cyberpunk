using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

//如何动态的将脚本挂到游戏物体上？

public class Seconds : MonoBehaviour
{
    

    GameObject hour,minute,second;
    const float degreeperHour = 30f;
    const float degreeperMinute = 6f;
    const float degreeperSecond = 6f;

    private void Awake()
    {
        //Debug.Log(DateTime.Now.Hour);

        //初始化钟表时间
        float extra_min = DateTime.Now.Second / 60f * degreeperMinute;
        float extra_hour = DateTime.Now.Minute / 60f * degreeperHour;
        

        hour = transform.Find("center_hour").gameObject;
        hour.transform.Rotate(new Vector3(0f, 0f, - DateTime.Now.Hour * degreeperHour - extra_hour));

        minute = transform.Find("center_min").gameObject;
        minute.transform.Rotate(new Vector3(0f, 0f, -DateTime.Now.Minute * degreeperMinute - extra_min));

        second = transform.Find("center_second").gameObject;
        second.transform.Rotate(new Vector3(0f, 0f, -DateTime.Now.Second * degreeperSecond));


    }

    private void Start()
    {
        InvokeRepeating("Continuous", 0, 1);

    }
    //int i = 0;
    void Update()
    {
        
    }
    void Continuous()
    {
        //if (Time.time - i >= 1)
        // second.transform.localEulerAngles = Vector3.Lerp(second.transform.localEulerAngles, new Vector3(0, 0, degreeperHour * 6), Time.deltaTime * 1f);

        {
            hour.transform.Rotate(new Vector3(0f, 0f, -degreeperHour / 3600));
            minute.transform.Rotate(new Vector3(0f, 0f, -degreeperMinute / 600));
            second.transform.Rotate(new Vector3(0f, 0f, -degreeperSecond));
            //i++;
        }
    }
}
