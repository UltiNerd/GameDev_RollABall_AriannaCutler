using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    //video at 3 minutes
    [SerializeField] private Transform target;
    private Vector3 offset;
    [SerializeField] private float smoothtime;
    private Vector3 _currentVelocity = Vector3.zero;

    private Vector2 _input;

    [SerializeField] private MouseSensitivity mouseSensitivity;
    private CameraRotation cameraRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = transform.position - target.transform.position;

    }

    public void Look(InputAction.CallbackContext context) 
    {
        _input = context.ReadValue<Vector2>();

    }
    private void Update()
    {
        cameraRotation.Yaw += _input.x * mouseSensitivity.horizontal * Time.deltaTime;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        var targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref _currentVelocity, smoothtime);

    }
}

[Serializable]
public struct MouseSensitivity 
{
    public float horizontal;
    public float vertical;

}

public struct CameraRotation
{
    public float Pitch;
    public float Yaw;

}