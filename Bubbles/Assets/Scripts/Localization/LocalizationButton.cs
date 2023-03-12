using UnityEngine;
using UnityEngine.UI;

public class LocalizationButton : MonoBehaviour
{
    [SerializeField] private Sprite EnFlag;
    [SerializeField] private Sprite RuFlag;

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
            _imageComp.sprite = EnFlag;
        }
        else
        {
            _imageComp.sprite = RuFlag;
            _buttonId = 0;
        }
        PlayerPrefs.SetInt("ButtonKey", _buttonId);
    }
}
