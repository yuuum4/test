using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] Text numberText;
    [SerializeField] Image icon;
    [SerializeField] Text descriptionText;
    public void Set(CardBase cardBace)
    {
        nameText.text = cardBace.Name;
        numberText.text = cardBace.Number.ToString();
        icon.sprite = cardBace.Icon;
        descriptionText.text = cardBace.Description;
    }
}
