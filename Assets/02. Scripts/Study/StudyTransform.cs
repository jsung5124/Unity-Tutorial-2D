using UnityEngine;

public class StudyTransform : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 70f;

    void Update()
    {
        // 월드 방향으로 이동
        //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;

        // 로컬 방향으로 이동
        //transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);


        
        float angle = transform.rotation.eulerAngles.y + rotateSpeed * Time.deltaTime;
        float localX = transform.localEulerAngles.x;
        float localZ = transform.localEulerAngles.z;

        // 월드 방향으로 회전
        transform.rotation = Quaternion.Euler(localX, angle, localZ);

        // 로컬 방향으로 회전
        transform.localRotation = Quaternion.Euler(localX, angle, localZ);
    }
}
