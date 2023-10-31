using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    private PlayerConfig _playerConfig;
    // Start is called before the first frame update

    private PlayerView _player;
    
    void Start()
    {
        _playerConfig = Resources.Load<PlayerConfig>("Configs/NewPlayerConfig");
        Resources.UnloadUnusedAssets();

        _player = Instantiate<PlayerView>(_playerConfig.Player);
        _player.CharacterMovement.SetSpeed(_playerConfig.Speed);
        _player.CameraMovement.SetSensivity(_playerConfig.Sensivity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            Destroy(_player.gameObject);
        }
    }
}
