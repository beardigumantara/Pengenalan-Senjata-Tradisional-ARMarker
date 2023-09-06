using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Description : MonoBehaviour
{
    [Header("Deskripsi Senjata")]
    public TrackableAr[] tr;
    public string[] nama;
    [TextArea]
    public string[] deskripsi;

    [Header("UI AR")]
    public Text txtNama;
    public Text txtDeskripsi;
    public GameObject goNama;
    public GameObject goDeskripsi;

    public GameObject Message;
    public bool[] cekMarker;
    int countMarker;
    // Start is called before the first frame update
    void Start()
    {
        cekMarker = new bool[tr.Length];

    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i< tr.Length; i++)
        {
            if (tr[i].GetMarker())
            {
                txtNama.text = nama[i];
                txtDeskripsi.text = deskripsi[i];
                
                if(!cekMarker[i])
                {
                    countMarker++;
                    cekMarker[i] = true;
                }
            }else
            {
                if (cekMarker[i])
                {
                    countMarker--;
                    cekMarker[i] = false;
                }
            }
        }
        DeskripsiPanel();
        
        if (Application.platform == RuntimePlatform.Android){
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                SceneManager.LoadScene("Homepage");
            }
        }
    }

    private void DeskripsiPanel(){
        if (countMarker == 0){
            goNama.SetActive(false);
            goDeskripsi.SetActive(false);
            Message.SetActive(true);
        }else{
            goNama.SetActive(true);
            goDeskripsi.SetActive(true);
            Message.SetActive(false);
        }
    }
}
