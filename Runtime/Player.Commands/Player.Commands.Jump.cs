﻿using com.eyerunnman.interfaces;

namespace com.eyerunnman.player
{
    public partial class Player
    {
        public partial class Commands
        {
            public class Jump : ICommand<Player>
            {
                public void Execute(Player player)
                {
                    if (player.CurrentState is not Player.State.Jump)
                    {
                        player.JumpInput = true;
                    }
                    else
                    {
                        player.JumpInput = false;
                    }
                }
            }

        }
    }

}

