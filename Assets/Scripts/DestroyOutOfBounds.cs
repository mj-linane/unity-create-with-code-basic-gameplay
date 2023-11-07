using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 30;
    public float lowerBound = -10;

    void Update()
    {
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game over!");
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
}
