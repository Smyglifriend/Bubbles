using System.Collections;
using UnityEngine;

public class LevelButtonAnimator : MonoBehaviour
{
    [SerializeField] private LevelData currentLevelData;
    [SerializeField] private float duration;
    [SerializeField] private Vector2 startScale;
    [SerializeField] private Vector2 targetScale;


    public void ChooseButton(LevelData currenButton)
    {
        if (currentLevelData.name == currenButton.name)
        {
            StartCoroutine(ZoomButton(targetScale, duration));
        }
        else
        {
            StartCoroutine(UnzoomButton(startScale, duration));
        }
    }

    IEnumerator ZoomButton(Vector2 targetScale, float duration)
    {
        var time = 0f;
        var startScale = transform.localScale;
        while (time < duration)
        {
            transform.localScale = Vector2.Lerp(startScale, targetScale, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = targetScale;
    }

    IEnumerator UnzoomButton(Vector2 targetScale, float duration)
    {
        var time = 0f;
        var startScale = transform.localScale;
        while (time < duration)
        {
            transform.localScale = Vector2.Lerp(startScale, targetScale, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.localScale = this.startScale;
    }
}
