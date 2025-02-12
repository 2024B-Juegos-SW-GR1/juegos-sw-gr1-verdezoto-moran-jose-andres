using UnityEngine;
using TMPro; 

public class Goal : MonoBehaviour
{
    public Transform player1StartPosition; 
    public Transform player2StartPosition; 
    public Transform ballStartPosition; 

    public GameObject player1; 
    public GameObject player2; 
    public GameObject ball; 

    public int player1Score = 0; 
    public int player2Score = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pelota"))
        {
            if (gameObject.name == "ArcoBieler")
            {
                GameManager.Instance.IncrementScore(2); // Llama a la nueva función de GameManager
                Debug.Log("¡Gol del Real Madrid!");
            }
            else if (gameObject.name == "ArcoCristiano")
            {
                GameManager.Instance.IncrementScore(1); // Llama a la nueva función de GameManager
                Debug.Log("¡Gol del Liga!");
            }

            ResetPositions();
        }
    }

    void ResetPositions()
    {
        player1 = GameObject.Find("Bieler");
        player2 = GameObject.Find("Cristiano");
        ball = GameObject.Find("Pelota");

        player1.transform.position = player1StartPosition.position;
        player2.transform.position = player2StartPosition.position;

        ball.transform.position = ballStartPosition.position;
        ball.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;
    }

    void UpdateScoreText()
    {
        if (GameManager.Instance == null)
        {
            Debug.LogError("⚠️ GameManager.Instance es null.");
            return;
        }

        Debug.Log("✅ UpdateScoreText() ejecutado. Nueva puntuación: " + player1Score + " - " + player2Score);

        GameManager.Instance.SetScore(player1Score, player2Score);
    }
}