using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    public Transform target;      // Объект игрока
    public float smoothSpeed = 0.125f; // Скорость сглаживания
    public Vector3 offset;       // Смещение (обычно по Z: -10)

    void Start()
    {
        Debug.Log($"Screen: {Screen.width}x{Screen.height}");
    }

    void LateUpdate()
    {
        // Желаемая позиция камеры
        Vector3 desiredPosition = target.position + offset;

        // Плавный переход от текущей позиции к желаемой
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;
    }
}
