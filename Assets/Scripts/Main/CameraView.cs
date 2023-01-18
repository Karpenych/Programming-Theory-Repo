using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraView : MonoBehaviour
{
    [SerializeField] Camera _camera;
    float mouseSensitivity = 5f;
    float xRange = 50;
    float yRange = 30;
    float m_HorizontalAngle;
    float m_VerticalAngle = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        m_HorizontalAngle = transform.localEulerAngles.y;
    }

    private void Update()
    {
        // EXIT TO MENU
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(0);
        }

        // HORIZONTAL VIEW
        float turnCamX = Input.GetAxis("Mouse X") * mouseSensitivity;
        m_HorizontalAngle = Mathf.Clamp(turnCamX + m_HorizontalAngle, -xRange, xRange);
        Vector3 currentAngles = transform.localEulerAngles;
        currentAngles.y = m_HorizontalAngle;
        transform.localEulerAngles = currentAngles;

        // VERTICAL VIEW
        float turnCamY = -Input.GetAxis("Mouse Y") * mouseSensitivity;
        m_VerticalAngle = Mathf.Clamp(turnCamY + m_VerticalAngle, -yRange, yRange);
        currentAngles = transform.localEulerAngles;
        currentAngles.x = m_VerticalAngle;
        transform.localEulerAngles = currentAngles;
    }

    // USER INTERFACE
    private void OnGUI()
    {
        GUIStyle gs = new();
        gs.fontSize = 24;
        gs.normal.textColor = Color.red;
        GUI.Label(new Rect(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 10, 10), "*", gs); // CROSSHAIR
    }

}
 

