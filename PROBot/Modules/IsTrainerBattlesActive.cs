﻿using System;
using PROProtocol;

namespace PROBot.Modules
{
	public class IsTrainerBattlesActive
	{
		public event Action<bool> StateChanged;
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    _bot.Game.IsTrainerBattlesActive = value;
                    StateChanged?.Invoke(value);
                }
            }
        }
        public IsTrainerBattlesActive(BotClient bot)
		{
			_bot = bot;
			_bot.ClientChanged += Bot_ClientChanged;
		}
		private void Bot_ClientChanged()
		{
			GameClient game = _bot.Game;
		}
		private bool _isEnabled = true;

		private BotClient _bot;
	}
}
