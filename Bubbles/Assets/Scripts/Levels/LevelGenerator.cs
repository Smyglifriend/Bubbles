using NaughtyAttributes.Test;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal.Internal;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private LevelDataEventChanelSO chooseButtonlevelDataEventChanelSo;
    [SerializeField] private LevelData defaultLevel;

    private LevelData _level;
    private GameObject _levelPrefab;
    private Vector3 _spawnBubblePosition = new(0f, -0.6f, 7.6f);
    private Vector3 _spawnPopItPosition = new(0f, -1.4f, 8.5f);
    private Vector3 _spawnSoapBallsPosition = new(0f, 0f, 14f);


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
        
        _levelPrefab.SetActive(true);
    }

    public void DestroyLevel()
    {
        Destroy(_levelPrefab);
    }
    

    private void InstantiateBubbleLevel()
    {
        if (Screen.height <= 800 && Screen.width <= 480)
        {
            SetCameraPostion(new Vector3(0f, 0f, 0f));
        }
        else if (Screen.height <= 2160 && Screen.width <= 1080)
        {
            SetCameraPostion(new Vector3(0f, 0f, -2f));
        }
        else if (Screen.height <= 2340 && Screen.width <= 1080)
        {
            SetCameraPostion(new Vector3(0f, 0f, -3f));
        }
        else if (Screen.height <= 1080 && Screen.width <= 2160)
        {
            SetCameraPostion(new Vector3(0f, 0f, 2f));
        }
        else if (Screen.height <= 1080 && Screen.width <= 2340)
        {
            SetCameraPostion(new Vector3(0f, -1f, 3f));
        }
        else if (Screen.height <= 1440 && Screen.width <= 2960)
        {
            SetCameraPostion(new Vector3(0f, -1f, 3f));
        }

        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnBubblePosition, Quaternion.Euler(-180f, 0, 0), transform);
    }

    private void InstantiatePopItLevel()
    {
        if (Screen.height <= 2340 && Screen.width <= 1080)
        {
            SetCameraPostion(new Vector3(0f, 0f, -1.43f));
        }
        else if (Screen.height <= 1080 && Screen.width <= 2340)
        {
            SetCameraPostion(new Vector3(0f, -0.3f, 1.42f));
        }

        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnPopItPosition, Quaternion.Euler(0, 0, 0), transform);
    }

    private void InstantiateSoapBallsLevel()
    {
        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnSoapBallsPosition, Quaternion.identity, transform);
    }

    private void SetCameraPostion(Vector3 position)
    {
        Camera.main.transform.position = position;
    }
}
