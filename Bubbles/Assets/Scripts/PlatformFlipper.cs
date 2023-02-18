using UnityEngine;
using UnityEngine.Serialization;

public class PlatformFlipper : MonoBehaviour
{
    [SerializeField] private GameObject balls;
    [SerializeField] private VoidEventChannelSO refreshClickCounterEventChannelSo;
    private int _inActiveChildrenCount;
    private int _childrenCount;
    private Animation _rotateAnimation;

    void Start()
    {
        _rotateAnimation = GetComponent<Animation>();
        _childrenCount = balls.transform.childCount;
    }
    
    void Update()
    {
        if (_childrenCount != _inActiveChildrenCount) return;
  
        FlipPlatform();
    }

    public void UpdateUnActiveChildrenCount()
    {
        _inActiveChildrenCount += 1;
        Debug.Log(_inActiveChildrenCount);
    }

    private void FlipPlatform()
    {
        _rotateAnimation.Play();
        refreshClickCounterEventChannelSo.RaiseEvent();
        _inActiveChildrenCount = 0;
    }
}
