using UnityEngine;

public class Cristiano : MonoBehaviour
{
    [SerializeField] public float speed = 0.3f;

    void LateUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(moveX, moveY) * speed * Time.deltaTime);
    }
}
