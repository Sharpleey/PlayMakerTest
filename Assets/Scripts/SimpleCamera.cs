using UnityEngine;

public class SimpleCamera : MonoBehaviour
{
    private void LateUpdate()
    {
        transform.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0f);
    }
}
