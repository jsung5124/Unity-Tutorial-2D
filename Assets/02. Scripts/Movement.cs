using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        float h = Input.GetAxis("Horiaontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v);
        Debug.Log($"현재 입려 : {dir}");

        transform.position += dir * moveSpeed * Time.deltaTime;

    }
}
