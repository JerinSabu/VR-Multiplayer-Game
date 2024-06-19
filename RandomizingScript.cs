using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizingScript : MonoBehaviour
{
    public string key1;
    public string key2;
    public int[] pas = { 0, 0, 0 };
    private int one = 1;
    private int four = 4;
    public int delayTime =60;
    private float currentTime =0;


    // Start is called before the first frame update
    void Start()
    {
        do
        {
            Generate();
        }while(false);
    }

    // Update is called once per frame
    void Update()
    {
        GenerateNew();
        //StartCoroutine(DeyaledCode());

    }


    public void GenerateKeyOne()
    {
        key1 = ColourPicker();
        CommonData.buttonOneKey = key1;
    }


    public void GenerateKeyTwo()
    {
        key2 = ColourPicker();
        CommonData.buttonTwoKey = key2;
    }

    public void GeneratePassword()
    { for(int i = 0; i < 3; i++)
        {
            int r = Random.Range(one, four);
            if (r == 1) pas[i] = 1;
            if (r == 2) pas[i] = 2;
            else pas[i] =3;
        }
        CommonData.password = pas;

    }


    public string ColourPicker()
    {
        int r = Random.Range(one, four);
        if (r == 1) return "Red";
        if (r == 2) return "Green";
        else return "Blue";

    }

    IEnumerator DeyaledCode()
    {

        yield return new WaitForSeconds(delayTime);
        Generate();

    }

    public void GenerateNew()
    {
        currentTime += Time.deltaTime;

        if (currentTime >= delayTime)
        {
            Generate();
            currentTime = 0;
        }
    }

    public void Generate()
    {
        if (!CommonData.buttonOne) GenerateKeyOne();
        if (!CommonData.buttonTwo) GenerateKeyTwo();
        if (!CommonData.keyPassUnlocked) GeneratePassword();
    }
}
