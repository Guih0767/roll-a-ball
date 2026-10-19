using TMPro;
using UnityEngine;
public class GerencidorDeJogo : MonoBehaviour
{
    public static GerencidorDeJogo instancia;
    public TextMeshProUGUI textoPontuacao;


    private int pontuacao = 0;
    void Awake()
    {
        instancia = this;
    }
    void Start()
    {
        AtualizarTexto();
    }

    public void AadicionarPontos(int quantidade)
    {
        pontuacao += quantidade;
        AtualizarTexto();
    }

    void AtualizarTexto()
    {
        textoPontuacao.text = "Pontuação: " + pontuacao;
    }
}
