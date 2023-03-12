using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private LevelDataEventChanelSO chooseButtonlevelDataEventChanelSo;
    [SerializeField] private LevelData defaultLevel;

    private LevelData _level;
    private GameObject _levelPrefab;
    private Vector3 _spawnPopItPosition = new(-0.3f, -0.5f, -2.1f);
    private Vector3 _spawnBubblePosition = new(-0.3f, 1.0f, -3f);
    private Vector3 _spawnSoapBallsPosition = new(-0.4f, 1.0f, -7f);


    private void Start()
    {
        chooseButtonlevelDataEventChanelSo.RaiseEvent(defaultLevel);
        SetLevel(defaultLevel);
    }

    public void SetLevel(LevelData levelData)
    {
        _level = levelData;
    }

    public void GenerateLevel()
    {
        switch (_level.LevelName)
        {
            case "Bubble":
                InstantiateBubbleLevel();
                break;
            case "Pop It":
                InstantiatePopItLevel();
                break;
            case "Soap balls":
                InstantiateSoapBallsLevel();
                break;
            default:
                Debug.Log("Level not found");
                break;
        }
    }

    public void HideLevel()
    {
        if (!_levelPrefab.activeSelf) return;
        
        _levelPrefab.SetActive(false);
    }
    
    public void ShowLevel()
    {
        if (_levelPrefab.activeSelf) return;
        
        _levelPrefab.SetActive(true);;
    }

    public void DestroyLevel()
    {
        Destroy(_levelPrefab);
    }
    

    private void InstantiateBubbleLevel()
    {
        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnBubblePosition, Quaternion.Euler(-180f, 0, 0), transform);
    }

    private void InstantiatePopItLevel()
    {
        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnPopItPosition, Quaternion.Euler(-50f, 0, 0), transform);
    }

    private void InstantiateSoapBallsLevel()
    {
        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnSoapBallsPosition, Quaternion.identity);
    }
}
