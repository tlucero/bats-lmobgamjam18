using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Green : MonoBehaviour
{
    [SerializeField] private GameObject greenLight;
    public bool canInteract;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (canInteract)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                StartCoroutine(SequenceWhite());
            }
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        greenLight.SetActive(false);
        canInteract = true;
        
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        greenLight.SetActive(true);
        canInteract = false;
    }

    IEnumerator SequenceWhite()
    {
        yield return new WaitForSeconds(1f);
        greenLight.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        greenLight.SetActive(false);
        
        yield return new WaitForSeconds(0.5f);
        greenLight.SetActive(true);
        yield return new WaitForSeconds(0.15f);
        greenLight.SetActive(false);
        
        yield return new WaitForSeconds(1f);
    }
}
