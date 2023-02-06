using UnityEngine;

public class BubbleGeneration : MonoBehaviour
{
    [SerializeField] private GameObject bubble;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            var randomSpawnPosition = new Vector3(Random.Range(-4, 4), Random.Range(3, -1), -5.42f);
            Instantiate(bubble, randomSpawnPosition, Quaternion.identity);
        }
    }
}
