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
    - Comerciante � filho de NPC, por isso no lugar de Monobehaviour temos NPC.
    - Chamando o m�todo Interagir de NPC, devemos aplicar o OVERRIDE, pois iremos escrever encima do Interagir de NPC.
    - base.Interagir(); mant�m o que est� escrito no m�todo que voc� est� referenciando sem que ele se altere e 
    sem perder o que d� continuidade ao projeto.
    */
}
