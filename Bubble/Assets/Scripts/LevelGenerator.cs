using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SearchService;

public class LevelGenerator : MonoBehaviour
{
    private LevelData _level;
    
    public void SetLevel(LevelData levelData)
    {
        _level = levelData;
    }

    public void GenerateLevel()
    {
        Debug.Log($"{_level.LevelName}");
    }
}
