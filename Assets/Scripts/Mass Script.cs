using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MassScript : MonoBehaviour
{
    public Slider scaleSlider;
    private float scaleSliderNumber;



    // Update is called once per frame
    void Update()
    {
        scaleSliderNumber = scaleSlider.value / 45.0f;
        Vector2 scale = new Vector2(scaleSliderNumber, scaleSliderNumber);
        this.transform.localScale = scale;
    }
}
