using UnityEngine;

public class Follow : MonoBehaviour
{

    [SerializeField] private GameObject cosaASeguir;

    void LateUpdate()
    {
        transform.position = cosaASeguir.transform.position + new Vector3(0, 0, -10);
    }
}
