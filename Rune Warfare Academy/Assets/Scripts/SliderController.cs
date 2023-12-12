using UnityEngine;
using UnityEngine.UI;

public class SliderController : MonoBehaviour
{
    [SerializeField] private string settingsName;
    [SerializeField] private Slider slider;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat(settingsName);
    }

    public void SaveFloat() 
    {
        PlayerPrefs.SetFloat(settingsName, slider.value);
        Debug.Log(PlayerPrefs.GetFloat(settingsName));
    }
}
