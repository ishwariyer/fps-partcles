using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThunderClap : MonoBehaviour
{
    public AudioClip clip;
    bool CanFlicker = true;
    private void Update()
    {
        StartCoroutine(Flicker ());
    }

    IEnumerator Flicker()
    {
        if(CanFlicker)
        {
            CanFlicker = false;
            GetComponent<AudioSource>().PlayOneShot(clip);
            GetComponent<Light>().enabled = true;
            yield return new WaitForSeconds(Random.Range(0.1f , 0.5f));
            GetComponent<Light>().enabled = false;
            yield return new WaitForSeconds(Random.Range(0.1f, 5));
            CanFlicker = true;
        }
    }
}
