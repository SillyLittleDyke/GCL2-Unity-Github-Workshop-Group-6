using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Jumpscare : MonoBehaviour
{
    [Header("UI Elements")]
    public Image jumpscareImage;
    public float jumpscareDuration = 1.5f;

    [Header("Audio")]
    public AudioSource jumpscareSound;
    private bool hasTriggered = false;
    private void OnTriggerEnter2D(Collider2D other)
    {
       if (!hasTriggered && other.CompareTag("Player"))
        {
            StartCoroutine(PlayJumpscare());
        }

        IEnumerator PlayJumpscare()
        {
            hasTriggered = true;
            jumpscareImage.gameObject.SetActive(true);

            if(jumpscareSound !=null) 
            { 
                jumpscareSound.Play();
            }

            yield return new WaitForSecondsRealtime(jumpscareDuration); 
            
            jumpscareImage.gameObject.SetActive(false);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
