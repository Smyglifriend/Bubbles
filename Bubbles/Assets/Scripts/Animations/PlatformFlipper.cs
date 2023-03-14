using UnityEngine;

public class PlatformFlipper : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO flipPlatformCounterEventChannelSo;

    private Animation _rotateAnimation;
    private int _inactiveChildrenCount;
    private int _childrenCount = 30;
    private bool _isFlipped;
    

    void Start()
    {
        _rotateAnimation = GetComponent<Animation>();
    }
    
    void Update()
    {
        if (_childrenCount != _inactiveChildrenCount) return;
  
        FlipPlatform();
    }

    public void UpdateInactiveChildrenCount()
    {
        _inactiveChildrenCount += 1;
        Debug.Log(_inactiveChildrenCount);
    }

    private void FlipPlatform()
    {
        if (!_isFlipped)
        {
            _rotateAnimation.CrossFade("FirstFlip");
            _isFlipped = true;
        }
        else
        {
            _rotateAnimation.CrossFade("SecondFlip");
            _isFlipped = false;
        }
        
        _inactiveChildrenCount = 0;
    }

    private void RefreshItem()
    {
        flipPlatformCounterEventChannelSo.RaiseEvent();
    }
}
