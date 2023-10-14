using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class MoneyScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI MoneyText1;
    [SerializeField] TextMeshProUGUI MoneyText2;
    private float money1desplayscore;
    private float money2desplayscore;
    public GlobalValues GlobalValues;

    [SerializeField] float transitionSpeed = 100;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MoneyTimer());  
    }

    // Update is called once per frame
    void Update()
    {
        GlobalValues.Money1 += Mathf.MoveTowards(money1desplayscore, GlobalValues.Money1, transitionSpeed * Time.deltaTime);
        GlobalValues.Money2 += Mathf.MoveTowards(money1desplayscore, GlobalValues.Money1, transitionSpeed * Time.deltaTime);
        MoneyText1.text = string.Format("Money:{0,00}", GlobalValues.Money1);
        MoneyText2.text = string.Format("{0:0000}:Money", GlobalValues.Money2);

    }

    IEnumerator MoneyTimer()
    {

        yield return new WaitForSeconds(1f);
        money1desplayscore = 1;
        money2desplayscore = 1;
        //GlobalValues.Money1 += Mathf.MoveTowards(money1desplayscore, GlobalValues.Money1, transitionSpeed * Time.deltaTime);
        //GlobalValues.Money2 += 1;
        //MoneyText1.text = string.Format("Money:{00}", GlobalValues.Money1);
        //MoneyText2.text = string.Format("{00}:Money", GlobalValues.Money2);
        StartCoroutine(MoneyTimer());
    }
}
