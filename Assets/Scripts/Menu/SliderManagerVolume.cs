using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderManagerVolume : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = GameManager.Instance.CommonVolume;
        Debug.Log(GameManager.Instance.CommonVolume);
    }

    public void VolumeChange()
    {
        GameManager.Instance.CommonVolume = volumeSlider.value;
        Debug.Log(GameManager.Instance.CommonVolume);

    }
}
