using NaughtyAttributes.Test;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal.Internal;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private LevelDataEventChanelSO chooseButtonlevelDataEventChanelSo;
    [SerializeField] private LevelData defaultLevel;

    [SerializeField] private Camera camera;
    [SerializeField] private float specialValue = 1;
    [SerializeField] private float baseSpecialValue = 1;

    private void Update()
    {
        camera.fieldOfView = baseSpecialValue + (float)Screen.height / Screen.width * specialValue;
        Debug.Log((float)Screen.height / Screen.width);
    }

    private LevelData _level;
    private GameObject _levelPrefab;
    private Vector3 _spawnBubblePosition = new(0f, -0.21f, 7.6f);
    private Vector3 _spawnPopItPosition = new(0f, -0.3f, 8.5f);
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
        if ((float)Screen.height / Screen.width <= 1.2f && (float)Screen.height / Screen.width >= 1f)
        {
            specialValue = 43.34f;
        }
        else if ((float)Screen.height / Screen.width <= 1f && (float)Screen.height / Screen.width >= 0.8f)
        {
            specialValue = 56.6f;
        }
        else if ((float)Screen.height / Screen.width >= 0.5f && (float)Screen.height / Screen.width <= 0.6f)
        {
            specialValue = 79.22f;
        }
        else if ((float)Screen.height / Screen.width >= 0.6f && (float)Screen.height / Screen.width <= 0.689f)
        {
            specialValue = 67.8f;
        }
        else if ((float)Screen.height / Screen.width >= 0.7f && (float)Screen.height / Screen.width <= 0.8f)
        {
            specialValue = 60.7f;
        }
        else if ((float)Screen.height / Screen.width >= 1.2f)
        {
            specialValue = 38.74f;
        }
        else if((float)Screen.height / Screen.width >= 1f && (float)Screen.height / Screen.width <= 1.1f )
        {
            specialValue = 34.81f;
        }
        else
        {
            specialValue = 85.8f;
        }

        camera.fieldOfView = baseSpecialValue + (float)Screen.height / Screen.width * specialValue;

        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnBubblePosition, Quaternion.Euler(-180f, 0, 0), transform);
    }

    private void InstantiatePopItLevel()
    {
        if ((float)Screen.height / Screen.width <= 1.2f && (float)Screen.height / Screen.width >= 1f)
        {
            specialValue = 43.34f;
        }
        else if ((float)Screen.height / Screen.width <= 1f && (float)Screen.height / Screen.width >= 0.8f)
        {
            specialValue = 56.6f;
        }
        else if ((float)Screen.height / Screen.width >= 0.5f && (float)Screen.height / Screen.width <= 0.6f)
        {
            specialValue = 79.22f;
        }
        else if ((float)Screen.height / Screen.width >= 0.6f && (float)Screen.height / Screen.width <= 0.689f)
        {
            specialValue = 67.8f;
        }
        else if ((float)Screen.height / Screen.width >= 0.7f && (float)Screen.height / Screen.width <= 0.8f)
        {
            specialValue = 60.7f;
        }
        else if ((float)Screen.height / Screen.width >= 1.2f)
        {
            specialValue = 38.74f;
        }
        else if ((float)Screen.height / Screen.width >= 1f && (float)Screen.height / Screen.width <= 1.1f)
        {
            specialValue = 34.81f;
        }
        else
        {
            specialValue = 85.8f;
        }

        camera.fieldOfView = baseSpecialValue + (float)Screen.height / Screen.width * specialValue;

        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnPopItPosition, Quaternion.Euler(0, 0, 0), transform);
    }

    private void InstantiateSoapBallsLevel()
    {
        if ((float)Screen.height / Screen.width <= 1.2f && (float)Screen.height / Screen.width >= 0.8f)
        {
            specialValue = 57f;
        }
        else if((float)Screen.height / Screen.width > 1)
        {
            specialValue = 29.3f;
        }
        else
        {
            specialValue = 65.9f;
        }
        camera.fieldOfView = baseSpecialValue + (float)Screen.height / Screen.width * specialValue;
     
        _levelPrefab = Instantiate(_level.LvlPrefab, _spawnSoapBallsPosition, Quaternion.identity, transform);
    }

    private void SetCameraPostion(Vector3 position)
    {
        Camera.main.transform.position = position;
        Debug.Log(Camera.main.transform.position);
    }
}
