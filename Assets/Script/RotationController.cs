using UnityEngine;

public class RotationController : MonoBehaviour
{
    public GameObject planetObject;
    public Vector3 rotationVector;
    void Update()
    {
        planetObject.transform.Rotate(rotationVector * Time.deltaTime);
    }

}
