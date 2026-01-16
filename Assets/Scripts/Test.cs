using UnityEngine;

/// <summary>
/// Simple script that rotates a GameObject continuously around the Y-axis.
/// Attach this script to any GameObject (like a cube) to make it spin.
/// </summary>
public class Test : MonoBehaviour
{
    /// <summary>
    /// The rotation speed in degrees per second.
    /// [SerializeField] makes this field visible and editable in the Unity Inspector,
    /// even though it's marked as private.
    /// Default value is 90 degrees per second (quarter turn every second).
    /// </summary>
    [SerializeField] private float rotationSpeed = 90f; // Degrees per second

    /// <summary>
    /// Update is called once per frame by Unity.
    /// This method runs continuously while the GameObject is active in the scene.
    /// </summary>
    void Update()
    {
        // Rotate the cube around the Y axis (vertical/up-down axis)
        // transform.Rotate takes three parameters: (X rotation, Y rotation, Z rotation)
        // We only rotate on the Y axis, so X and Z are set to 0
        
        // Time.deltaTime is the time in seconds it took to complete the last frame.
        // Multiplying by deltaTime makes the rotation speed frame-rate independent,
        // so the cube spins at the same speed on all devices regardless of FPS.
        
        // Example: If rotationSpeed = 90 and deltaTime = 0.016 (60 FPS),
        // then we rotate 90 * 0.016 = 1.44 degrees this frame
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
