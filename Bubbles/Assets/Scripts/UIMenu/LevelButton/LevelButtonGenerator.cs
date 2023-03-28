using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelButtonGenerator : MonoBehaviour
{
    [SerializeField] private GameObject levelButtonPrefab;
    [SerializeField] private List<LevelData> levelDatas;


    public void GenerateButtons()
    {
        foreach (var levelData in levelDatas)
        {
            var levelButton = levelButtonPrefab.GetComponent<LevelButton>();
            levelButton.ApplyLevelData(levelData);
            
            Instantiate(levelButtonPrefab, transform.position, Quaternion.identity, transform);
        }
    }
}
