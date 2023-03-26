using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class test : MonoBehaviour
{
    void Start()
    {
    }

    void Update()
    {
        ChineseMedicineIllustratedTest();
    }

    private void ChineseMedicineIllustratedTest() {
        if(Input.GetKeyDown(KeyCode.Z)) {
            Debug.Log(ChineseMedicineIllustrated.instance.GetMedicine("金银花").Name + ": " + 
            ChineseMedicineIllustrated.instance.GetMedicine("金银花").Description);
            Debug.Log(ChineseMedicineIllustrated.instance.GetMedicine("远志").Name + ": " + 
            ChineseMedicineIllustrated.instance.GetMedicine("远志").Description);
            Debug.Log(ChineseMedicineIllustrated.instance.GetMedicine("猫爪草").Name + ": " + 
            ChineseMedicineIllustrated.instance.GetMedicine("猫爪草").Description);
        }
    }

    public void myTest() {
        Debug.Log("test");
    }
}
