using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScreenData : MonoBehaviour
{
    public TextMeshProUGUI k1;
    public TextMeshProUGUI k2;
    public TextMeshProUGUI pass;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        k1.text = CommonData.buttonOneKey.ToString();
        k2.text = CommonData.buttonTwoKey.ToString();
        string result = string.Join("", CommonData.password);
        pass.text = result;
    }
}
