using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChineseMedicineIllustratedInit : MonoBehaviour
{
    public List<ChineseMedicineIllustratedData> medicines;

    void Start()
    {
        StartCoroutine(WaitInit());
    }

    // todo: 改成加载完ChineseMedicineIllustrated之后再执行
    IEnumerator WaitInit() {
        yield return new WaitForSeconds(2.0f);
        medicines = new List<ChineseMedicineIllustratedData>();
        medicines.Add(new ChineseMedicineIllustratedData("金银花", "金银花具有清热解毒，疏散风热的功效", "金银花.png"));
        medicines.Add(new ChineseMedicineIllustratedData("远志", "远志具有安神益智，交通心肾，祛痰，消肿的功效", "远志.png"));
        medicines.Add(new ChineseMedicineIllustratedData("猫爪草", "猫爪草具有化痰散结、解毒消肿的功效", "猫爪草.png"));

        for(int i = 0; i < medicines.Count; i++) {
            ChineseMedicineIllustrated.instance.AddData(medicines[i]);
        }
    }
}
