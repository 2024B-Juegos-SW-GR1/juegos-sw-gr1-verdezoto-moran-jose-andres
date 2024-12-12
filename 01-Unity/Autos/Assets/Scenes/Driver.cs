using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float velocidad = 0.1f;
    [SerializeField] private float movimiento = 0.01f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steerAmount = Input.GetAxis("Vertical") * velocidad * Time.deltaTime;
        float moveAmount = Input.GetAxis("Horizontal") * movimiento * Time.deltaTime;
        transform.Rotate(0,0,-steerAmount);
        transform.Translate(0,moveAmount,0);
    }
}
