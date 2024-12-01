using UnityEngine;

public class TouchScaleAndRotate : MonoBehaviour
{
    public float rotationSpeed = 100f; // Speed of rotation
    public float scaleSpeed = 0.01f;   // Speed of scaling
    public float minScale = 0.5f;     // Minimum scale limit
    public float maxScale = 3f;       // Maximum scale limit

    private Vector2 initialTouchDistance; // Initial distance between two fingers
    private Vector3 initialScale;         // Initial scale of the object
    private bool isScaling = false;       // Flag to determine scaling mode

    void Update()
    {
        if (Input.touchCount == 1) // Single touch for rotation
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                float rotationAmount = touch.deltaPosition.x * rotationSpeed * Time.deltaTime;
                transform.Rotate(Vector3.up, -rotationAmount, Space.World);
            }
        }
        else if (Input.touchCount == 2) // Two-finger pinch for scaling
        {
            Touch touch1 = Input.GetTouch(0);
            Touch touch2 = Input.GetTouch(1);

            if (!isScaling)
            {
                // Initialize scaling
                initialTouchDistance = touch1.position - touch2.position;
                initialScale = transform.localScale;
                isScaling = true;
            }
            else
            {
                // Calculate the scale factor
                Vector2 currentTouchDistance = touch1.position - touch2.position;
                float scaleMultiplier = currentTouchDistance.magnitude / initialTouchDistance.magnitude;

                // Apply the scale
                Vector3 newScale = initialScale * scaleMultiplier;

                // Clamp the scale to min and max values
                newScale.x = Mathf.Clamp(newScale.x, minScale, maxScale);
                newScale.y = Mathf.Clamp(newScale.y, minScale, maxScale);
                newScale.z = Mathf.Clamp(newScale.z, minScale, maxScale);

                transform.localScale = newScale;
            }
        }
        else
        {
            isScaling = false; // Reset scaling mode when fingers are lifted
        }
    }
}
