using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MassTitleScript : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private TextMeshProUGUI _sliderText;

    void Start()

    {
        _slider.onValueChanged.AddListener((v) =>
        {
            _sliderText.text = v.ToString("0.0");
        });

    }

    // Update is called once per frame
    void Update()
    {

    }
}
