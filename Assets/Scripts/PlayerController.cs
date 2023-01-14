using UnityEngine;

public class PlayerController : MonoBehaviour
{

  public float speed = 5.0f;

  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    // Move the vehicle forward.
    // Forward = 0, 0, 1.
    // Time.deltaTime means it multiplies it as: x * time, y * time, z * time.
    transform.Translate(Vector3.forward * Time.deltaTime * speed);
  }
}
