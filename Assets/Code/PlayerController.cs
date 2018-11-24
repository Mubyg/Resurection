using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    private float MovementSpeed = 0.1f;
    [SerializeField]
    private float KeyRotationSpeed = 0.1f;
    [SerializeField]
    private float MouseRotationSpeed = 0.1f;
    [SerializeField]
    private Transform CameraTransform = null;

    void Start() {
        Cursor.visible = false;
    }

    void Update() {
        float forward = Input.GetAxis("Vertical") * MovementSpeed * Time.deltaTime;
        float right = Input.GetAxis("Horizontal") * KeyRotationSpeed * Time.deltaTime;
        float rotationX = Input.GetAxis("Mouse X") * MouseRotationSpeed * Time.deltaTime;
        float rotationY = Input.GetAxis("Mouse Y") * MouseRotationSpeed * Time.deltaTime;

        transform.Translate(right, 0, forward);
        transform.Rotate(0, rotationX, 0);
        CameraTransform.Rotate(-rotationY, 0, 0);
    }
}
