using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healsbar : MonoBehaviour
{

    Image bar;
    public float HP;
    public float MAX_HP = 100f;
    void Start()
    {
        bar = GetComponent<Image>();
        HP = MAX_HP;
    }

    void Update()
    {
         bar.fillAmount = HP / MAX_HP ;
    }


}
