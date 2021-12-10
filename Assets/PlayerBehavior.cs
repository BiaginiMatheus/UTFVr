using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{

   // public AudioSource PlayerAudioSource;
    //public AudioClip[] FootstepSounds;

    public float velTransl;
    public float velRot;
    public Vector3 scaleSize;
    Vector3 deslocMouse;

    // Start is called before the first frame update
    void Start()
    {
        velTransl = 200f;
        scaleSize = new Vector3(0.09f, 0.09f, 0.09f) * Time.deltaTime;
        velRot = 50f;
    }

  /*  void playsStepsSound() {
        /*if (!m_CharacterController.isGrounded)
        {
            return;
        }///Checar se ta no chão
        int n = Random.Range(1, FootstepSounds.Length);
        //PlayerAudioSource.clip = FootstepSounds[n];
        //PlayerAudioSource.PlayOneShot(PlayerAudioSource.clip);
       
        //FootstepSounds[n] = FootstepSounds[0];
        //FootstepSounds[0] = PlayerAudioSource.clip;
    }*/

    Vector3 CoordMouse()
    {
        Vector3 coorMousetela = Input.mousePosition;
        coorMousetela.z = Camera.main.WorldToScreenPoint(transform.position).z;

        return Camera.main.ScreenToWorldPoint(coorMousetela);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            moveDown();
        }
        if (Input.GetKey(KeyCode.W))
        {
            moveUp();
        }
        if (Input.GetKey(KeyCode.A))
        {
            moveLeft();
        }
        if (Input.GetKey(KeyCode.D))
        {
            moveRight();
        }
        if (Input.GetKey(KeyCode.Q))
        {
            turnLeft();
        }
        if (Input.GetKey(KeyCode.E))
        {
            turnRight();
        }

    }
    void moveUp()
    {
        transform.Translate(0, 0, velTransl * Time.deltaTime);
        //playsStepsSound();
    }
    void moveDown()
    {
        transform.Translate(0, 0, -velTransl * Time.deltaTime);
      //  playsStepsSound();
    }
    void moveLeft()
    {
        transform.Translate(-velTransl * Time.deltaTime, 0, 0);
       // playsStepsSound();
    }
    void moveRight()
    {
        transform.Translate(velTransl * Time.deltaTime, 0, 0);
        //playsStepsSound();
    }
    void turnLeft()
    {
        transform.Rotate(0, -velRot * Time.deltaTime, 0);
    }
    void turnRight()
    {
        transform.Rotate(0, velRot * Time.deltaTime, 0);
    }
}
