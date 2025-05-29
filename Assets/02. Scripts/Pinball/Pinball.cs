using UnityEngine;

public class Pinball : MonoBehaviour
{
    public PinballManager pinballManager;

    private void OnCollisionEnter2D(Collision2D other)
    {
        int score = 0;
        switch (other.gameObject.tag)
        {
            
            case "Score10":
                score = 10;
                break;
            case "Score30":
                score = 30;
                break;
            case "Score50":
                score = 50;
                break;
        }

        pinballManager.totalScore += score;

        if (score != 0)
            Debug.Log($"{score}Á¡ È¹µæ");

        //if (other.gameObject.CompareTag("Score10"))
        //{
        //    pinballManager.totalScore += 10;
        //    Debug.Log("10Á¡ È¹µæ");
        //}
        //else if (other.gameObject.CompareTag("Score30"))
        //{
        //    pinballManager.totalScore += 30;
        //    Debug.Log("30Á¡ È¹µæ");
        //}
        //else if (other.gameObject.CompareTag("Score50"))
        //{
        //    pinballManager.totalScore += 50;
        //    Debug.Log("50Á¡ È¹µæ");
        //}
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("GameOver"))
        {
            Debug.Log($"°ÔÀÓ Á¾·á - ÇöÀç Á¡¼ö : {pinballManager.totalScore}");
        }
    }
}
