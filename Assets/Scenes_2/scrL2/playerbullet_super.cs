using UnityEngine;

public class PlayerBulletSuper : MonoBehaviour
{
    private bool buttonPressed = false;
    private bool soundPlayed = false;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;

    private AudioSource audioSource;
    public AudioClip gunshotSound;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            buttonPressed = true;
            if (!soundPlayed)
            {
                audioSource.PlayOneShot(gunshotSound);
                soundPlayed = true;
            }
        }

        if (Input.GetKeyUp(KeyCode.E))
        {
            buttonPressed = false;
            soundPlayed = false;
        }

        if (buttonPressed)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);
            Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
            bulletRigidbody.velocity = transform.forward * bulletSpeed;

            Debug.Log("Bang!");
        }
    }
}