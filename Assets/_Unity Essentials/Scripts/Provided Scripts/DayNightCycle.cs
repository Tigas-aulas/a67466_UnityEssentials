using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    [Header("Day Duration Settings")]
    [Tooltip("Length of a full day in seconds")]
    public float dayDuration = 60f;

    [Header("Rotation Settings")]
    [Tooltip("Axis to rotate around (usually X for sun movement)")]
    public Vector3 rotationAxis = new Vector3(1f, 0f, 0f);

    private float rotationSpeed;

    void Start()
    {
        UpdateRotationSpeed();
    }

    void Update()
    {
        // Rotate the light continuously
        transform.Rotate(rotationAxis, rotationSpeed * Time.deltaTime);
    }

    void OnValidate()
    {
        // Ensure values update in Inspector when changed
        UpdateRotationSpeed();
    }

    void UpdateRotationSpeed()
    {
        if (dayDuration <= 0f)
            dayDuration = 0.1f;

        // 360 degrees per full day
        rotationSpeed = 360f / dayDuration;
    }
}