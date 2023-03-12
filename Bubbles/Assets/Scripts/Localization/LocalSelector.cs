using System.Collections;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class LocalSelector : MonoBehaviour
{
    private bool active = false;
    private int _id;


    private void Start()
    {
        _id = PlayerPrefs.GetInt("LocalKey", 0);
        ChangeLocale();
    }

    public void ChangeLocale()
    {
        if (active == true) return;
        if (_id > 1) _id = 0;
        StartCoroutine(SetLocale(_id));
        _id += 1;
    }
     
    IEnumerator SetLocale(int localId)
    {
        active= true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[localId];
        PlayerPrefs.SetInt("LocalKey", localId);
        active= false;
    }
}
