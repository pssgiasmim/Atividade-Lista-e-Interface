using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerenciador : MonoBehaviour
{
    //Vari�veis que criam as Listas que armazem os NPCs e os itens
    [SerializeField] List<NPC> npcs = new List<NPC>();
    [SerializeField] List<Item> itens = new List<Item>();
    [SerializeField] Item itemAtual;
    [SerializeField] NPC npcAtual;

    [SerializeField] Aliado aliado;
    [SerializeField] Inimigo inimigo;
    [SerializeField] Comerciante comerciante;

    [SerializeField] Pocao pocao;
    [SerializeField] Comida comida;

    //M�todo que adciona itens na lista Item
    public void AdicionarItens()
    {
        itens.Add(pocao);
        itens.Add(comida);
    }




    //M�todo que adciona NPCs na lista NPC
    public void AdicionarNpcs()
    {
        npcs.Add(aliado);
        npcs.Add(inimigo);
        npcs.Add(comerciante);
    }



    //M�todo que faz os itens interagirem com o jogador
    public void IntergirItens()
    {
        foreach (Item item in itens)
        {
            item.Interagir();
        }
    }



    //M�todo que faz os NPCs interagirem com o jogador
    public void InteragirNpcs()
    {
        foreach (NPC npc in npcs)
        {
            npc.Interagir();
        }
    }



    //M�todo que faz os itens serem consumidos
    public void ConsumirItens()
    {
        itens[itens.Count - 1].Consumir();

        //vai pegar a lista de itens e vai pagar o �ltimo espa�o
        itens.RemoveAt(itens.Count - 1);

    }




    //M�todo que ao bot�o especifico ser clicado, vai chamar os itens
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            AdicionarItens();

        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            AdicionarNpcs();
            
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            ConsumirItens();

        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            InteragirNpcs();

        }
    }

}
