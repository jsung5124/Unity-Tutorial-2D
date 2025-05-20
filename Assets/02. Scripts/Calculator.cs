using UnityEngine;

public class Calculator : MonoBehaviour
{
    public int number1, number2;

    void Start()
    {
        Debug.Log(AddMethod());
        Debug.Log(MinusMethod());
        //AddMethod();
        //MinusMethod();
    }

    int AddMethod()
    {
        int result = number1 + number2;

        return result;
    }

    int MinusMethod()
    {
        int result = number1 - number2;
        return result;
    }
}
