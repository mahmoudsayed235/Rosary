using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UIController : MonoBehaviour
{
    public TextMeshProUGUI counter;
    public TMP_Dropdown dropdown;
    int counterValue;
    private void OnEnable()
    {
        dropdown.value = 0;
        counterValue = PlayerPrefs.GetInt("MyCounter"+ dropdown.value, 0);
        counter.text = counterValue.ToString();
    }
    public void Add()
    {
        counterValue++;
        PlayerPrefs.SetInt("MyCounter"+dropdown.value, counterValue);
        counter.text = counterValue.ToString();
    }
    public void ResetFunction()
    {
        counterValue=0;
        PlayerPrefs.SetInt("MyCounter"+dropdown.value, counterValue);
        counter.text = counterValue.ToString();
    }
    public void ChangeCounterValue()
    {
        counterValue = PlayerPrefs.GetInt("MyCounter" + dropdown.value, 0);
        counter.text = counterValue.ToString();

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
