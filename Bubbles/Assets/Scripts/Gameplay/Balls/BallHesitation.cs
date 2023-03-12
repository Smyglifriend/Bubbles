using UnityEngine;

public class BallHesitation : MonoBehaviour
{
    [SerializeField] private float zAmplitude = 0.5f;
    [SerializeField] private float yAmplitude = 1f;
    [SerializeField] private float timePeriod = 2f;
    [SerializeField] private GameObject pivotObject;

    private float timeSinceStart;
    private Vector3 pivot;
    

    private void Start()
    {
        yAmplitude = Random.Range(1f, yAmplitude);
        timeSinceStart = (3 * timePeriod) / 4;
    }

    void Update()
    {
        Hesitation(zAmplitude, timePeriod, yAmplitude);
    }

    void Hesitation(float zAmplitude, float zTimePeriod, float yAmplitude)
    {
        var currentTransform = transform;

        var nextPos = currentTransform.position;
        nextPos.y = pivot.y + yAmplitude * Mathf.Sin(((Mathf.PI * 2) / timePeriod) * timeSinceStart);
        nextPos.z = pivot.z + zAmplitude * Mathf.Sin(((Mathf.PI * 2) / zTimePeriod) * timeSinceStart);
        timeSinceStart += Time.deltaTime;
        pivot = pivotObject.transform.position;
        currentTransform.position = nextPos;
    }
}
