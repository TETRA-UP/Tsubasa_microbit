using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //���������t���[�c���i�[����z����쐬
    [SerializeField] private GameObject[] frutsPrefabs;

    //�t���[�c�𗎂Ƃ��I�u�W�F�N�g�̈ړ����x
    float speed = 0.05f;
    float defaultPos;
    [SerializeField]
    AudioClip sound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Component���擾
        audioSource = GetComponent<AudioSource>();
        defaultPos = transform.position.x;
        Pop();
    }

    // Update is called once per frame
    void Update()
    {
        //�����Ɉړ��̃v���O�����������܂��傤
       
            float x = transform.position.x + speed;
            if (x > defaultPos + 5.0f || x < defaultPos - 5.0f)
            {
                speed *= -1;
            }
            transform.position = new Vector3(x, transform.position.y, transform.position.z);
       
    }
    public void Pop()
    {
        //�ϐ��̒��Ƀ����_���Ȑ������i�[���Ă���
        int randomlndex=UnityEngine.Random.Range(0,frutsPrefabs.Length);
        //�t���[�c�̐���
        Instantiate(frutsPrefabs[randomlndex], transform.position, Quaternion.identity, transform);
        
        audioSource.PlayOneShot(sound);
    }
}