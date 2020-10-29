using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    Transform _second, _minute, _hour;
    private void Awake()
    {
        _second = transform.Find("secondHand");
        _minute = transform.Find("minHand");
        _hour = transform.Find("hourHand");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
