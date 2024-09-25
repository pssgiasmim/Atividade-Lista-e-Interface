using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gerenciador : MonoBehaviour
{
    //Variáveis que criam as Listas que armazem os NPCs e os itens
    [SerializeField] List<NPC> npcs = new List<NPC>();
    [SerializeField] List<Item> itens = new List<Item>();

    [SerializeField] Item itemAtual;
    [SerializeField] NPC npc;

    //Método que adciona itens na lista Item
    public void AdicionarItens(Item item)
    {
        itens.Add(item);

    }

    //Método que adciona NPCs na lista NPC
    public void AdicionarNpcs(NPC npc)
    {
        npcs.Add(npc);
    }

    //Método que faz os itens interagirem com o jogador
    public void IntergirItens()
    {
        foreach (Item item in itens)
        {
            item.Interagir();
        }
    }

    //Método que faz os NPCs interagirem com o jogador
    public void InteragirNpcs()
    {
        foreach (NPC npc in npcs)
        {
            npc.Interagir();
        }
    }

    //Método que faz os itens serem consumidos
    public void ConsumirItens()
    {
        itens[itens.Count - 1].Consumir();

        //vai pegar a lista de itens e vai pagar o último espaço
        itens.RemoveAt(itens.Count - 1);

    }

    //Método que ao botão especifico ser clicado, vai chamar os itens
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            AdicionarItens(itemAtual);

        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            AdicionarNpcs(npc);
            
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            ConsumirItens();

        }
    }

}
