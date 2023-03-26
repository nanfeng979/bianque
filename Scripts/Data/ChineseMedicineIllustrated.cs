using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChineseMedicineIllustrated : MonoBehaviour
{
    public static ChineseMedicineIllustrated instance;
    public List<ChineseMedicineIllustratedData> medicinesList = new List<ChineseMedicineIllustratedData>();

    void Start()
    {
        instance = this;
    }

    public void AddMedicine(ChineseMedicineIllustratedData medicine)
    {
        if(GetMedicine(medicine.Name) != null) {
            Debug.Log("exists");
            return ;
        }
        medicinesList.Add(medicine);
    }

    public void RemoveMedicine(ChineseMedicineIllustratedData medicine)
    {
        medicinesList.Remove(medicine);
    }

    public ChineseMedicineIllustratedData GetMedicine(string name)
    {
        foreach (ChineseMedicineIllustratedData medicine in medicinesList)
        {
            if (medicine.Name == name)
            {
                return medicine;
            }
        }
        return null;
    }

}
