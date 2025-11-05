using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    //video at 3 minutes
    [SerializeField] private Transform target;
    private float distancetoplayer;
 
    private Vector2 _input;

    [SerializeField] private MouseSensitivity mouseSensitivity;
    [SerializeField] private CameraAngle cameraAngle;
    private CameraRotation cameraRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       distancetoplayer = Vector3.Distance(transform.position, target.position);

    }

    public void Look(InputAction.CallbackContext context) 
    {
        _input = context.ReadValue<Vector2>();

    }
    private void Update()
    {
        cameraRotation.Yaw += _input.x * mouseSensitivity.horizontal * Time.deltaTime;
        cameraRotation.Pitch += _input.y * mouseSensitivity.vertical * Time.deltaTime;
        cameraRotation.Pitch = Mathf.Clamp(cameraRotation.Pitch, cameraAngle.min, cameraAngle.max);
    }
    // Update is called once per frame
    void LateUpdate()
    {
        transform.eulerAngles = new Vector3(cameraRotation.Pitch, cameraRotation.Yaw, 0.0f);
        transform.position = target.position - transform.forward * distancetoplayer;
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
[Serializable]
public struct CameraAngle
{
    public float min;
    public float max;
}