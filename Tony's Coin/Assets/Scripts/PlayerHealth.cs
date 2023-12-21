using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    private bool isPlayerAlive;

    private int life;
    // Start is called before the first frame update
    void Start()
    {
        life = 100;
        isPlayerAlive = true;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "EndOfLine" && other.gameObject.tag != "Enemy") return;
        life = 0;
        isPlayerAlive = false;
    }

    public void PlayerDead()
    {
        if (life < 1)
        {
            // "Freezar" / pausar o jogo
            Time.timeScale = 0;
            // mostrar a UI com o botão para retornar do ultimo checkpoint
            
            //  Pegar a referencia do ultimo checkpoint que o player colidiu
            // nesse botão setar o valor do position deste gameObject para a posição do ultimo checkpoint
        }
    }
}
