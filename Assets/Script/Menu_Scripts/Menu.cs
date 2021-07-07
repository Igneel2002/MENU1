using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    [SerializeField]
    private GameObject start;
    [SerializeField]
    private GameObject stats;
    [SerializeField]
    private GameObject resume;
    [SerializeField]
    private GameObject Invent;
    [SerializeField]
    private GameObject options;
    [SerializeField]
    private GameObject options1;
    [SerializeField]
    private GameObject Tip;
    public AudioSource sound;
    [SerializeField]
    private bool Resume;
    public AudioMixer masterAudio;
    [SerializeField]
    private bool Res;
    [SerializeField]
    private GameObject mute;
    [SerializeField]
    private GameObject mute1;
    [SerializeField]
    private GameObject unmute;
    [SerializeField]
    private GameObject unmute1;
    [SerializeField]
    private float STR = 0f;
    [SerializeField]
    private float INT = 0f;
    [SerializeField]
    private float VIT = 0f;
    [SerializeField]
    private float WIS = 0f;
    [SerializeField]
    private float CON = 0f;
    [SerializeField]
    private float CHA = 0f;
    [SerializeField]
    private float STATS = 60f;
    [SerializeField]
    public Text STRtext;
    [SerializeField]
    public Text INTtext;
    [SerializeField]
    public Text VITtext;
    [SerializeField]
    public Text WIStext;
    [SerializeField]
    public Text CONtext;
    [SerializeField]
    public Text CHAtext;
    [SerializeField]
    public Text STATStext;

    public void ChangeVolume(float volume)
    {
        masterAudio.SetFloat("volume", volume);
    }

    private void Start()
    {
        resume.SetActive(false);
        Invent.SetActive(false);
        options.SetActive(false);
        options1.SetActive(false);
        stats.SetActive(false);
        start.SetActive(true);
        Time.timeScale = 0;
        sound.mute = false;
        Tip.SetActive(false);
        Res = false;
        mute.SetActive(false);
    }

    public void LOAD()
    {
        start.SetActive(false);
        stats.SetActive(true);
    }

    public void DONE()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Time.timeScale = 1;
        stats.SetActive(false);
        Tip.SetActive(true);
        Resume = true;
        Res = true;
    }

    public void MUTE()
    {
        sound.mute = true;
        mute.SetActive(false);
        unmute.SetActive(true);
    }
    
    public void MUTE1()
    {
        sound.mute = true;
        mute1.SetActive(false);
        unmute1.SetActive(true);
    }

    public void UNMUTE()
    {
        sound.mute = false;
        mute.SetActive(true);
        unmute.SetActive(false);
    }
    
    public void UNMUTE1()
    {
        sound.mute = false;
        mute1.SetActive(true);
        unmute1.SetActive(false);
    }

    public void mainmenu()
    {
        resume.SetActive(false);
        start.SetActive(true);
        sound.mute = true;
        Res = false;
    }

    public void RESUME()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        resume.SetActive(false);
        Time.timeScale = 1;
        Tip.SetActive(true);
        Resume = true;
    }

    public void OPTIONSog()
    {
        start.SetActive(false);
        options.SetActive(true);
    }
    
    public void OPTIONSnew()
    {
        resume.SetActive(false);
        options1.SetActive(true);
    }
    
    public void ReturnOG()
    {
        options.SetActive(false);
        start.SetActive(true);
    }
    
    public void ReturnNew()
    {
        options1.SetActive(false);
        resume.SetActive(true);
    }

    public void SAVE()
    {

    }

    public void Update()
    {
        if (Input.GetKeyDown("p"))
        {
            if (Resume == true && Res == true)
            {
                Screen.lockCursor = false;
                resume.SetActive(true);
                Time.timeScale = 0;
                Tip.SetActive(false);
                StartCoroutine(Delay(0.11f));
            }

            if (Resume != true && Res == true)
            {
                Screen.lockCursor = true;
                resume.SetActive(false);
                Time.timeScale = 1;
                Tip.SetActive(true);
                sound.mute = false;
                StartCoroutine(Delay2(0.1f));
            }
        }
        
        if (Input.GetKeyDown("i"))
        {
            if (Resume == true && Res == true)
            {
                Screen.lockCursor = false;
                Invent.SetActive(true);
                Time.timeScale = 0;
                Tip.SetActive(false);
                StartCoroutine(Delay(0.11f));
            }

            if (Resume != true && Res == true)
            {
                Screen.lockCursor = true;
                Invent.SetActive(false);
                Time.timeScale = 1;
                Tip.SetActive(true);
                sound.mute = false;
                StartCoroutine(Delay2(0.1f));
            }
        }
        
        if (Input.GetKeyDown("o"))
        {
            if (Resume == true && Res == true)
            {
                Screen.lockCursor = false;
                stats.SetActive(true);
                Time.timeScale = 0;
                Tip.SetActive(false);
                StartCoroutine(Delay(0.11f));
            }

            if (Resume != true && Res == true)
            {
                Screen.lockCursor = true;
                stats.SetActive(false);
                Time.timeScale = 1;
                Tip.SetActive(true);
                sound.mute = false;
                StartCoroutine(Delay2(0.1f));
            }
        }
        STATStext.text = "Stat Points " + (int)STATS;
        STRtext.text = "STR " + (int)STR;
        INTtext.text = "INT " + (int)INT;
        VITtext.text = "VIT " + (int)VIT;
        WIStext.text = "WIS " + (int)WIS;
        CONtext.text = "CON " + (int)CON;
        CHAtext.text = "CHA " + (int)CHA;
    }

    public void AddSTR()
    {
        if (STATS != 0)
        {
            STR += 1;
            STATS -= 1;
        }
    }

    public void AddINT()
    {
        if (STATS != 0)
        {
            INT += 1;
            STATS -= 1;
        }
    }

    public void AddVIT()
    {
        if (STATS != 0)
        {
            VIT += 1;
            STATS -= 1;
        }
    }

    public void AddWIS()
    {
        if (STATS != 0)
        {
            WIS += 1;
            STATS -= 1;
        }
    }

    public void AddCON()
    {
        if (STATS != 0)
        {
            CON += 1;
            STATS -= 1;
        }
    }

    public void AddCHA()
    {
        if (STATS != 0)
        {
            CHA += 1;
            STATS -= 1;
        }
    }

    public void SubSTR()
    {
        if (STR != 0)
        {
            STATS += 1;
            STR -= 1;
        }
    }

    public void SubINT()
    {
        if (INT != 0)
        {
            STATS += 1;
            INT -= 1;
        }
    }

    public void SubVIT()
    {
        if (VIT != 0)
        {
            STATS += 1;
            VIT -= 1;
        }
    }

    public void SubWIS()
    {
        if (WIS != 0)
        {
            STATS += 1;
            WIS -= 1;
        }
    }

    public void SubCON()
    {
        if (CON != 0)
        {
            STATS += 1;
            CON -= 1;
        }
    }

    public void SubCHA()
    {
        if (CHA != 0)
        {
            STATS += 1;
            CHA -= 1;
        }
    }

    public IEnumerator Delay(float _Delay)
    {
        yield return new WaitForSecondsRealtime(_Delay);

        Resume = false;
    }

    public IEnumerator Delay2(float _Delay)
    {
        yield return new WaitForSecondsRealtime(_Delay);

        Resume = true;
    }

    public void EXIT()
    {
#if     UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
