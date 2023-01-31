using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CardStorage : MonoBehaviour
{
    [SerializeField]
    private GameObject[] cardSlots;
    private int cardSlotIndex = 0;
    private int maxCards = 64;
    public static CardStorage instance;

    [SerializeField] private TMP_Text counterText;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    public void AddCard(Sprite sprite)
    {
        if (CheckForDuplicate(sprite)) return;
        cardSlots[cardSlotIndex].GetComponent<Image>().sprite = sprite;
        cardSlots[cardSlotIndex].GetComponent<Image>().color = Color.white;
        cardSlotIndex++;
        UpdateCounter();
    }

    private bool CheckForDuplicate(Sprite sprite)
    {
        return cardSlots.Any(g => g.GetComponent<Image>().sprite == sprite);
    }

    private void UpdateCounter()
    {
        counterText.text = cardSlotIndex + "/" + maxCards + "Collected";
    }
}
