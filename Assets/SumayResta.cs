using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SumayResta : MonoBehaviour
{
    public TMP_InputField inputnum1;
    public TMP_InputField inputnum2;

    public TextMeshProUGUI txtResultado;
    int num1;
    int num2;
    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
    }

    public void SumarYmostar()
    {
        num1 = int.Parse(inputnum1.text);
        num2 = int.Parse(inputnum2.text);
        txtResultado.text = (num1 + num2).ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
