using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

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
        var child = transform.GetChild(0);
        if (!child.gameObject.activeSelf) return;
        
        child.gameObject.SetActive(false);;
    }
    
    public void ShowLevel()
    {
        var child = transform.GetChild(0);
        if (child.gameObject.activeSelf) return;
        
        child.gameObject.SetActive(true);;
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
