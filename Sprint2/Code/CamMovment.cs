using UnityEngine;

public class CamMovment : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // move the camera along the z axis
        GetComponent<Rigidbody>().velocity = new Vector3(0, GM.verticalVelocity, (4 * GM.zVelocityAdjustment));
    }
}
