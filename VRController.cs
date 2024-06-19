using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class VRController : MonoBehaviour
{
    InputDevice leftTargetDevice;
    InputDevice rightTargetDevice;
    public float moveSpeed = 1;
    public float rotateSpeed = 20;
    private Camera mainCamera;
    private Rigidbody rb;

    private void Start()
    {
        if (mainCamera == null)
            mainCamera = Camera.main;

        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        leftTargetDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
        leftTargetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 lAxis);
        rightTargetDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
        rightTargetDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 Raxis);

        rb.AddForce(mainCamera.transform.forward * lAxis.y * moveSpeed + mainCamera.transform.right * lAxis.x * moveSpeed, ForceMode.VelocityChange);
        rb.AddTorque(new Vector3(0, Raxis.x * rotateSpeed, 0), ForceMode.VelocityChange);
    }
}
