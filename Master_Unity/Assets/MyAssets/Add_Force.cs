using UnityEngine;
using System.Collections;

public class Add_Force : MonoBehaviour
{
    public float thrustX = 1.0f;
    public float thrustY = 0.0f;
    public float thrustZ = 0.0f;
    private Rigidbody rb;

    void Start()
    {
        StartCoroutine(Wait());   
    }

    IEnumerator Wait()
    {
        yield return new WaitForSecondsRealtime(2);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(thrustX, thrustY, thrustZ, ForceMode.VelocityChange);
    }
}
