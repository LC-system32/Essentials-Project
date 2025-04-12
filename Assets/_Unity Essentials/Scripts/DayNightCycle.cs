using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("Duration of a full day in seconds")]
    public float dayDurationInSeconds = 120f;

    void Update()
    {
        float degreesPerSecond = 360f / dayDurationInSeconds;
        transform.Rotate(Vector3.right, degreesPerSecond * Time.deltaTime);
    }
}
