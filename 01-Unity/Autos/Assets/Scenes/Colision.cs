using UnityEngine;

public class Colision : MonoBehaviour
{
    [SerializeField] private float destroyDelay = 0.5f;
    private bool hasPackage;
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Colision");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Entrando a trigger");
        if (other.tag == "Paquete" && hasPackage != true)
        {
            Debug.Log("Paquete recogido");
            hasPackage = true;
            Destroy(other.gameObject, destroyDelay);
        }        
        if (other.tag == "Cliente" && hasPackage == true)
        {
            Debug.Log("Paquete entregado");
            hasPackage = false;
        }
    }
    
}
