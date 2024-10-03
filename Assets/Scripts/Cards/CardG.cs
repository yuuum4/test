using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardG : MonoBehaviour
{
    [SerializeField] CardBase[] cardBases;
    [SerializeField] Card cardPrefab;

    public void Start()
    {
        for (int i = 0; i < 8; i++)
        {
            Spawn(i);
        }
    }


    //Card‚Ì¶¬
    public void Spawn(int number)
    {
        Card card = Instantiate(cardPrefab);
        card.Set(cardBases[number]);
    }
}