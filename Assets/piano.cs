using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    AudioSource _do, _re, _mi, _pha, _son, _la, _si;
    SpriteRenderer _den,_trang,_xanh,_vang,_tim,_cam,_hong;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
        _do = GameObject.FindWithTag("do").GetComponent<AudioSource>();
        _re = GameObject.FindWithTag("re").GetComponent<AudioSource>();
        _mi = GameObject.FindWithTag("mi").GetComponent<AudioSource>();
        _pha = GameObject.FindWithTag("pha").GetComponent<AudioSource>();
        _son = GameObject.FindWithTag("son").GetComponent<AudioSource>();
        _la = GameObject.FindWithTag("la").GetComponent<AudioSource>();
        _si = GameObject.FindWithTag("si").GetComponent<AudioSource>();
        //-------------------------------------------------------------
        _den = GameObject.FindWithTag("do").GetComponent<SpriteRenderer>();
        _trang = GameObject.FindWithTag("re").GetComponent<SpriteRenderer>();
        _xanh = GameObject.FindWithTag("mi").GetComponent<SpriteRenderer>();
        _vang = GameObject.FindWithTag("pha").GetComponent<SpriteRenderer>();
        _tim = GameObject.FindWithTag("son").GetComponent<SpriteRenderer>();
        _cam = GameObject.FindWithTag("la").GetComponent<SpriteRenderer>();
        _hong = GameObject.FindWithTag("si").GetComponent<SpriteRenderer>();



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            _do.Play();
        }
        if (Input.GetKey(KeyCode.A))
        {
            _den.color = Color.black;
        }
        else
        {
            _den.color= Color.white;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            _re.Play();
        }
        if (Input.GetKey(KeyCode.S))
        {
            _trang.color = Color.red;
        }
        else
        {
            _trang.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            _mi.Play();
        }
        if (Input.GetKey(KeyCode.D))
        {
            _xanh.color = Color.green;
        }
        else
        {
            _xanh.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            _pha.Play();
        }
        if (Input.GetKey(KeyCode.F))
        {
            _vang.color = Color.white;
        }
        else
        {
            _den.color = Color.yellow;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            _son.Play();
        }
        if (Input.GetKey(KeyCode.G))
        {
            _tim.color = Color.red;
        }
        else
        {
            _tim.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            _la.Play();
        }
        if (Input.GetKey(KeyCode.H))
        {
            _cam.color = Color.yellow;
        }
        else
        {
            _den.color = Color.white;
        }
        if (Input.GetKeyDown(KeyCode.J))
        {
            _si.Play();
        }
        if (Input.GetKey(KeyCode.J))
        {
            _hong.color = Color.black;
        }
        else
        {
            _hong.color = Color.white;
        }
    }
}
