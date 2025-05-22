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
        obj.name = "어몽어스 캐릭터";

        Transform objTf = obj.transform;
        int conut = objTf.childCount;

        Debug.Log($"캐릭터의 자식 오브젝트의 수 : {conut}");
        Debug.Log($"캐릭터의 첫번째 자식 오브젝트의 이름 : {obj.transform.GetChild(0).name}");
        Debug.Log($"캐릭터의 마지막 자식 오브젝트의 이름 : {obj.transform.GetChild(conut - 1).name}");
    }

    
}
