using UnityEngine;

public class CameraFallow : MonoBehaviour
{
    public Transform alvo; // referecia ao objeto que a camera vai seguir
    public Vector3 deslocamento = new Vector3(0f, 5f, -10f);
    public float suavizacao = 5f; //quanto mais baixo mais suave sera o movimento da camera

    private void LateUpdate()
    {
        Vector3 posicaoDesejada = alvo.position + deslocamento;
        transform.position = Vector3.Lerp(transform.position, posicaoDesejada, suavizacao * Time.deltaTime);
        transform.LookAt(alvo); // faz a camera olhar para o alvo
    }
}