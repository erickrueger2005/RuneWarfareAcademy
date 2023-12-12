using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class sliderText : MonoBehaviour
{
    public TMP_Text sliderValue;
    public Slider slider;

    private void Start()
    {
        sliderValue = GetComponent<TMP_Text>();
    }

    void Update()
    {
        sliderValue.text = slider.value.ToString("0");
    }
}
