using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    public float xAxis;
    public float yAxis;

    public float xAxisTurnRate = 360f;
    public float yAxisTurnRate = 360f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;   
    }

    private void LateUpdate()
    {
        float xAxisInput = Input.GetAxis("Mouse Y");
        float yAxisInput = Input.GetAxis("Mouse X");

        

        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }
    public void AddAxisInput(float input)
    {
        xAxis -= input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -90f, 90f);
    }
    public void AddYAxisInput(float input)
    {
        yAxis += input * yAxisTurnRate;
    }
}
