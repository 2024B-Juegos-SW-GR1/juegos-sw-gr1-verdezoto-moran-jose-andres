using UnityEngine;

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
                player2Score++;
                Debug.Log("¡Gol del Real Madrid! Puntuación: " + player2Score);
            }
            else if (gameObject.name == "ArcoCristiano")
            {
                player1Score++;
                Debug.Log("¡Gol del Liga! Puntuación: " + player1Score);
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
        ball.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero; // Detener movimiento
    }
    
    
}
