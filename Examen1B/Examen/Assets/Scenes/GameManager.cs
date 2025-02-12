using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;

    private int player1Score = 0;
    private int player2Score = 0;
    
    private void Start()
    {
        // Busca el TextMeshProUGUI en la escena por nombre
        GameObject scoreTextObject = GameObject.Find("score"); // Cambia "NombreDelTexto" por el nombre correcto
        if (scoreTextObject != null)
        {
            scoreText = scoreTextObject.GetComponent<TextMeshProUGUI>();
        }
        else
        {
            Debug.LogError("⚠️ No se encontró el GameObject con el TextMeshProUGUI.");
        }
    }

    public void IncrementScore(int player) // Nueva función para incrementar el marcador
    {
        if (player == 1)
        {
            player1Score++;
        }
        else if (player == 2)
        {
            player2Score++;
        }

        UpdateScoreText(); // Actualiza el texto después de incrementar
    }
    
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Liga: " + player1Score + " - Real Madrid: " + player2Score;
            Debug.Log("🏆 Marcador actualizado: " + scoreText.text);
        }
        else
        {
            Debug.LogError("🚨 scoreText es NULL en GameManager.");
        }
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        if (scoreText == null)
        {
            Debug.LogError("⚠️ scoreText no está asignado.");
        }
        else
        {
            Debug.Log("✅ scoreText asignado correctamente.");
        }
    }


    public void SetScore(int player1, int player2)
    {
        player1Score = player1;
        player2Score = player2;

        if (scoreText != null)
        {
            scoreText.text = "Liga: " + player1Score + " - Real Madrid: " + player2Score;
            scoreText.ForceMeshUpdate(); // Forzar actualización del mesh para que se vea el cambio
            Canvas.ForceUpdateCanvases(); // Forzar la actualización completa del Canvas
            Debug.Log("🏆 Marcador actualizado: " + scoreText.text);
        }
        else
        {
            Debug.LogError("🚨 scoreText es NULL en GameManager.");
        }
    }
    
}