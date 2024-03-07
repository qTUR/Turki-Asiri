using UnityEngine;

public class FloatingObjects : MonoBehaviour
{
    public float floatForce = 2f;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        rb.useGravity = false;
    }

    private void FixedUpdate()
    {
        Vector3 floatDirection = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        rb.AddForce(floatDirection * floatForce, ForceMode.Force);
    }
}