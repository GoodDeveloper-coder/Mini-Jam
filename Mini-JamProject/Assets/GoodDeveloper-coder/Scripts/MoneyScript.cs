using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MoneyText1;
    [SerializeField] TextMeshProUGUI MoneyText2;
    public GlobalValues GlobalValues;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoneyTimer());  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator MoneyTimer()
    {

        yield return new WaitForSeconds(1f);
        GlobalValues.Money1 += 1;
        GlobalValues.Money2 += 1;
        MoneyText1.text = string.Format("Money:{00}", GlobalValues.Money1);
        MoneyText2.text = string.Format("{00}:Money", GlobalValues.Money2);
        StartCoroutine(MoneyTimer());
    }
}
