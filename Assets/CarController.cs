using UnityEngine;
using System.Collections;

public class CarController : MonoBehaviour
{
    public Rigidbody rb;

    public float maxSpeed = 100f;

    public float speed = 10.0F;
    public float rotationSpeed = 1000.0F;
    public float translation, rotation;

    // Update is called once per frame
    void Update()
    {

        translation = Input.GetAxis("Vertical") * speed;
        rotation += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        translation *= Time.deltaTime;
        Debug.Log(rotation);
        if (rb.velocity.magnitude < maxSpeed)
        {
            Vector3 movement = Quaternion.Euler(0, rotation, 0) * Vector3.forward * translation;

            rb.AddForce(movement, ForceMode.VelocityChange);
        }

        //Debug.Log(rb.velocity);
        rb.MoveRotation(Quaternion.Euler(0, rotation, 0));
    }
}