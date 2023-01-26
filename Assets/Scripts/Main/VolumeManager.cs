using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class VolumeManager : MonoBehaviour
{
    [SerializeField] List<AudioSource> _audSources = new();

    private void Start()
    {
        Debug.Log(GameManager.Instance.CommonVolume);
    }
    void FixedUpdate()
    {

        if (_audSources[0].volume != GameManager.Instance.CommonVolume)
        {
            foreach (var _as in _audSources)
            {
                _as.volume = GameManager.Instance.CommonVolume;
            }
        }  
    }
}
