using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCam : MonoBehaviour
{
    public float mouseSenst;

    float xRot, yRot = 0f;

    public float yClamp;
    public float xClamp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //uses mouse movement to get inputs 
        float mouseX = Input.GetAxis("Mouse X") * mouseSenst * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSenst * Time.deltaTime;

        //keeps looking from being flipped
        xRot -= mouseY;
        yRot += mouseX;

        //limits verticle rotation to not look behind
        xRot = Mathf.Clamp(xRot, -xClamp, xClamp);
        yRot = Mathf.Clamp(yRot, -yClamp, yClamp);

        //local rotation used bc clamping is needed
        transform.localRotation = Quaternion.Euler(xRot, yRot, 0);
    }
}
