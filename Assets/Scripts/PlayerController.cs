using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(h, 0, v) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}