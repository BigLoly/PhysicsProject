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
        // change scale according to slider
        scaleSliderNumber = scaleSlider.value * 100f;
        Vector2 scale = new Vector2(scaleSliderNumber, scaleSliderNumber);
        this.transform.localScale = scale;
        
        //change mass according to slider
    }
}
