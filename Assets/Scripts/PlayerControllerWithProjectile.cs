using UnityEngine;

public class PlayerControllerWithProjectile : MonoBehaviour
{
  private float horizontalInput;
  private float speed = 10.0f;
  private float xRange = 20;
  public GameObject projectilePrefab;

  private Vector3 offset = new Vector3(0, 1.5f, 0);

  // Update is called once per frame
  void Update()
  {
    horizontalInput = Input.GetAxis("Horizontal");
    transform.Translate(Vector3.right * (horizontalInput * Time.deltaTime * speed));
    if (transform.position.x < -xRange)
    {
      transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
    }
    if (transform.position.x > xRange)
    {
      transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
    }

    if (Input.GetKeyDown(KeyCode.Space))
    {
      // Launch food from player
      Instantiate(projectilePrefab, transform.position + offset, projectilePrefab.transform.rotation);
    }
  }
}
