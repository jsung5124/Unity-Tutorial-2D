using UnityEngine;
using System;

public class StudyGameObject : MonoBehaviour
{
    public GameObject prefab;

    void Start()
    {
        CreateAmongus();
        
    }

    public void CreateAmongus()
    {
        GameObject obj = Instantiate(prefab);
        obj.name = "���� ĳ����";

        Transform objTf = obj.transform;
        int conut = objTf.childCount;

        Debug.Log($"ĳ������ �ڽ� ������Ʈ�� �� : {conut}");
        Debug.Log($"ĳ������ ù��° �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(0).name}");
        Debug.Log($"ĳ������ ������ �ڽ� ������Ʈ�� �̸� : {obj.transform.GetChild(conut - 1).name}");
    }

    
}
