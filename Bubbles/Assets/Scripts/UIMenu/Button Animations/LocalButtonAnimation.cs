using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalButtonAnimation : MonoBehaviour
{
    [SerializeField] private Button button;
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        button.onClick.AddListener(ClickAnimation);
    }

    public void ClickAnimation()
    {
        animator.SetTrigger("IsClicked");
    }
}
