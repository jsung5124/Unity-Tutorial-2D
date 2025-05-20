using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) // ������ ���� ���
        {
            transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.S)) // �ڷ� ���� ���
        {
            transform.position += Vector3.back * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.A)) // �������� ���� ���
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.D)) //���������� ���� ���
        {
            transform.position += Vector3.right * moveSpeed * Time.deltaTime;
        }

    }
}
