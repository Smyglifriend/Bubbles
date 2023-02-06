using UnityEngine;

public class PlayButton : MonoBehaviour
{
    [SerializeField] private LevelDataEventChanelSO levelDataEventChanelSo;
    [SerializeField] private LevelData levelData;
    
    public void ButtonClick()
    {
        levelDataEventChanelSo.RaiseEvent(levelData);
    }
}
