using UnityEngine;

public class PlatformFlipper : MonoBehaviour
{
    [SerializeField] private VoidEventChannelSO flipPlatformCounterEventChannelSo;
    [SerializeField] private GameObject model;

    [SerializeField] private GameObject balls;
    [SerializeField] private GameObject balls2;


    private Animation _rotateAnimation;
    private int _inactiveChildrenCount;
    private int _childrenCount = 30;
    private bool _isFlipped;
    private bool _isFirstFlip;
    

    void Start()
    {
        balls2.SetActive(false);
        _isFirstFlip = true;
        _rotateAnimation = model.gameObject.GetComponent<Animation>();
    }
    
    void Update()
    {
        if (_childrenCount != _inactiveChildrenCount) return;
  
        FlipPlatform();
    }

    public void UpdateInactiveChildrenCount()
    {
        _inactiveChildrenCount += 1;
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
        if (_isFirstFlip)
        {
            balls2.SetActive(true);
            balls.SetActive(false);
            _isFirstFlip = false;
        }
        else
        {
            balls2.SetActive(false);
            balls.SetActive(true);
            _isFirstFlip = true;
        }
        
        flipPlatformCounterEventChannelSo.RaiseEvent();
    }
}
