using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// ADD TWEENING
/// </summary>
public class GetCardsScript : MonoBehaviour
{
    [SerializeField]
    private Sprite[] cards;

    [SerializeField] 
    private GameObject[] cardSlots;
    [SerializeField]
    private int waitTime;

    [SerializeField] private TMP_Text moneyField;
    private int money = 1000;
    public void RollButton()
    {
        StartCoroutine(Roll());
    }

    private IEnumerator Roll()
    {
        money -= 10;
        moneyField.text = "Money: " + money; 
        foreach (GameObject slot in cardSlots)
        {
            Sprite sprite = cards[Random.Range(0, cards.Length)];
            CardStorage.instance.AddCard(sprite);
            slot.GetComponent<Image>().sprite = sprite;
            slot.SetActive(true);
            yield return new WaitForSeconds(waitTime);
        }
    }
}
