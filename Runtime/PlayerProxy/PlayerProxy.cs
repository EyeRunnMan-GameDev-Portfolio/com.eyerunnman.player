using com.eyerunnman.interfaces;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace com.eyerunnman.player
{
    public partial class PlayerProxy : MonoBehaviour
    {

        CachedComponents cachedComponents;
        private Player Player
        {
            get
            {
                if (cachedComponents is null)
                    cachedComponents = new(this);
                return cachedComponents.Player;
            }
        }

        [SerializeField]
        private PlayerConfig playerConfig;

        public void ExecuteCommand(ICommand<Player> command)
        {
            command.Execute(Player);
        }

        private void Awake()
        {
            ICommand<Player> setPlayerConfigCommand = new Player.Commands.SetConfig(playerConfig);

            ExecuteCommand(setPlayerConfigCommand);
        }
    }
}

