using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardReveal : MonoBehaviour
{

    [SerializeField]
    GameObject hide;


    public void HideCard()
    {
        hide.SetActive(false);
        StartCoroutine(WaitBeforeShow());
    }



    private IEnumerator WaitBeforeShow()
    {
        yield return new WaitForSeconds(3);
        hide.SetActive(true);
    }

}
