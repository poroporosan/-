using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverJudge : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                SceneManager.LoadScene("GameOver");
                Debug.Log("ゲームオーバーしました");
            }
        }
}