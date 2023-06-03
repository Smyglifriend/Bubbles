using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    [SerializeField] private Sprite soundOnSprite;
    [SerializeField] private Sprite soundOffSprite;
    [SerializeField] private AudioSource audioSource;

    private Image _imageComp;
    private int _buttonId;


    void Start()
    {
        _imageComp = gameObject.GetComponent<Image>();
        _buttonId = PlayerPrefs.GetInt("ButtonKey", 0);
        SetFlag();
    }

    public void ChangeFlag()
    {
        _buttonId += 1;
        SetFlag();
    }

    private void SetFlag()
    {
        if (_buttonId == 1)
        {
            _imageComp.sprite = soundOnSprite;
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
            _imageComp.sprite = soundOffSprite;
            _buttonId = 0;
        }
        PlayerPrefs.SetInt("ButtonKey", _buttonId);
    }
}
