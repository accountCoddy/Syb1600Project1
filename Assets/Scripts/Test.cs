using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class Test : MonoBehaviour
{
    private int _countCoin;
    private Wallet _wallet;
    private Player _player;
    private CinemachineVirtualCamera _camera;

    // Start is called before the first frame update
    void Start()
    {
        _wallet = FindObjectOfType<Wallet>();
        _player = FindObjectOfType<Player>();
        _camera = FindObjectOfType<CinemachineVirtualCamera>();
        _countCoin = GameObject.FindGameObjectsWithTag("Coin").Length;

        _camera.Follow = _player.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player") return;
        if (_countCoin != _wallet.count) return;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
