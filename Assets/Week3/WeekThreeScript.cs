using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeekThreeScript : MonoBehaviour
{
    public Slider lerpSliders;
    public Slider moveTowards;
    public Slider pingPongSlider;
    public Slider RepeatSlider;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Siders();
    }
    void Siders()
    {
        lerpSliders.value = Mathf.Lerp(lerpSliders.value, lerpSliders.maxValue, speed * Time.deltaTime);
        moveTowards.value = Mathf.MoveTowards(moveTowards.value, moveTowards.maxValue, speed * Time.deltaTime);
        pingPongSlider.value = Mathf.PingPong(speed * Time.time, pingPongSlider.maxValue);
        RepeatSlider.value = Mathf.Repeat(speed * Time.time, RepeatSlider.maxValue);
    }
}


