using UnityEngine;

public class PlayerController : MonoBehaviour
{

  private float speed = 20.0f;
  private float turnSpeed = 45.0f;
  private float horizontalInput;
  private float verticalInput;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    horizontalInput = Input.GetAxis("Horizontal");
    verticalInput = Input.GetAxis("Vertical");

    // Move the vehicle forward.
    // Time.deltaTime means it multiplies it as: x * time, y * time, z * time.
    transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

    // Rotates the car based on horizontal input from user.
    transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
  }
}
