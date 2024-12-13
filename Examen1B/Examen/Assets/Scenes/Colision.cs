using UnityEngine;

public class Colision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Colision");
    }
}
