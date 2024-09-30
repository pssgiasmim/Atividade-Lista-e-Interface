using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comerciante : NPC
{
    public override void Interagir()
    {
        
        Debug.Log("O comerciante mostra seus itens a venda");
    }

    /*
    - Comerciante é filho de NPC, por isso no lugar de Monobehaviour temos NPC.
    - Chamando o método Interagir de NPC, devemos aplicar o OVERRIDE, pois iremos escrever encima do Interagir de NPC.
    - base.Interagir(); mantém o que está escrito no método que você está referenciando sem que ele se altere e 
    sem perder o que dá continuidade ao projeto.
    */
}
