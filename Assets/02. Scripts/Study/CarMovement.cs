using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public float moveSpeed = 3f;

    public Rigidbody2D carRb;

    private float h;

    void Update()
    {
        h = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        // Rigidbody의 속도를 활용한 이동
        carRb.linearVelocityX = h * moveSpeed * Time.deltaTime;
    }
}