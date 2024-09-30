using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aliado : NPC
{
    public override void Interagir()
    {
        Debug.Log("O Seu alidado te ofereceu ajuda na batalha!");
    }

    /*
   - Aliado � filho de NPC, por isso no lugar de Monobehaviour temos NPC.
   - Chamando o m�todo Interagir de NPC, devemos aplicar o OVERRIDE, pois iremos escrever encima do Interagir de NPC
   */
}
