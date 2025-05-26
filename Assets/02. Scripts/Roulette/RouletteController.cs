using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;

    public bool isStop; // false

    void Start()
    {
        rotSpeed = 0f;
    }

    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed); // Z�� �������� ȸ���ϴ� ���
        //transform.Rotate(0f, 0f, rotSpeed);

        // ���콺 ���� ��ư�� ������ �� ȸ���ϴ� ���
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isStop = true;
        }

        if (isStop == true)
        {
            rotSpeed *= 0.98f;

            if (rotSpeed < 0.01f)
            {
                rotSpeed = 0f;
                isStop = false;
            }
        }

    }
}
