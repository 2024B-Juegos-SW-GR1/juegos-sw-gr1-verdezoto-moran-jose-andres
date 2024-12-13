using UnityEngine;

public class Claudia : MonoBehaviour
{
    [SerializeField] public float speed = 0.3f;

    void LateUpdate()
    {
        float moveX = Input.GetAxis("HorizontalWASD");
        float moveY = Input.GetAxis("VerticalWASD");
        transform.Translate(new Vector2(moveX, moveY) * speed * Time.deltaTime);
    }
}
