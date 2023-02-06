using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(menuName = "Events/Level data Event Channel")]
public class LevelDataEventChanelSO : SerializableBaseSO
{
    public UnityAction<LevelData> OnEventRaised;
	
    public void RaiseEvent(LevelData value)
    {
        if (OnEventRaised != null)
        {
            OnEventRaised.Invoke(value);
        }
    }
}
