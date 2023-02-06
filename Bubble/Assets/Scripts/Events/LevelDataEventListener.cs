using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LevelDataEventListener : MonoBehaviour
{
    [SerializeField] private LevelDataEventChanelSO _channel;

    public UnityEvent<LevelData> OnEventRaised;

    private void OnEnable()
    {
        if (_channel != null)
            _channel.OnEventRaised += Respond;
    }

    private void OnDisable()
    {
        if (_channel != null)
            _channel.OnEventRaised -= Respond;
    }

    private void Respond(LevelData value)
    {
        if (OnEventRaised != null)
            OnEventRaised.Invoke(value);
    }
}
