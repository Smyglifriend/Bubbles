using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    private LevelData _level;
    private GameObject _levelPrefab;

    public void SetLevel(LevelData levelData)
    {
        _level = levelData;
    }

    public void GenerateLevel()
    {
        switch (_level.LevelName)
        {
            case "Bubble":
                InstantiatePrefab();
                break;
            case "Pop It":
                InstantiatePrefab();
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
    
    private void InstantiatePrefab()
    {
        _levelPrefab = Instantiate(_level.LvlPrefab, new Vector3(-0.3f,1f,1f), Quaternion.identity, transform);
    }
}
