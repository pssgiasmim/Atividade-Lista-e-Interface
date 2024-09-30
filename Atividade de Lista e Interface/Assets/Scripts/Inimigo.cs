using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : NPC
{
    public override void Interagir()
    {
        Debug.Log("Seu inimigo lhe atacou");
    }

    /*
   - Inimigo � filho de NPC, por isso no lugar de Monobehaviour temos NPC.
   - Chamando o m�todo Interagir de NPC, devemos aplicar o OVERRIDE, pois iremos escrever encima do Interagir de NPC
   */
}
