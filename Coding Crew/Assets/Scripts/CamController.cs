using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    public float mouseSenst;

    public Test test;
    private posterVeiw posVeiw;

    float xRot, yRot = 0f;

    public float yClamp;
    public float xClampUp, xClampDown;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        posVeiw = GetComponent<posterVeiw>();
    }

    void Update()
    {
        if (!test.TestActive)
        {
            if (!posVeiw.posterOpen)
            {
                //uses mouse movement to get inputs 
                float mouseX = Input.GetAxis("Mouse X") * mouseSenst * Time.deltaTime;
                float mouseY = Input.GetAxis("Mouse Y") * mouseSenst * Time.deltaTime;

                //keeps looking from being flipped
                xRot -= mouseY;
                yRot += mouseX;

                //limits verticle rotation to not look behind
                xRot = Mathf.Clamp(xRot, xClampUp, xClampDown);
                yRot = Mathf.Clamp(yRot, -yClamp, yClamp);

                //local rotation used bc clamping is needed
                transform.localRotation = Quaternion.Euler(xRot, yRot, 0);
            }
        }
        //no clamping needed
        //transform.Rotate(Vector3.up * mouseX);
    }
}