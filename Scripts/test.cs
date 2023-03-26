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
            List<ChineseMedicineIllustratedData> medicines = ChineseMedicineIllustrated.instance.medicinesList;
            for(int i = 0; i < medicines.Count; i++) {
                Debug.Log(medicines[i].Name + "_" + medicines[i].Description + "_" + medicines[i].Sprite);
            }
        }
    }

    public void myTest() {
        Debug.Log("test");
    }
}
