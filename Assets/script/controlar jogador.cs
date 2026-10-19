using UnityEngine;

public class playercontroler : MonoBehaviour
{
   public float speed = 5f;

    [Header("Teclas de Movimento")]
    public KeyCode teclaCima = KeyCode.W;
    public KeyCode teclaBaixo = KeyCode.S;
    public KeyCode teclaDireita = KeyCode.D;
    public KeyCode teclaEsquerda = KeyCode.A;

    private Rigidbody rb;
    // variavel privada que vai guardar a referencia do componente
    // rigidbody do objeto. "private" porque nao precisa aparecer
    // no inspector e so uso interno do script

    void Start()
    // start() roda UMA UNICA vez, antes do primeiro update()
    // quando o objeto entra em cena. Ideal para preparar referencias.
    {
        rb = GetComponent<Rigidbody>();
        // GetComponent<Rigidbody>() procura, no mesmo GameObject onde
        // este script esta, um comnponete do tipo  do tipo Rigidbody e guarda 
        // a referencia a referencia na variavel "rb". precisa que o objeto
        // um rigidbody adicionada no inspector, se na da erro (null).
    }

    void Update()
    {
        Vector3 direcao = Vector3.zero;

        if (Input.GetKey(teclaCima))
            direcao += Vector3.forward;
        if (Input.GetKey(teclaBaixo))
            direcao += Vector3.back;
        if (Input.GetKey(teclaDireita))
            direcao += Vector3.right;
        if (Input.GetKey(teclaEsquerda))
            direcao += Vector3.left;
        rb.AddForce(direcao.normalized * speed);
        //AddForce() aplica uma força física ao Rigidbody, empurrando
        //na direção indicada. É isso que faz a bola "rolar"
        //de verdade (com aceleração, inércia, atrito, colisões etc.)
        //em vez de simplesmente teleportar a cada frame como o
        //translate fazia.

    }
}