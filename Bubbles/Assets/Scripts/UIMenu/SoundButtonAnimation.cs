using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButtonAnimation : MonoBehaviour
{
    [SerializeField] private Button button;
    [SerializeField] private AudioSource audioSource;
    private Animator animator;

    private int _clickCount;

    private void Start()
    {
        animator = GetComponent<Animator>();
        button.onClick.AddListener(ClickAnimation);
    }

    public void ClickAnimation()
    {
        animator.SetTrigger("IsClicked");
        if (_clickCount == 0)
        {
            audioSource.Stop();
            _clickCount= 1;
        }
        else
        {
            audioSource.Play();
            _clickCount = 0;
        }
    }
}
