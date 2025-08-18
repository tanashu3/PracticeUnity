using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Tooltip("How many real-world seconds should one full day (360Åã rotation) take?")]
    public float dayLengthInSeconds = 120f; // Default: 2 minutes = 1 full day

    private void Update()
    {
        if (dayLengthInSeconds <= 0) return;

        // Calculate degrees per second (360 degrees per day cycle)
        float rotationPerSecond = 360f / dayLengthInSeconds;

        // Rotate around the X axis (to simulate the sun rising/setting)
        transform.Rotate(Vector3.right * rotationPerSecond * Time.deltaTime);
    }
}
