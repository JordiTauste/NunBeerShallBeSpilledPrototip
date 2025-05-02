using UnityEngine;

public class GrifoControlador : MonoBehaviour
{
    public Transform Manivela;
    public ParticleSystem Birra;
    public float maxAngle = -45f;
    public float speed = 100f;
    private bool pouring = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            pouring = true;
            Birra.Play();
        }

        if (Input.GetKeyUp(KeyCode.M))
        {
            pouring = false;
            Birra.Stop();
        }

        RotateManivela();
    }

    void RotateManivela()
    {
        float targetAngle = pouring ? maxAngle : 0f;
        Quaternion targetRotation = Quaternion.Euler(0f, targetAngle, 0f);
        Manivela.localRotation = Quaternion.RotateTowards(Manivela.localRotation, targetRotation, speed * Time.deltaTime);
    }
}
