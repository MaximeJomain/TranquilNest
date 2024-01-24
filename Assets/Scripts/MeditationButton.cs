using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MeditationButton : MonoBehaviour
{

    [SerializeField]
    private AudioSource m_AudioSource;

    [SerializeField]
    private AudioClip m_BreathClip1;

    [SerializeField]
    private AudioClip m_MeditationClip1;

    [SerializeField]
    private TMP_Text m_InstructionText;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PlayBreathClip()
    {
        if(m_AudioSource.isPlaying )
        {
            m_AudioSource.Stop();
        }
        m_AudioSource.clip = m_BreathClip1;
        m_AudioSource.Play();
        if (m_AudioSource.isPlaying)
        {
            m_InstructionText.text = "Asseyez vous confortablement, le dos droit";
            StartCoroutine(WaitNextText("Inspirez par le nez"));
        }
    }
    public void PlayMeditationClip()
    {
        if (m_AudioSource.isPlaying)
        {
            m_AudioSource.Stop();
        }
        m_AudioSource.clip = m_MeditationClip1;
        m_AudioSource.Play();
    }

    public void StopAudioClip()
    {
        if (m_AudioSource.isPlaying)
        {
            m_AudioSource.Stop();
        m_InstructionText.text = "";
            StopAllCoroutines();

        }
    }


     IEnumerator WaitNextText(string text)
    {
        yield return new WaitForSeconds(6.0f);
        m_InstructionText.text = text;
        StartCoroutine(WaitSecondText("Puis expirez par la bouche"));
    }

     IEnumerator WaitSecondText(string text) {
        yield return new WaitForSeconds(6.0f);
        m_InstructionText.text = text;
        StartCoroutine(WaitLastText("Répetez cette action en suivant le rythme"));

    }

     IEnumerator WaitLastText(string text)
    {
        yield return new WaitForSeconds(5.0f);
        m_InstructionText.text = text;
        StartCoroutine(HideText());
    }

     IEnumerator HideText()
    {
        yield return new WaitForSeconds(5.0f);
        m_InstructionText.text = "";
    }
}
