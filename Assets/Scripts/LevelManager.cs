using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    private int _countCoin;
    private Wallet _wallet;
    private CinemachineVirtualCamera _camera;
    private Player _player;

    // Start is called before the first frame update
    void Start()
    {
        _countCoin = GameObject.FindGameObjectsWithTag("Coin").Length;
        _wallet = FindObjectOfType<Wallet>();
        _camera = FindObjectOfType<CinemachineVirtualCamera>();
        _player = FindObjectOfType<Player>();

        _camera.Follow = _player.transform;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag != "Player") return;
        if (_countCoin != _wallet.count) return;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
}
