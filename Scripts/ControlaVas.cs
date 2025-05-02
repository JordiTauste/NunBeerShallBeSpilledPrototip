using UnityEngine;

public class VasoControlador : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float rotateSpeed = 50f;

    public float minY = 0.1f;
    public float maxY = 100f;

    void Update()
    {
        float move = Input.GetAxis("Vertical");
        Vector3 position = transform.position;
        position.y += move * moveSpeed * Time.deltaTime;
        position.y = Mathf.Clamp(position.y, minY, maxY);
        transform.position = position;

        float rotate = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.right * rotate * rotateSpeed * Time.deltaTime);
    }
}
