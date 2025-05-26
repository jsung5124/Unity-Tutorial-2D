using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        // ���� �������� �̵�
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // ���� �������� �̵�
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        
        float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        float localX = transform.localEulerAngles.x;
        float localZ = transform.localEulerAngles.z;

        // ���� �������� ȸ��
        transform.rotation = Quaternion.Euler(localX, angle, localZ);

        // ���� �������� ȸ��
        transform.localRotation = Quaternion.Euler(localX, angle, localZ);
    }
}
