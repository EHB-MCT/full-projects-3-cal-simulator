using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScanManager : MonoBehaviour
{

    public GameObject unlock;
    // Start is called before the first frame update
    void Start()
    {
        unlock.SetActive(false);
        StartCoroutine(BetaTestScan());
    }

    IEnumerator BetaTestScan()
    {
        yield return new WaitForSeconds(5);
        unlock.SetActive(true);

    }
}
